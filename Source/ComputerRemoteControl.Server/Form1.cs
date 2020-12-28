using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using ComputerRemoteControl.Shared;
using System.Diagnostics;

namespace ComputerRemoteControl.Server
{
    public partial class Form1 : Form
    {
        TcpListener server;
        List<User> users;
        object fileLogLock = new object();
        Color processingColor = Color.DarkOrange;
        public Form1()
        {
            InitializeComponent();
            this.btnListen.Click += listenClicked;
            this.users = new List<User>(User.GetUsers(Path.Combine(Directory.GetCurrentDirectory(), "users.json")));
        }

        private void listenClicked(object sender, EventArgs e)
        {
            SetStatus("Initializing server...", processingColor);

            int port;
            if (!int.TryParse(this.txtPort.Text, out port))
            {
                SetStatus("Invalid port.", Color.Red);
                return;
            }

            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            new Thread(async () => await ListenToClientConnections()).Start();

            SetStatus("Server is running...", Color.Green);
        }

        private async Task ListenToClientConnections()
        {
            while (true)
            {
                var client = await server.AcceptTcpClientAsync();
                new Thread(async () => await listenToClientRequestsAsync(client)).Start();
            }
        }

        private async Task listenToClientRequestsAsync(TcpClient client)
        {
            using (StreamReader reader = new StreamReader(client.GetStream()))
            {
                using (StreamWriter writer = new StreamWriter(client.GetStream()))
                { 
                    while (client.Connected)
                    {
                        var request = ClientRequest.GetRequestObject(await reader.ReadLineAsync());
                        string endPoint = "";

                        switch (request.Command)
                        {
                            case Command.Shutdown:

                                #region Shutdown

                                Process.Start("shutdown", "/s -t 30");
                                await writer.WriteLineAsync(ServerResponse.GetResponseJson(new ServerResponse
                                {
                                    IsSuccess = true,
                                    Message = "Remote computer is shutting down..."
                                }));
                                await writer.FlushAsync();
                                break;

                            #endregion

                            case Command.Restart:

                                #region Restart

                                Process.Start("shutdown", "/r -t 30");
                                await writer.WriteLineAsync(ServerResponse.GetResponseJson(new ServerResponse
                                {
                                    IsSuccess = true,
                                    Message = "Remote computer is restarting..."
                                }));
                                await writer.FlushAsync();
                                break;

                            #endregion

                            case Command.Processes:

                                #region Processes

                                await writer.WriteLineAsync(ServerResponse.GetResponseJson(new ServerResponse
                                {
                                    IsSuccess = true,
                                    Message = "Processes have been retrieved...",
                                    //ResponseValues = new Dictionary<string, IEnumerable<object>>
                                    //{
                                    //    {"Processes", new List<CustomProcess>(Process
                                    //    .GetProcesses().Select(p => new CustomProcess{ Id = p.Id, Name = p.ProcessName})) }
                                    //}
                                    Processes = Process.GetProcesses().Select(p => new CustomProcess { Id = p.Id, Name = p.ProcessName })
                                }));

                                await writer.FlushAsync();
                                break;

                            #endregion

                            case Command.StartProcess:

                                #region Start Process

                                var response = new ServerResponse();
                                string processName = request.RequestValues["ProcessName"];

                                try { Process.Start(processName); }
                                catch
                                {
                                    response.IsSuccess = false;
                                    response.Message = "Invalid process name.";
                                    await writer.WriteLineAsync(ServerResponse.GetResponseJson(response));
                                    await writer.FlushAsync();
                                    break;
                                }

                                response.IsSuccess = true;
                                response.Message = "Process has been started.";
                                await writer.WriteLineAsync(ServerResponse.GetResponseJson(response));
                                await writer.FlushAsync();
                                break;

                            #endregion

                            case Command.StopProcess:

                                #region Stop Process

                                var response1 = new ServerResponse();
                                int processId = Convert.ToInt32(request.RequestValues["ProcessId"]);

                                try { Process.GetProcessById(processId).Kill(); }
                                catch
                                {
                                    response1.IsSuccess = false;
                                    response1.Message = "Invalid process id.";
                                    await writer.WriteLineAsync(ServerResponse.GetResponseJson(response1));
                                    await writer.FlushAsync();
                                    break;
                                }
                                response1.IsSuccess = true;
                                response1.Message = "Process has been stopped.";
                                await writer.WriteLineAsync(ServerResponse.GetResponseJson(response1));
                                await writer.FlushAsync();
                                break;

                            #endregion

                            case Command.ShowDirectoryContent:

                                #region Show Directory Content

                                var response2 = new ServerResponse();
                                string path = request.RequestValues["DirectoryPath"];

                                if (!Directory.Exists(path))
                                {
                                    response2.IsSuccess = false;
                                    response2.Message = "Directory doesn't exist.";
                                    await writer.WriteLineAsync(ServerResponse.GetResponseJson(response2));
                                    await writer.FlushAsync();
                                    break;
                                }

                                var directories = Directory.GetDirectories(path).OrderBy(d => d).Select(d => d);
                                var files = Directory.GetFiles(path).OrderBy(f => f).Select(f => Path.GetFileName(f));

                                response2.IsSuccess = true;
                                response2.Message = "Content has been delivered.";
                                response2.ResponseValues = new Dictionary<string, IEnumerable<object>>
                                {
                                    {"Directories", directories},
                                    {"Files", files}
                                };

                                await writer.WriteLineAsync(ServerResponse.GetResponseJson(response2));
                                await writer.FlushAsync();
                                break;

                            #endregion

                            case Command.Login:

                                #region Login

                                var loginResponse = new ServerResponse();

                                var email = request.RequestValues["Email"];
                                var password = request.RequestValues["Password"];

                                var user = users.SingleOrDefault(u => u.Email.Equals(email));

                                if (user == null)
                                {
                                    loginResponse.IsSuccess = false;
                                    loginResponse.Message = "Invalid Login Attempt";
                                }
                                else
                                {
                                    if (!user.Password.Equals(password))
                                    {
                                        loginResponse.IsSuccess = false;
                                        loginResponse.Message = "Invalid Login Attempt";
                                    }
                                    else
                                    {
                                        loginResponse.IsSuccess = true;
                                        loginResponse.Message = "Logged in successfully";
                                    }
                                }

                                await writer.WriteLineAsync(ServerResponse.GetResponseJson(loginResponse));

                                await writer.FlushAsync();

                                #endregion

                                break;
                            case Command.NoCommand:
                                endPoint = client.Client.RemoteEndPoint.ToString();
                                client.Close();
                                break;
                            default:
                                break;
                        }

                        string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");

                        if (!client.Connected)
                        {
                            File.AppendAllText(logFilePath, $"User: {endPoint} " +
                                                            "Command: Disconnect " +
                                                            $"Date: {DateTime.UtcNow.ToLocalTime()}");
                            break;
                        }

                        lock (fileLogLock)
                        {
                            FileStream fileStream = null;
                            if (!File.Exists(logFilePath))
                            {
                                fileStream = File.Create(logFilePath);
                            }
                            else
                            {
                                fileStream = new FileStream(logFilePath, FileMode.Append, FileAccess.Write);
                            }

                            using (StreamWriter streamWriter = new StreamWriter(fileStream))
                            {
                                streamWriter.WriteLine($"User: {client.Client.RemoteEndPoint} " +
                                                        $"Command: {request.Command.ToString()} " +
                                                        $"Date: {DateTime.UtcNow.ToLocalTime()}");
                                streamWriter.Flush();
                            }
                        }
                    }
                }
            }
        }

        #region Private Helper Methods

        private void SetStatus(string message, Color foregroundColor)
        {
            this.lblStatus.Text = message.Trim();
            this.lblStatus.ForeColor = foregroundColor;
        }

        #endregion
    }
}

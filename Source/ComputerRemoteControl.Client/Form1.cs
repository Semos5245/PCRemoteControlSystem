using System;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using ComputerRemoteControl.Shared;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;

namespace ComputerRemoteControl.Client
{
    public partial class Form1 : Form
    {
        TcpClient client;
        StreamWriter writer;
        StreamReader reader;
        Color processingColor = Color.DarkOrange;
        public Form1()
        {
            InitializeComponent();

            //Subscribtion of events
            this.btnConnect.Click += onConnectClicked;
            this.btnLogin.Click += onLoginClicked;
            this.btnDisconnect.Click += onDisconnectClicked;
            this.btnProcesses.Click += onProcessesClicked;
            this.btnShutdown.Click += onShutdownClicked;
            this.btnRestart.Click += onRestartClicked;
            this.btnStartProcess.Click += onStartProcessClicked;
            this.btnStopProcess.Click += onStopProcessClicked;
            this.btnShowContent.Click += onShowContentClicked;
            this.FormClosing += onFormClosing;
            pMainControl.Visible = false;
            pLogin.Visible = false;
            pConnection.Visible = true;
        }

        private void onFormClosing(object sender, FormClosingEventArgs e)
        {
            onDisconnectClicked(sender, e);
        }

        #region Event Handlers

        private async void onConnectClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtAddress.Text))
            {
                SetMessage("Invalid Ip Address.", Color.Red);
                return;
            }

            int port;
            if (!int.TryParse(this.txtPort.Text, out port))
            {
                SetMessage("Invalid Port.", Color.Red);
                return;
            }

            SetConnectionStatus("Connecting...", Color.DarkOrange);

            try
            {
                client = new TcpClient();
                await client.ConnectAsync(this.txtAddress.Text, port);
                if (client.Client.Connected)
                {
                    this.writer = new StreamWriter(client.GetStream());
                    this.reader = new StreamReader(client.GetStream());
                    pConnection.Visible = false;
                    pLogin.Visible = true;
                    SetConnectionStatus("Connected.", Color.Green);
                }
                else
                {
                    SetConnectionStatus("Connection Error.", Color.Red);
                }
            }
            catch (Exception)
            {
                SetConnectionStatus("Connection Error", Color.Red);
            }
        }

        private void onDisconnectClicked(object sender, EventArgs e)
        {
            client.Close();
            //client.Client.Disconnect(false);

            SetConnectionStatus("No Connection", Color.Black);
            SetMessage("", Color.Black);

            this.lstDirectoryContent.Items.Clear();
            this.lstProcesses.Items.Clear();
            this.txtDirectory.Text = string.Empty;
            this.txtProcessId.Text = string.Empty;
            this.txtProcessName.Text = string.Empty;
            pConnection.Visible = true;
            pMainControl.Visible = false;
            pLogin.Visible = false;

            this.writer.Dispose();
            this.reader.Dispose();
        }

        private async void onLoginClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                SetMessage("Invalid Email..", Color.Red);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                SetMessage("Invalid Password..", Color.Red);
                return;
            }

            await writer.WriteLineAsync(ClientRequest.GetRequestJson(new ClientRequest
            {
                Command = Command.Login,
                RequestValues = new Dictionary<string, string>
                {
                    {"Email", txtEmail.Text },
                    {"Password", txtPassword.Text }
                }
            }));

            await writer.FlushAsync();

            var response = ServerResponse.GetResponseObject(await reader.ReadLineAsync());

            if (response.IsSuccess)
            {
                pLogin.Visible = false;
                pMainControl.Visible = true;
                SetMessage("", Color.Black);
            }
            else
            {
                SetMessage(response.Message, Color.Red);
            }
        }

        private async void onProcessesClicked(object sender, EventArgs e)
        {
            SetMessage("Retrieving Processes...", processingColor);

            await writer.WriteLineAsync(ClientRequest.GetRequestJson(new ClientRequest
            {
                Command = Command.Processes
            }));

            await writer.FlushAsync();

            var responseJson = await reader.ReadLineAsync();
            var response = ServerResponse.GetResponseObject(responseJson);

            if (response.IsSuccess)
            {
                this.lstProcesses.Items.Clear();
                var obj = response.Processes;
                foreach (var process in obj)
                {
                    this.lstProcesses
                        .Items.Add(new ListViewItem(new string[] { process.Id.ToString(), process.Name }));
                }

                SetMessage(response.Message, Color.Green);
            }
            else
            {
                SetMessage(response.Message, Color.Red);
            }
        }

        private async void onShutdownClicked(object sender, EventArgs e)
        {
            SetMessage("Shuting down remote computer..", processingColor);

            await writer.WriteLineAsync(ClientRequest.GetRequestJson(new ClientRequest
            {
                Command = Command.Shutdown
            }));

            await writer.FlushAsync();

            var response = ServerResponse.GetResponseObject(await reader.ReadLineAsync());

            if (response.IsSuccess)
            {
                SetMessage(response.Message, Color.Green);
            }
            else
            {
                SetMessage(response.Message, Color.Red);
            }
        }

        private async void onRestartClicked(object sender, EventArgs e)
        {
            SetMessage("Restarting remote computer..", processingColor);

            await writer.WriteLineAsync(ClientRequest.GetRequestJson(new ClientRequest
            {
                Command = Command.Restart
            }));

            await writer.FlushAsync();

            var response = ServerResponse.GetResponseObject(await reader.ReadLineAsync());

            if (response.IsSuccess)
            {
                SetMessage(response.Message, Color.Green);
            }
            else
            {
                SetMessage(response.Message, Color.Red);
            }
        }

        private async void onStartProcessClicked(object sender, EventArgs e)
        {
            SetMessage("Starting process at remote computer..", processingColor);

            if (string.IsNullOrWhiteSpace(this.txtProcessName.Text))
            {
                SetMessage("Invalid process name.", Color.Red);
                return;
            }

            await writer.WriteLineAsync(ClientRequest.GetRequestJson(new ClientRequest
            {
                Command = Command.StartProcess,
                RequestValues = new Dictionary<string, string> { { "ProcessName", this.txtProcessName.Text } }
            }));

            await writer.FlushAsync();

            var response = ServerResponse.GetResponseObject(await reader.ReadLineAsync());

            if (response.IsSuccess)
            {
                SetMessage(response.Message, Color.Green);
            }
            else
            {
                SetMessage(response.Message, Color.Red);
            }
        }

        private async void onStopProcessClicked(object sender, EventArgs e)
        {
            SetMessage("Stopping process at remote computer..", processingColor);

            if (string.IsNullOrWhiteSpace(this.txtProcessId.Text))
            {
                SetMessage("Invalid process Id.", Color.Red);
                return;
            }

            await writer.WriteLineAsync(ClientRequest.GetRequestJson(new ClientRequest
            {
                Command = Command.StopProcess,
                RequestValues = new Dictionary<string, string> { { "ProcessId", this.txtProcessId.Text } }
            }));

            await writer.FlushAsync();

            var response = ServerResponse.GetResponseObject(await reader.ReadLineAsync());

            if (response.IsSuccess)
            {
                SetMessage(response.Message, Color.Green);
            }
            else
            {
                SetMessage(response.Message, Color.Red);
            }
        }

        private async void onShowContentClicked(object sender, EventArgs e)
        {
            SetMessage("Retrieving content of specified directory...", processingColor);

            if (string.IsNullOrWhiteSpace(this.txtDirectory.Text))
            {
                SetMessage("Invalid Directory.", Color.Red);
                return;
            }

            await writer.WriteLineAsync(ClientRequest.GetRequestJson(new ClientRequest
            {
                Command = Command.ShowDirectoryContent,
                RequestValues = new Dictionary<string, string> { { "DirectoryPath", $"{this.txtDirectory.Text}" } }
            }));

            await writer.FlushAsync();

            var response = ServerResponse.GetResponseObject(await reader.ReadLineAsync());

            if (response.IsSuccess)
            {
                this.lstDirectoryContent.Items.Clear();

                var directories = response.ResponseValues["Directories"].Cast<string>();
                var files = response.ResponseValues["Files"].Cast<string>();

                foreach (var directory in directories)
                {
                    this.lstDirectoryContent.Items.Add(new ListViewItem(new string[] { directory.ToString() }));
                }

                foreach (var file in files)
                {
                    this.lstDirectoryContent.Items.Add(new ListViewItem(new string[] { file.ToString() }));
                }

                SetMessage(response.Message, Color.Green);
            }
            else
            {
                SetMessage(response.Message, Color.Red);
            }
        }

        #endregion

        #region Private Helper Methods

        private void SetMessage(string message, Color foregroundColor)
        {
            this.lblMessage.Text = message;
            this.lblMessage.ForeColor = foregroundColor;
        }

        private void SetConnectionStatus(string status, Color foregroundColor)
        {
            this.lblConnectionStatus.Text = status;
            this.lblConnectionStatus.ForeColor = foregroundColor;
        }

        #endregion


    }
}

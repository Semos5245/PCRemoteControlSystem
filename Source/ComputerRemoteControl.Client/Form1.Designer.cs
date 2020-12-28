namespace ComputerRemoteControl.Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.pCommands = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnProcesses = new System.Windows.Forms.Button();
            this.pProcesses = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcessId = new System.Windows.Forms.TextBox();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.btnStopProcess = new System.Windows.Forms.Button();
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstProcesses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.pFilesResults = new System.Windows.Forms.Panel();
            this.lstDirectoryContent = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowContent = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pMainControl = new System.Windows.Forms.Panel();
            this.pConnection = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pLogin = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pCommands.SuspendLayout();
            this.pProcesses.SuspendLayout();
            this.pFilesResults.SuspendLayout();
            this.pMainControl.SuspendLayout();
            this.pConnection.SuspendLayout();
            this.pLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(403, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Client";
            // 
            // pCommands
            // 
            this.pCommands.Controls.Add(this.btnDisconnect);
            this.pCommands.Controls.Add(this.btnRestart);
            this.pCommands.Controls.Add(this.btnShutdown);
            this.pCommands.Location = new System.Drawing.Point(31, 230);
            this.pCommands.Name = "pCommands";
            this.pCommands.Size = new System.Drawing.Size(501, 114);
            this.pCommands.TabIndex = 2;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(355, 45);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(101, 28);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnet";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(205, 46);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(101, 28);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.Location = new System.Drawing.Point(43, 46);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(101, 28);
            this.btnShutdown.TabIndex = 0;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            // 
            // btnProcesses
            // 
            this.btnProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesses.Location = new System.Drawing.Point(72, 299);
            this.btnProcesses.Name = "btnProcesses";
            this.btnProcesses.Size = new System.Drawing.Size(84, 21);
            this.btnProcesses.TabIndex = 2;
            this.btnProcesses.Text = "Processes";
            this.btnProcesses.UseVisualStyleBackColor = true;
            // 
            // pProcesses
            // 
            this.pProcesses.Controls.Add(this.label7);
            this.pProcesses.Controls.Add(this.label6);
            this.pProcesses.Controls.Add(this.txtProcessId);
            this.pProcesses.Controls.Add(this.btnProcesses);
            this.pProcesses.Controls.Add(this.txtProcessName);
            this.pProcesses.Controls.Add(this.btnStopProcess);
            this.pProcesses.Controls.Add(this.btnStartProcess);
            this.pProcesses.Controls.Add(this.label3);
            this.pProcesses.Controls.Add(this.lstProcesses);
            this.pProcesses.Location = new System.Drawing.Point(538, 12);
            this.pProcesses.Name = "pProcesses";
            this.pProcesses.Size = new System.Drawing.Size(321, 332);
            this.pProcesses.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Process Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Process Id :";
            // 
            // txtProcessId
            // 
            this.txtProcessId.Location = new System.Drawing.Point(9, 218);
            this.txtProcessId.Name = "txtProcessId";
            this.txtProcessId.Size = new System.Drawing.Size(132, 20);
            this.txtProcessId.TabIndex = 17;
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(9, 264);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(132, 20);
            this.txtProcessName.TabIndex = 16;
            // 
            // btnStopProcess
            // 
            this.btnStopProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopProcess.Location = new System.Drawing.Point(147, 218);
            this.btnStopProcess.Name = "btnStopProcess";
            this.btnStopProcess.Size = new System.Drawing.Size(78, 20);
            this.btnStopProcess.TabIndex = 15;
            this.btnStopProcess.Text = "Stop Process";
            this.btnStopProcess.UseVisualStyleBackColor = true;
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartProcess.Location = new System.Drawing.Point(147, 263);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(78, 21);
            this.btnStartProcess.TabIndex = 14;
            this.btnStartProcess.Text = "Start Process";
            this.btnStartProcess.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Processes";
            // 
            // lstProcesses
            // 
            this.lstProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstProcesses.HideSelection = false;
            this.lstProcesses.Location = new System.Drawing.Point(3, 21);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(315, 157);
            this.lstProcesses.TabIndex = 0;
            this.lstProcesses.UseCompatibleStateImageBehavior = false;
            this.lstProcesses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 250;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status :";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.Location = new System.Drawing.Point(403, 453);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(137, 24);
            this.lblConnectionStatus.TabIndex = 6;
            this.lblConnectionStatus.Text = "No Connection";
            // 
            // pFilesResults
            // 
            this.pFilesResults.Controls.Add(this.lstDirectoryContent);
            this.pFilesResults.Controls.Add(this.txtDirectory);
            this.pFilesResults.Controls.Add(this.label4);
            this.pFilesResults.Controls.Add(this.btnShowContent);
            this.pFilesResults.Location = new System.Drawing.Point(31, 12);
            this.pFilesResults.Name = "pFilesResults";
            this.pFilesResults.Size = new System.Drawing.Size(501, 213);
            this.pFilesResults.TabIndex = 4;
            // 
            // lstDirectoryContent
            // 
            this.lstDirectoryContent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lstDirectoryContent.HideSelection = false;
            this.lstDirectoryContent.Location = new System.Drawing.Point(0, 21);
            this.lstDirectoryContent.Name = "lstDirectoryContent";
            this.lstDirectoryContent.Size = new System.Drawing.Size(495, 156);
            this.lstDirectoryContent.TabIndex = 2;
            this.lstDirectoryContent.UseCompatibleStateImageBehavior = false;
            this.lstDirectoryContent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 300;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(3, 184);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(363, 20);
            this.txtDirectory.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Directory Content";
            // 
            // btnShowContent
            // 
            this.btnShowContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowContent.Location = new System.Drawing.Point(379, 183);
            this.btnShowContent.Name = "btnShowContent";
            this.btnShowContent.Size = new System.Drawing.Size(100, 21);
            this.btnShowContent.TabIndex = 5;
            this.btnShowContent.Text = "Show Content";
            this.btnShowContent.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(411, 59);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 7;
            // 
            // pMainControl
            // 
            this.pMainControl.Controls.Add(this.pFilesResults);
            this.pMainControl.Controls.Add(this.pCommands);
            this.pMainControl.Controls.Add(this.pProcesses);
            this.pMainControl.Location = new System.Drawing.Point(24, 80);
            this.pMainControl.Name = "pMainControl";
            this.pMainControl.Size = new System.Drawing.Size(902, 355);
            this.pMainControl.TabIndex = 8;
            // 
            // pConnection
            // 
            this.pConnection.Controls.Add(this.btnConnect);
            this.pConnection.Controls.Add(this.txtAddress);
            this.pConnection.Controls.Add(this.txtPort);
            this.pConnection.Controls.Add(this.label8);
            this.pConnection.Controls.Add(this.label9);
            this.pConnection.Controls.Add(this.label10);
            this.pConnection.Location = new System.Drawing.Point(298, 143);
            this.pConnection.Name = "pConnection";
            this.pConnection.Size = new System.Drawing.Size(277, 235);
            this.pConnection.TabIndex = 9;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(155, 187);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(42, 154);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(188, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(42, 99);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(188, 20);
            this.txtPort.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ip Address :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Port :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(97, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Connect";
            // 
            // pLogin
            // 
            this.pLogin.Controls.Add(this.label11);
            this.pLogin.Controls.Add(this.btnLogin);
            this.pLogin.Controls.Add(this.label12);
            this.pLogin.Controls.Add(this.txtPassword);
            this.pLogin.Controls.Add(this.label13);
            this.pLogin.Controls.Add(this.txtEmail);
            this.pLogin.Location = new System.Drawing.Point(280, 103);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(310, 310);
            this.pLogin.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(103, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 37);
            this.label11.TabIndex = 0;
            this.label11.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(184, 262);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(26, 199);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(26, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 487);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pConnection);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.pMainControl);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pCommands.ResumeLayout(false);
            this.pProcesses.ResumeLayout(false);
            this.pProcesses.PerformLayout();
            this.pFilesResults.ResumeLayout(false);
            this.pFilesResults.PerformLayout();
            this.pMainControl.ResumeLayout(false);
            this.pConnection.ResumeLayout(false);
            this.pConnection.PerformLayout();
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pCommands;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnProcesses;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Panel pProcesses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstProcesses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtProcessId;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Button btnStopProcess;
        private System.Windows.Forms.Button btnStartProcess;
        private System.Windows.Forms.Panel pFilesResults;
        private System.Windows.Forms.ListView lstDirectoryContent;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowContent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel pMainControl;
        private System.Windows.Forms.Panel pConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
    }
}


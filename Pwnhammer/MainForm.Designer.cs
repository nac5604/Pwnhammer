
namespace Pwnhammer
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.runChecksBtn = new System.Windows.Forms.Button();
            this.killProcsBtn = new System.Windows.Forms.Button();
            this.procList = new System.Windows.Forms.DataGridView();
            this.ConnectionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openTSBtn = new System.Windows.Forms.Button();
            this.openScBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.procList)).BeginInit();
            this.SuspendLayout();
            // 
            // runChecksBtn
            // 
            this.runChecksBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.runChecksBtn.Location = new System.Drawing.Point(12, 12);
            this.runChecksBtn.Name = "runChecksBtn";
            this.runChecksBtn.Size = new System.Drawing.Size(220, 35);
            this.runChecksBtn.TabIndex = 0;
            this.runChecksBtn.Text = "Run Checks";
            this.runChecksBtn.UseVisualStyleBackColor = true;
            this.runChecksBtn.Click += new System.EventHandler(this.Run_Checks_Button_Click);
            // 
            // killProcsBtn
            // 
            this.killProcsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.killProcsBtn.Location = new System.Drawing.Point(12, 53);
            this.killProcsBtn.Name = "killProcsBtn";
            this.killProcsBtn.Size = new System.Drawing.Size(220, 35);
            this.killProcsBtn.TabIndex = 2;
            this.killProcsBtn.Text = "Kill Conflicting Programs";
            this.killProcsBtn.UseVisualStyleBackColor = true;
            this.killProcsBtn.Click += new System.EventHandler(this.Kill_Conflicting_Programs_Button_Click);
            // 
            // procList
            // 
            this.procList.AllowUserToAddRows = false;
            this.procList.AllowUserToDeleteRows = false;
            this.procList.AllowUserToResizeRows = false;
            this.procList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.procList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.procList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.procList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConnectionType,
            this.IP,
            this.Port,
            this.DestinationIP,
            this.DestinationPort,
            this.ConnectionStatus,
            this.PID,
            this.ProcessName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "None";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.procList.DefaultCellStyle = dataGridViewCellStyle3;
            this.procList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.procList.Location = new System.Drawing.Point(238, 12);
            this.procList.MultiSelect = false;
            this.procList.Name = "procList";
            this.procList.ReadOnly = true;
            this.procList.RowHeadersWidth = 51;
            this.procList.RowTemplate.Height = 24;
            this.procList.ShowCellErrors = false;
            this.procList.ShowCellToolTips = false;
            this.procList.ShowEditingIcon = false;
            this.procList.ShowRowErrors = false;
            this.procList.Size = new System.Drawing.Size(760, 394);
            this.procList.TabIndex = 3;
            // 
            // ConnectionType
            // 
            this.ConnectionType.HeaderText = "Connection Type";
            this.ConnectionType.MinimumWidth = 6;
            this.ConnectionType.Name = "ConnectionType";
            this.ConnectionType.ReadOnly = true;
            this.ConnectionType.Width = 125;
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.MinimumWidth = 6;
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Width = 125;
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.MinimumWidth = 6;
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            this.Port.Width = 125;
            // 
            // DestinationIP
            // 
            this.DestinationIP.HeaderText = "Destination IP";
            this.DestinationIP.MinimumWidth = 6;
            this.DestinationIP.Name = "DestinationIP";
            this.DestinationIP.ReadOnly = true;
            this.DestinationIP.Width = 125;
            // 
            // DestinationPort
            // 
            this.DestinationPort.HeaderText = "Destination Port";
            this.DestinationPort.MinimumWidth = 6;
            this.DestinationPort.Name = "DestinationPort";
            this.DestinationPort.ReadOnly = true;
            this.DestinationPort.Width = 125;
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.HeaderText = "Connection Status";
            this.ConnectionStatus.MinimumWidth = 6;
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.ReadOnly = true;
            this.ConnectionStatus.Width = 125;
            // 
            // PID
            // 
            this.PID.HeaderText = "Process ID";
            this.PID.MinimumWidth = 6;
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Width = 125;
            // 
            // ProcessName
            // 
            this.ProcessName.HeaderText = "Process Name";
            this.ProcessName.MinimumWidth = 6;
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.Width = 250;
            // 
            // openTSBtn
            // 
            this.openTSBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openTSBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openTSBtn.Location = new System.Drawing.Point(12, 330);
            this.openTSBtn.Name = "openTSBtn";
            this.openTSBtn.Size = new System.Drawing.Size(220, 35);
            this.openTSBtn.TabIndex = 4;
            this.openTSBtn.Text = "Open TerrariaServer.exe";
            this.openTSBtn.UseVisualStyleBackColor = true;
            this.openTSBtn.Click += new System.EventHandler(this.Open_Terraria_Server_Button_Click);
            // 
            // openScBtn
            // 
            this.openScBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openScBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openScBtn.Location = new System.Drawing.Point(12, 371);
            this.openScBtn.Name = "openScBtn";
            this.openScBtn.Size = new System.Drawing.Size(220, 35);
            this.openScBtn.TabIndex = 5;
            this.openScBtn.Text = "Open Services";
            this.openScBtn.UseVisualStyleBackColor = true;
            this.openScBtn.Click += new System.EventHandler(this.Open_Services_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 418);
            this.Controls.Add(this.openScBtn);
            this.Controls.Add(this.openTSBtn);
            this.Controls.Add(this.procList);
            this.Controls.Add(this.killProcsBtn);
            this.Controls.Add(this.runChecksBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TFix | a | v";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.procList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runChecksBtn;
        private System.Windows.Forms.Button killProcsBtn;
        private System.Windows.Forms.DataGridView procList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.Button openTSBtn;
        private System.Windows.Forms.Button openScBtn;
    }
}


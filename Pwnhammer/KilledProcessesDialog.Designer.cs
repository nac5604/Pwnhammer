
namespace Pwnhammer
{
    partial class KilledProcessesDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.procList = new System.Windows.Forms.DataGridView();
            this.ConnectionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hammerIcon = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.procList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hammerIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "None";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.procList.DefaultCellStyle = dataGridViewCellStyle1;
            this.procList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.procList.Location = new System.Drawing.Point(6, 27);
            this.procList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.procList.MultiSelect = false;
            this.procList.Name = "procList";
            this.procList.ReadOnly = true;
            this.procList.RowHeadersWidth = 51;
            this.procList.RowTemplate.Height = 24;
            this.procList.ShowCellErrors = false;
            this.procList.ShowCellToolTips = false;
            this.procList.ShowEditingIcon = false;
            this.procList.ShowRowErrors = false;
            this.procList.Size = new System.Drawing.Size(699, 218);
            this.procList.TabIndex = 4;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.procList);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 252);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Killed Processes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "PwnHammer killed {n} conflicting processes.";
            // 
            // hammerIcon
            // 
            this.hammerIcon.Image = global::Pwnhammer.Properties.Resources.Demon_Altar__28old_29;
            this.hammerIcon.Location = new System.Drawing.Point(18, 12);
            this.hammerIcon.Name = "hammerIcon";
            this.hammerIcon.Size = new System.Drawing.Size(64, 64);
            this.hammerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hammerIcon.TabIndex = 7;
            this.hammerIcon.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-26, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 70);
            this.panel1.TabIndex = 10;
            // 
            // KilledProcessesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 410);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hammerIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KilledProcessesDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Killed Processes";
            this.Load += new System.EventHandler(this.KilledProcessesDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.procList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hammerIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView procList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox hammerIcon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}
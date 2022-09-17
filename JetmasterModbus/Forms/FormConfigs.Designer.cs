namespace JetmasterModbus.Forms
{
    partial class FormConfigs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigs));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbxPorts = new System.Windows.Forms.ComboBox();
            this.lblBaudrate = new System.Windows.Forms.Label();
            this.cbxBaudrate = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tlpPortInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSlaveId = new System.Windows.Forms.Label();
            this.cbxSlaveId = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tlpPortInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "StopBits :";
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Location = new System.Drawing.Point(130, 133);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(121, 21);
            this.cbxStopBits.TabIndex = 7;
            // 
            // lblParity
            // 
            this.lblParity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(83, 104);
            this.lblParity.Margin = new System.Windows.Forms.Padding(3, 8, 5, 0);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(39, 13);
            this.lblParity.TabIndex = 4;
            this.lblParity.Text = "Parity :";
            // 
            // cbxParity
            // 
            this.cbxParity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Location = new System.Drawing.Point(130, 101);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(121, 21);
            this.cbxParity.TabIndex = 6;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(145, 262);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(127, 39);
            this.btnDisconnect.TabIndex = 24;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(15, 262);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(127, 39);
            this.btnConnect.TabIndex = 23;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbxPorts
            // 
            this.cbxPorts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPorts.FormattingEnabled = true;
            this.cbxPorts.Location = new System.Drawing.Point(130, 37);
            this.cbxPorts.Name = "cbxPorts";
            this.cbxPorts.Size = new System.Drawing.Size(121, 21);
            this.cbxPorts.TabIndex = 2;
            // 
            // lblBaudrate
            // 
            this.lblBaudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBaudrate.AutoSize = true;
            this.lblBaudrate.Location = new System.Drawing.Point(66, 72);
            this.lblBaudrate.Margin = new System.Windows.Forms.Padding(3, 8, 5, 0);
            this.lblBaudrate.Name = "lblBaudrate";
            this.lblBaudrate.Size = new System.Drawing.Size(56, 13);
            this.lblBaudrate.TabIndex = 1;
            this.lblBaudrate.Text = "Baudrate :";
            // 
            // cbxBaudrate
            // 
            this.cbxBaudrate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxBaudrate.FormattingEnabled = true;
            this.cbxBaudrate.Location = new System.Drawing.Point(130, 69);
            this.cbxBaudrate.Name = "cbxBaudrate";
            this.cbxBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cbxBaudrate.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(90, 40);
            this.lblPort.Margin = new System.Windows.Forms.Padding(3, 8, 5, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPort.Size = new System.Drawing.Size(32, 13);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tlpPortInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 244);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Info";
            // 
            // tlpPortInfo
            // 
            this.tlpPortInfo.ColumnCount = 2;
            this.tlpPortInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPortInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPortInfo.Controls.Add(this.tbxName, 1, 0);
            this.tlpPortInfo.Controls.Add(this.cbxDataBits, 1, 5);
            this.tlpPortInfo.Controls.Add(this.label1, 0, 4);
            this.tlpPortInfo.Controls.Add(this.cbxStopBits, 1, 4);
            this.tlpPortInfo.Controls.Add(this.lblParity, 0, 3);
            this.tlpPortInfo.Controls.Add(this.cbxPorts, 1, 1);
            this.tlpPortInfo.Controls.Add(this.lblBaudrate, 0, 2);
            this.tlpPortInfo.Controls.Add(this.cbxParity, 1, 3);
            this.tlpPortInfo.Controls.Add(this.cbxBaudrate, 1, 2);
            this.tlpPortInfo.Controls.Add(this.lblDataBits, 0, 5);
            this.tlpPortInfo.Controls.Add(this.lblPort, 0, 1);
            this.tlpPortInfo.Controls.Add(this.lblName, 0, 0);
            this.tlpPortInfo.Controls.Add(this.cbxSlaveId, 1, 6);
            this.tlpPortInfo.Controls.Add(this.lblSlaveId, 0, 6);
            this.tlpPortInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPortInfo.Location = new System.Drawing.Point(3, 16);
            this.tlpPortInfo.Name = "tlpPortInfo";
            this.tlpPortInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlpPortInfo.RowCount = 7;
            this.tlpPortInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tlpPortInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tlpPortInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tlpPortInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tlpPortInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tlpPortInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tlpPortInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tlpPortInfo.Size = new System.Drawing.Size(254, 225);
            this.tlpPortInfo.TabIndex = 0;
            // 
            // tbxName
            // 
            this.tbxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxName.Location = new System.Drawing.Point(130, 6);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(121, 20);
            this.tbxName.TabIndex = 12;
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Location = new System.Drawing.Point(130, 165);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(121, 21);
            this.cbxDataBits.TabIndex = 9;
            // 
            // lblDataBits
            // 
            this.lblDataBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(69, 168);
            this.lblDataBits.Margin = new System.Windows.Forms.Padding(3, 8, 5, 0);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(53, 13);
            this.lblDataBits.TabIndex = 8;
            this.lblDataBits.Text = "DataBits :";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(81, 8);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 8, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name :";
            // 
            // lblSlaveId
            // 
            this.lblSlaveId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSlaveId.AutoSize = true;
            this.lblSlaveId.Location = new System.Drawing.Point(70, 200);
            this.lblSlaveId.Margin = new System.Windows.Forms.Padding(3, 8, 5, 0);
            this.lblSlaveId.Name = "lblSlaveId";
            this.lblSlaveId.Size = new System.Drawing.Size(52, 13);
            this.lblSlaveId.TabIndex = 13;
            this.lblSlaveId.Text = "Slave Id :";
            // 
            // cbxSlaveId
            // 
            this.cbxSlaveId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSlaveId.FormattingEnabled = true;
            this.cbxSlaveId.Location = new System.Drawing.Point(130, 198);
            this.cbxSlaveId.Name = "cbxSlaveId";
            this.cbxSlaveId.Size = new System.Drawing.Size(121, 21);
            this.cbxSlaveId.TabIndex = 14;
            // 
            // FormConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 308);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfigs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfigs";
            this.Load += new System.EventHandler(this.FormConfigs_Load);
            this.groupBox1.ResumeLayout(false);
            this.tlpPortInfo.ResumeLayout(false);
            this.tlpPortInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbxPorts;
        private System.Windows.Forms.Label lblBaudrate;
        private System.Windows.Forms.ComboBox cbxBaudrate;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tlpPortInfo;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbxSlaveId;
        private System.Windows.Forms.Label lblSlaveId;
    }
}
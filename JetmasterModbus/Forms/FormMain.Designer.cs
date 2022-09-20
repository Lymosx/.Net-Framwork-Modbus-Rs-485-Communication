namespace JetmasterModbus
{
    partial class FormMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lbxErrorLogger = new System.Windows.Forms.ListBox();
            this.flpDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tlpDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabErrorLog = new System.Windows.Forms.TabPage();
            this.panelHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblJetMaster = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxLogger = new System.Windows.Forms.ListBox();
            this.gbxLogger = new System.Windows.Forms.GroupBox();
            this.panelFlutter = new System.Windows.Forms.Panel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tabHome.SuspendLayout();
            this.tlpDisplay.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabErrorLog.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.gbxLogger.SuspendLayout();
            this.panelFlutter.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxErrorLogger
            // 
            this.lbxErrorLogger.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbxErrorLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxErrorLogger.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxErrorLogger.ForeColor = System.Drawing.Color.Lime;
            this.lbxErrorLogger.FormattingEnabled = true;
            this.lbxErrorLogger.ItemHeight = 19;
            this.lbxErrorLogger.Location = new System.Drawing.Point(2, 3);
            this.lbxErrorLogger.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbxErrorLogger.Name = "lbxErrorLogger";
            this.lbxErrorLogger.Size = new System.Drawing.Size(1268, 460);
            this.lbxErrorLogger.TabIndex = 2;
            // 
            // flpDisplay
            // 
            this.flpDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flpDisplay.AutoSize = true;
            this.flpDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpDisplay.BackColor = System.Drawing.Color.Snow;
            this.flpDisplay.Location = new System.Drawing.Point(630, 3);
            this.flpDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpDisplay.Name = "flpDisplay";
            this.flpDisplay.Size = new System.Drawing.Size(0, 0);
            this.flpDisplay.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(6, 425);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Display Test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.button1);
            this.tabHome.Controls.Add(this.tlpDisplay);
            this.tabHome.Location = new System.Drawing.Point(4, 28);
            this.tabHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabHome.Size = new System.Drawing.Size(1272, 466);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tlpDisplay
            // 
            this.tlpDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDisplay.BackColor = System.Drawing.Color.DarkGray;
            this.tlpDisplay.ColumnCount = 1;
            this.tlpDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDisplay.Controls.Add(this.flpDisplay, 0, 0);
            this.tlpDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tlpDisplay.ForeColor = System.Drawing.Color.Black;
            this.tlpDisplay.Location = new System.Drawing.Point(6, 54);
            this.tlpDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tlpDisplay.Name = "tlpDisplay";
            this.tlpDisplay.RowCount = 1;
            this.tlpDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpDisplay.Size = new System.Drawing.Size(1261, 300);
            this.tlpDisplay.TabIndex = 14;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabHome);
            this.tabMain.Controls.Add(this.tabErrorLog);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabMain.Location = new System.Drawing.Point(0, 55);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1280, 498);
            this.tabMain.TabIndex = 18;
            // 
            // tabErrorLog
            // 
            this.tabErrorLog.Controls.Add(this.lbxErrorLogger);
            this.tabErrorLog.Location = new System.Drawing.Point(4, 28);
            this.tabErrorLog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabErrorLog.Name = "tabErrorLog";
            this.tabErrorLog.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabErrorLog.Size = new System.Drawing.Size(1272, 466);
            this.tabErrorLog.TabIndex = 1;
            this.tabErrorLog.Text = "Error Log";
            this.tabErrorLog.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            this.panelHeader.AutoSize = true;
            this.panelHeader.BackColor = System.Drawing.Color.OliveDrab;
            this.panelHeader.ColumnCount = 6;
            this.panelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.panelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.panelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelHeader.Controls.Add(this.lblJetMaster, 2, 0);
            this.panelHeader.Controls.Add(this.btnMin, 3, 0);
            this.panelHeader.Controls.Add(this.btnMax, 4, 0);
            this.panelHeader.Controls.Add(this.btnExit, 5, 0);
            this.panelHeader.Controls.Add(this.lblTitle, 0, 0);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.RowCount = 1;
            this.panelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelHeader.Size = new System.Drawing.Size(1280, 28);
            this.panelHeader.TabIndex = 17;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // lblJetMaster
            // 
            this.lblJetMaster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJetMaster.AutoSize = true;
            this.lblJetMaster.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblJetMaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblJetMaster.Location = new System.Drawing.Point(1060, 6);
            this.lblJetMaster.Margin = new System.Windows.Forms.Padding(2, 5, 8, 4);
            this.lblJetMaster.Name = "lblJetMaster";
            this.lblJetMaster.Size = new System.Drawing.Size(120, 17);
            this.lblJetMaster.TabIndex = 6;
            this.lblJetMaster.Text = "www.jetmaster.com";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMin.AutoSize = true;
            this.btnMin.BackColor = System.Drawing.Color.Black;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1194, 3);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 22);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMax.AutoSize = true;
            this.btnMax.BackColor = System.Drawing.Color.Black;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1224, 3);
            this.btnMax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(22, 22);
            this.btnMax.TabIndex = 5;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ForeColor = System.Drawing.Color.Brown;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1254, 3);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 22);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitle.Location = new System.Drawing.Point(6, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 5, 8, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(64, 17);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Jetmaster";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // lbxLogger
            // 
            this.lbxLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxLogger.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxLogger.FormattingEnabled = true;
            this.lbxLogger.ItemHeight = 17;
            this.lbxLogger.Location = new System.Drawing.Point(3, 16);
            this.lbxLogger.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbxLogger.Name = "lbxLogger";
            this.lbxLogger.Size = new System.Drawing.Size(1274, 148);
            this.lbxLogger.TabIndex = 1;
            // 
            // gbxLogger
            // 
            this.gbxLogger.Controls.Add(this.lbxLogger);
            this.gbxLogger.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxLogger.Location = new System.Drawing.Point(0, 0);
            this.gbxLogger.Name = "gbxLogger";
            this.gbxLogger.Size = new System.Drawing.Size(1280, 167);
            this.gbxLogger.TabIndex = 0;
            this.gbxLogger.TabStop = false;
            this.gbxLogger.Text = "Application Logger";
            // 
            // panelFlutter
            // 
            this.panelFlutter.BackColor = System.Drawing.Color.Silver;
            this.panelFlutter.Controls.Add(this.gbxLogger);
            this.panelFlutter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFlutter.Location = new System.Drawing.Point(0, 553);
            this.panelFlutter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelFlutter.Name = "panelFlutter";
            this.panelFlutter.Size = new System.Drawing.Size(1280, 167);
            this.panelFlutter.TabIndex = 15;
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 28);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMain.Size = new System.Drawing.Size(1280, 27);
            this.msMain.TabIndex = 16;
            this.msMain.Text = "menuStrip";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.panelFlutter);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jetmaster";
            this.tabHome.ResumeLayout(false);
            this.tlpDisplay.ResumeLayout(false);
            this.tlpDisplay.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabErrorLog.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.gbxLogger.ResumeLayout(false);
            this.panelFlutter.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxErrorLogger;
        private System.Windows.Forms.FlowLayoutPanel flpDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TableLayoutPanel tlpDisplay;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabErrorLog;
        private System.Windows.Forms.TableLayoutPanel panelHeader;
        private System.Windows.Forms.Label lblJetMaster;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ListBox lbxLogger;
        private System.Windows.Forms.GroupBox gbxLogger;
        private System.Windows.Forms.Panel panelFlutter;
        private System.Windows.Forms.MenuStrip msMain;
    }
}


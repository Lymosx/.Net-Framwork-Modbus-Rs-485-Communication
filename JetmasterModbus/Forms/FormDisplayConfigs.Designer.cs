namespace JetmasterModbus.Forms
{
    partial class FormDisplayConfigs
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
            this.gbxDisplaySettings = new System.Windows.Forms.GroupBox();
            this.tlpDisplaySettings = new System.Windows.Forms.TableLayoutPanel();
            this.cbxSecondDisplay = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFirstDisplay = new System.Windows.Forms.ComboBox();
            this.lblDisplayOne = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.gbxReadandWrite = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblConfigsWrite = new System.Windows.Forms.Label();
            this.lblConfigsRead = new System.Windows.Forms.Label();
            this.cbxConfig1 = new System.Windows.Forms.ComboBox();
            this.lblConfig = new System.Windows.Forms.Label();
            this.tbxConfig1 = new System.Windows.Forms.TextBox();
            this.btnConfgisApply = new System.Windows.Forms.Button();
            this.displayControl1 = new JetmasterModbus.BaseClient.DisplayControl();
            this.gbxDisplaySettings.SuspendLayout();
            this.tlpDisplaySettings.SuspendLayout();
            this.gbxReadandWrite.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDisplaySettings
            // 
            this.gbxDisplaySettings.Controls.Add(this.tlpDisplaySettings);
            this.gbxDisplaySettings.Location = new System.Drawing.Point(13, 13);
            this.gbxDisplaySettings.Margin = new System.Windows.Forms.Padding(4);
            this.gbxDisplaySettings.Name = "gbxDisplaySettings";
            this.gbxDisplaySettings.Padding = new System.Windows.Forms.Padding(4);
            this.gbxDisplaySettings.Size = new System.Drawing.Size(410, 184);
            this.gbxDisplaySettings.TabIndex = 1;
            this.gbxDisplaySettings.TabStop = false;
            this.gbxDisplaySettings.Text = "Display Settings";
            // 
            // tlpDisplaySettings
            // 
            this.tlpDisplaySettings.ColumnCount = 2;
            this.tlpDisplaySettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.88372F));
            this.tlpDisplaySettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.11628F));
            this.tlpDisplaySettings.Controls.Add(this.cbxSecondDisplay, 1, 2);
            this.tlpDisplaySettings.Controls.Add(this.lblTitle, 0, 0);
            this.tlpDisplaySettings.Controls.Add(this.tbxTitle, 1, 0);
            this.tlpDisplaySettings.Controls.Add(this.label2, 0, 2);
            this.tlpDisplaySettings.Controls.Add(this.cbxFirstDisplay, 1, 1);
            this.tlpDisplaySettings.Controls.Add(this.lblDisplayOne, 0, 1);
            this.tlpDisplaySettings.Controls.Add(this.btnApply, 1, 3);
            this.tlpDisplaySettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDisplaySettings.Location = new System.Drawing.Point(4, 17);
            this.tlpDisplaySettings.Margin = new System.Windows.Forms.Padding(4);
            this.tlpDisplaySettings.Name = "tlpDisplaySettings";
            this.tlpDisplaySettings.RowCount = 5;
            this.tlpDisplaySettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpDisplaySettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpDisplaySettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpDisplaySettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpDisplaySettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisplaySettings.Size = new System.Drawing.Size(402, 163);
            this.tlpDisplaySettings.TabIndex = 0;
            // 
            // cbxSecondDisplay
            // 
            this.cbxSecondDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSecondDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSecondDisplay.FormattingEnabled = true;
            this.cbxSecondDisplay.Location = new System.Drawing.Point(158, 76);
            this.cbxSecondDisplay.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.cbxSecondDisplay.Name = "cbxSecondDisplay";
            this.cbxSecondDisplay.Size = new System.Drawing.Size(226, 21);
            this.cbxSecondDisplay.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(102, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 8, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Title :";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxTitle.Location = new System.Drawing.Point(158, 8);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(226, 20);
            this.tbxTitle.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 5, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "2. Display Ekranı :";
            // 
            // cbxFirstDisplay
            // 
            this.cbxFirstDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxFirstDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFirstDisplay.FormattingEnabled = true;
            this.cbxFirstDisplay.Location = new System.Drawing.Point(158, 41);
            this.cbxFirstDisplay.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.cbxFirstDisplay.Name = "cbxFirstDisplay";
            this.cbxFirstDisplay.Size = new System.Drawing.Size(226, 21);
            this.cbxFirstDisplay.TabIndex = 17;
            // 
            // lblDisplayOne
            // 
            this.lblDisplayOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayOne.AutoSize = true;
            this.lblDisplayOne.Location = new System.Drawing.Point(43, 43);
            this.lblDisplayOne.Margin = new System.Windows.Forms.Padding(3, 8, 5, 0);
            this.lblDisplayOne.Name = "lblDisplayOne";
            this.lblDisplayOne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDisplayOne.Size = new System.Drawing.Size(92, 13);
            this.lblDisplayOne.TabIndex = 15;
            this.lblDisplayOne.Text = "1. Display Ekranı :";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApply.Location = new System.Drawing.Point(221, 108);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(99, 29);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // gbxReadandWrite
            // 
            this.gbxReadandWrite.Controls.Add(this.tableLayoutPanel1);
            this.gbxReadandWrite.Location = new System.Drawing.Point(431, 13);
            this.gbxReadandWrite.Name = "gbxReadandWrite";
            this.gbxReadandWrite.Size = new System.Drawing.Size(412, 184);
            this.gbxReadandWrite.TabIndex = 2;
            this.gbxReadandWrite.TabStop = false;
            this.gbxReadandWrite.Text = "Read and Write";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.Controls.Add(this.lblConfigsWrite, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblConfigsRead, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxConfig1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblConfig, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxConfig1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConfgisApply, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.displayControl1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 165);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblConfigsWrite
            // 
            this.lblConfigsWrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfigsWrite.AutoSize = true;
            this.lblConfigsWrite.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConfigsWrite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfigsWrite.Location = new System.Drawing.Point(331, 5);
            this.lblConfigsWrite.Name = "lblConfigsWrite";
            this.lblConfigsWrite.Size = new System.Drawing.Size(57, 25);
            this.lblConfigsWrite.TabIndex = 18;
            this.lblConfigsWrite.Text = "Write";
            // 
            // lblConfigsRead
            // 
            this.lblConfigsRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfigsRead.AutoSize = true;
            this.lblConfigsRead.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConfigsRead.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfigsRead.Location = new System.Drawing.Point(241, 5);
            this.lblConfigsRead.Name = "lblConfigsRead";
            this.lblConfigsRead.Size = new System.Drawing.Size(55, 25);
            this.lblConfigsRead.TabIndex = 17;
            this.lblConfigsRead.Text = "Read";
            // 
            // cbxConfig1
            // 
            this.cbxConfig1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxConfig1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConfig1.FormattingEnabled = true;
            this.cbxConfig1.Location = new System.Drawing.Point(3, 40);
            this.cbxConfig1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 6);
            this.cbxConfig1.Name = "cbxConfig1";
            this.cbxConfig1.Size = new System.Drawing.Size(217, 21);
            this.cbxConfig1.TabIndex = 0;
            this.cbxConfig1.SelectedIndexChanged += new System.EventHandler(this.cbxConfig1_SelectedIndexChanged);
            // 
            // lblConfig
            // 
            this.lblConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfig.AutoSize = true;
            this.lblConfig.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfig.Location = new System.Drawing.Point(72, 5);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(78, 25);
            this.lblConfig.TabIndex = 13;
            this.lblConfig.Text = "Configs";
            // 
            // tbxConfig1
            // 
            this.tbxConfig1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxConfig1.Location = new System.Drawing.Point(317, 42);
            this.tbxConfig1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tbxConfig1.Name = "tbxConfig1";
            this.tbxConfig1.Size = new System.Drawing.Size(86, 20);
            this.tbxConfig1.TabIndex = 15;
            // 
            // btnConfgisApply
            // 
            this.btnConfgisApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfgisApply.Location = new System.Drawing.Point(317, 71);
            this.btnConfgisApply.Name = "btnConfgisApply";
            this.btnConfgisApply.Size = new System.Drawing.Size(86, 29);
            this.btnConfgisApply.TabIndex = 16;
            this.btnConfgisApply.Text = "Apply";
            this.btnConfgisApply.UseVisualStyleBackColor = true;
            this.btnConfgisApply.Click += new System.EventHandler(this.btnConfgisApply_Click);
            // 
            // displayControl1
            // 
            this.displayControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayControl1.BackColor = System.Drawing.Color.Black;
            this.displayControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.displayControl1.ForeColor = System.Drawing.Color.Lime;
            this.displayControl1.Location = new System.Drawing.Point(226, 40);
            this.displayControl1.Name = "displayControl1";
            this.displayControl1.Register = null;
            this.displayControl1.Size = new System.Drawing.Size(85, 22);
            this.displayControl1.TabIndex = 19;
            this.displayControl1.Text = "0";
            this.displayControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDisplayConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 204);
            this.Controls.Add(this.gbxReadandWrite);
            this.Controls.Add(this.gbxDisplaySettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDisplayConfigs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDisplayConfigs";
            this.Load += new System.EventHandler(this.FormDisplayConfigs_Load);
            this.gbxDisplaySettings.ResumeLayout(false);
            this.tlpDisplaySettings.ResumeLayout(false);
            this.tlpDisplaySettings.PerformLayout();
            this.gbxReadandWrite.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDisplaySettings;
        private System.Windows.Forms.TableLayoutPanel tlpDisplaySettings;
        private System.Windows.Forms.ComboBox cbxSecondDisplay;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFirstDisplay;
        private System.Windows.Forms.Label lblDisplayOne;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox gbxReadandWrite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblConfigsWrite;
        private System.Windows.Forms.Label lblConfigsRead;
        private System.Windows.Forms.ComboBox cbxConfig1;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.TextBox tbxConfig1;
        private System.Windows.Forms.Button btnConfgisApply;
        private BaseClient.DisplayControl displayControl1;
    }
}
namespace JetmasterModbus.Forms
{
    partial class FormDisplay
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
            this.btnConfig = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPortName = new System.Windows.Forms.Label();
            this.dcSecondValue = new JetmasterModbus.BaseClient.DisplayControl();
            this.dcFirstValue = new JetmasterModbus.BaseClient.DisplayControl();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfig.Location = new System.Drawing.Point(14, 194);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(137, 43);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panelMain
            // 
            this.panelMain.ColumnCount = 1;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Controls.Add(this.dcSecondValue, 0, 3);
            this.panelMain.Controls.Add(this.btnExit, 0, 5);
            this.panelMain.Controls.Add(this.btnConfig, 0, 4);
            this.panelMain.Controls.Add(this.lblDesc, 0, 1);
            this.panelMain.Controls.Add(this.lblPortName, 0, 0);
            this.panelMain.Controls.Add(this.dcFirstValue, 0, 2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 6;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelMain.Size = new System.Drawing.Size(166, 291);
            this.panelMain.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(14, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 43);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(53, 34);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Description";
            // 
            // lblPortName
            // 
            this.lblPortName.AutoSize = true;
            this.lblPortName.Location = new System.Drawing.Point(3, 3);
            this.lblPortName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(32, 13);
            this.lblPortName.TabIndex = 9;
            this.lblPortName.Text = "Port :";
            // 
            // dcSecondValue
            // 
            this.dcSecondValue.BackColor = System.Drawing.Color.Black;
            this.dcSecondValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dcSecondValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcSecondValue.ForeColor = System.Drawing.Color.Lime;
            this.dcSecondValue.Location = new System.Drawing.Point(3, 126);
            this.dcSecondValue.Name = "dcSecondValue";
            this.dcSecondValue.Register = null;
            this.dcSecondValue.Size = new System.Drawing.Size(160, 53);
            this.dcSecondValue.TabIndex = 11;
            this.dcSecondValue.Text = "0";
            this.dcSecondValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dcFirstValue
            // 
            this.dcFirstValue.BackColor = System.Drawing.Color.Black;
            this.dcFirstValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dcFirstValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcFirstValue.ForeColor = System.Drawing.Color.Lime;
            this.dcFirstValue.Location = new System.Drawing.Point(3, 61);
            this.dcFirstValue.Name = "dcFirstValue";
            this.dcFirstValue.Register = null;
            this.dcFirstValue.Size = new System.Drawing.Size(160, 53);
            this.dcFirstValue.TabIndex = 10;
            this.dcFirstValue.Text = "0";
            this.dcFirstValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 291);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDisplay";
            this.Text = "FormDisplay";
            this.Load += new System.EventHandler(this.FormDisplay_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.TableLayoutPanel panelMain;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPortName;
        public BaseClient.DisplayControl dcSecondValue;
        public BaseClient.DisplayControl dcFirstValue;
    }
}
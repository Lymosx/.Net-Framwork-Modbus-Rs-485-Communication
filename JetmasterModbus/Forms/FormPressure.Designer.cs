namespace JetmasterModbus.Forms
{
    partial class FormPressure
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
            this.grapPressure = new MindFusion.Charting.WinForms.LineChart();
            this.SuspendLayout();
            // 
            // grapPressure
            // 
            this.grapPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grapPressure.LegendTitle = "Jetmaster";
            this.grapPressure.Location = new System.Drawing.Point(0, 0);
            this.grapPressure.Name = "grapPressure";
            this.grapPressure.Padding = new System.Windows.Forms.Padding(5);
            this.grapPressure.ShowLegend = true;
            this.grapPressure.Size = new System.Drawing.Size(1272, 466);
            this.grapPressure.SubtitleFontName = null;
            this.grapPressure.SubtitleFontSize = null;
            this.grapPressure.SubtitleFontStyle = null;
            this.grapPressure.TabIndex = 0;
            this.grapPressure.Text = "Jetmaster Pressure";
            this.grapPressure.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
            this.grapPressure.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.grapPressure.Theme.UniformSeriesStrokeThickness = 2D;
            this.grapPressure.TitleFontName = null;
            this.grapPressure.TitleFontSize = null;
            this.grapPressure.TitleFontStyle = null;
            // 
            // FormPressure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 466);
            this.Controls.Add(this.grapPressure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPressure";
            this.Text = "FormPressure";
            this.Load += new System.EventHandler(this.FormPressure_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MindFusion.Charting.WinForms.LineChart grapPressure;
    }
}
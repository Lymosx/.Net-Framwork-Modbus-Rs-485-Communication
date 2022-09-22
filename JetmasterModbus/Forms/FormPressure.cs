using JetmasterModbus.Methods;
using MindFusion.Charting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

using Timer = System.Windows.Forms.Timer;
using Brush = MindFusion.Drawing.Brush;
using SolidBrush = MindFusion.Drawing.SolidBrush;

namespace JetmasterModbus.Forms
{
    public partial class FormPressure : Form
    {
        public FormPressure()
        {
            InitializeComponent();
            

            CheckForIllegalCrossThreadCalls = false;
        }

        Timer myTimer = new Timer();
        Random random = new Random();
        JetmasterDateTimeSeries series1;

        private void FormPressure_Load(object sender, EventArgs e)
        {
            ObservableCollection<Series> data = new ObservableCollection<Series>();
            grapPressure.LicenseKey = "license key stays here";

            series1 = new JetmasterDateTimeSeries(DateTime.Now, DateTime.Now, DateTime.Now.AddMinutes(1));
            series1.DateTimeFormat = DateTimeFormat.LongTime;
            series1.LabelInterval = 500;
            series1.MinValue = 0;
            series1.MaxValue = 120;
            series1.Title = "Jetmaster";
            series1.SupportedLabels = LabelKinds.XAxisLabel;

            grapPressure.Series.Add(series1);
            grapPressure.Title = "Pressure Display";
            grapPressure.ShowXCoordinates = false;
            grapPressure.ShowLegendTitle = false;
            grapPressure.LayoutPanel.Margin = new Margins(0, 0, 20, 0);

            grapPressure.XAxis.Title = "";
            grapPressure.XAxis.MinValue = 0;
            grapPressure.XAxis.MaxValue = 120;
            grapPressure.XAxis.Interval = 10;

            grapPressure.YAxis.MinValue = 0;
            grapPressure.YAxis.MaxValue = 500;
            grapPressure.YAxis.Interval = 50;
            grapPressure.YAxis.Title = "Current Requests\n(in thousands)";

            List<Brush> brushes = new List<Brush>()
            {
                new SolidBrush(Color.Red),
                new SolidBrush(Color.Orange),
                new SolidBrush(Color.SeaGreen)
            };

            List<double> thicknesses = new List<double>() { 2 };

            PerSeriesStyle style = new PerSeriesStyle(brushes, brushes, thicknesses, null);
            grapPressure.Plot.SeriesStyle = style;
            grapPressure.Theme.PlotBackground = new SolidBrush(Color.White);
            grapPressure.Theme.GridLineColor = Color.LightGray;
            grapPressure.Theme.GridLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            grapPressure.TitleMargin = new Margins(10);
            grapPressure.GridType = GridType.Horizontal;

            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to half a seconds.
            myTimer.Interval = 1;
            myTimer.Start();
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            if (FormMain.formPressureDisplaysControl.Count == 0)
            {
                return;
            }
            else
            {
                if (FormMain.formPressureDisplaysControl[0].Registers.Count > 54)
                {
                    double val = FormMain.formPressureDisplaysControl[0].Registers[11].Value;
                    series1.addValue(val);

                    if (series1.Size > 1)
                    {
                        double currVal = series1.GetValue(series1.Size - 1, 0);

                        if (currVal > grapPressure.XAxis.MaxValue)
                        {
                            double span = currVal - series1.GetValue(series1.Size - 2, 0);
                            grapPressure.XAxis.MinValue += span;
                            grapPressure.XAxis.MaxValue += span;

                        }
                        grapPressure.ChartPanel.InvalidateLayout();
                    }
                }
            }
        }
    }
}

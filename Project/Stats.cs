using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project
{
    public partial class Stats : UserControl
    {
        public Stats()
        {
            StatsEngine.loadDiagnosisArray();
            InitializeComponent();
          



            chart1.Series[0].Points.DataBindXY(StatsEngine.getDiagnosisNames(), StatsEngine.getStatsArrayChart1());
            chart1.ChartAreas[0].BackColor = SystemColors.Control;

            chart2.Series[0].Points.DataBindXY(StatsEngine.getDiagnosisNames(), StatsEngine.getStatsArrayChart2());

            chart3.Series[0].Points.DataBindXY(StatsEngine.getDiagnosisNames(), StatsEngine.getStatsArrayChart3());
            chart3.ChartAreas[0].BackColor = SystemColors.Control;



            chart2.ChartAreas[0].BackColor = SystemColors.Control;

            foreach (DataPoint dp in chart2.Series[0].Points)
            {
                dp.IsEmpty = (dp.YValues[0] == 0) ? true : false;
            }

            chart3.Series[0].Color = Color.Pink;

            chart1.Series[0].Color = Color.Red;



            Patients.OkClicked += updateChart;
        }


        public void updateChart(object s, EventArgs e)

        {

            chart1.Series[0].Points.DataBindXY(StatsEngine.getDiagnosisNames(), StatsEngine.getStatsArrayChart1());
            chart2.Series[0].Points.DataBindXY(StatsEngine.getDiagnosisNames(), StatsEngine.getStatsArrayChart2());
            chart3.Series[0].Points.DataBindXY(StatsEngine.getDiagnosisNames(), StatsEngine.getStatsArrayChart3());
            foreach (DataPoint dp in chart2.Series[0].Points) { 
                     dp.IsEmpty = (dp.YValues[0] == 0) ? true : false; }

            foreach (DataPoint p in chart2.Series[0].Points)
            {
                p.Label = "#PERCENT\n#VALX";
            }

            



        }


    }
}

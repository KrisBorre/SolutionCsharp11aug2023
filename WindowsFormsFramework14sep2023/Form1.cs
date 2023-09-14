using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsFramework14sep2023
{
    public partial class Form1 : Form
    {
        private Chart chart;

        public Form1()
        {
            InitializeComponent();

            Text = "Histogram van normaal verdeling";

            // Add Reference -> Assemblies -> Framework -> System.Windows.Forms.DataVisualization

            ChartArea chartArea = new ChartArea();
            Series series = new Series();
            chart = new Chart();

            chartArea.Name = "ChartArea";
            chart.ChartAreas.Add(chartArea);
            chart.Location = new Point(66, 35);
            chart.Name = "chart";
            series.ChartArea = "ChartArea";
            series.ChartType = SeriesChartType.RangeColumn;
            //series2.ChartType = SeriesChartType.Point;
            //series.Legend = "legend";
            series.Name = "series";

            double variantie_breed = 10.0;

            const int NPTS = 200000;
            const int N = 20; // Er worden 21 histogrambalken getoond.

            const int NOVER2 = N / 2, ISCAL = 400, LLEN = 180;
            int klim;
            ulong idum;
            unchecked
            {
                idum = (ulong)(-13);
            }
            double dd;
            double x6;
            int[] dist = new int[N + 1];
            NormaalVerdeling_BoxMuller_14sep2023 gasdev = new NormaalVerdeling_BoxMuller_14sep2023(0.0, variantie_breed, idum);
            for (int j = 0; j <= N; j++) dist[j] = 0;

            for (int i = 0; i < NPTS; i++)
            {
                x6 = 0.025 * N * gasdev.Afwijking();
                int j = (int)(x6 > 0 ? x6 + 0.5 : x6 - 0.5);
                if ((j >= -NOVER2) && (j <= NOVER2)) ++dist[j + NOVER2];
            }
            //Console.WriteLine($"Normally distributed deviate of {NPTS} points with variance={variantie_breed}");
            //Console.WriteLine("     x      p(x)        graph:");
            //Console.WriteLine();

            for (int j = 0; j <= N; j++)
            {
                dd = ((double)(dist[j])) / NPTS;
                klim = (int)(ISCAL * dd);
                if (klim > LLEN) klim = LLEN;
                string txt = "";
                for (int i = 0; i < klim; i++)
                {
                    txt += '*';
                }
                //Console.Write($"{j / (0.25 * N),8} {dd,9}     ");
                //Console.WriteLine(txt);
            }

            for (int j = 0; j <= N; j++)
            {
                series.Points.Add(new DataPoint(j, dist[j]));
            }

            chart.Dock = DockStyle.Fill;
            chart.Series.Add(series);
            chart.Size = new Size(300, 300);
            chart.TabIndex = 0;
            chart.Text = "chart";

            Controls.Add(chart);
        }
    }
}

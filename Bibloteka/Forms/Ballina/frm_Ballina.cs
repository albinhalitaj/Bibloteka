using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;
using LiveCharts;
using LiveCharts.Wpf;

namespace Bibloteka.Forms
{
    public partial class frm_Ballina : Form
    {
        private readonly BusinessObjects.Stafi _stafi;
        private readonly KlientiManager _klientiManager;
        private readonly LibriManager _libriManager;
        private readonly ChartDataManager _chartDataManager;
        private readonly HuazimetManager _huazimetManager;
        private readonly KthimetManager _kthimetManager;
        public frm_Ballina(Stafi stafi)
        {
            _stafi = stafi;
            _klientiManager = new KlientiManager();
            _libriManager = new LibriManager();
            _chartDataManager = new ChartDataManager();
            _huazimetManager = new HuazimetManager();
            _kthimetManager = new KthimetManager();
            InitializeComponent();
            LoadCharts();
            LoadPieChart();
            LoadAktivitetet();
        }


        private void frm_Ballina_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["language"] == "en-US")
                lblWelcome.Text = @"Welcome " + string.Concat(_stafi.Emri, " ", _stafi.Mbiemri);
            else
                lblWelcome.Text = @"Mirësevini " + string.Concat(_stafi.Emri, " ", _stafi.Mbiemri);
            lblKlientet.Text = _klientiManager.Count().ToString();
            lblLibrat.Text = _libriManager.Count().ToString();
            lblHuazimet.Text = _huazimetManager.Count().ToString();
            lblKthimet.Text = _kthimetManager.Count().ToString();
        }

        private void LoadCharts()
        {
            var kthimetData = _chartDataManager.GetKthimetData();
            var huazimetData = _chartDataManager.GetHuazimetData();
            Kthimet = new ChartValues<int>(kthimetData);
            Huazimet = new ChartValues<int>(huazimetData);
            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Values = Huazimet,
                    Title = ConfigurationManager.AppSettings["language"] == "en-US" ? "Loans" : "Huazimet"
                },
                new ColumnSeries
                {
                    Values = Kthimet,
                    Title = ConfigurationManager.AppSettings["language"] == "en-US" ? "Returns" : "Kthimet"
                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[]
                {
                    "Jan","Feb","Mar","Apr","May","Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
                },
                Separator = new Separator
                {
                    Step = 1
                }
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Regjistrime"
            });
        }

        public void LoadAktivitetet()
        {
            var aktivitetet = _chartDataManager.GetAktivitetet();
            var distance = 0;
            foreach (var aktiviteti in aktivitetet)
            {
                var datelbl = new Label
                {
                    Text = aktiviteti.Data.ToString("F"),
                    Top = 635 + distance,
                    Font = new Font("Poppins", 8),
                    Left = 85,
                    Width = 500
                };
                var lbl = new Label
                {
                    Top = 650 + distance,
                    Font = new Font("Poppins", 11),
                    Left = 85,
                    Width = 5000
                };
                switch (aktiviteti.Tipi)
                {
                    case Tipi.Huazim:
                    {
                        lbl.Text = ConfigurationManager.AppSettings["language"] == "en-US" ? $@"{aktiviteti.Klienti} borrowed the book '{aktiviteti.Libri}'" : $@"{aktiviteti.Klienti} huazoj librin '{aktiviteti.Libri}'";
                        Controls.Add(lbl);
                        Controls.Add(datelbl);
                        distance += 58;
                        break;
                    }
                    case Tipi.Kthim:
                    {
                        lbl.Text = ConfigurationManager.AppSettings["language"] == "en-US" ? $@"{aktiviteti.Klienti} returned the book '{aktiviteti.Libri}'" : $@"{aktiviteti.Klienti} ktheu librin '{aktiviteti.Libri}'";
                        Controls.Add(lbl);
                        Controls.Add(datelbl);
                        distance += 58;
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void LoadPieChart()
        {
            string LabelPoint(ChartPoint chartPoint)
            {
                if (ConfigurationManager.AppSettings["language"] == "en-US")
                {
                    return Math.Abs(chartPoint.Y - 1) < 2 ? $"{chartPoint.Y} Book" : $"{chartPoint.Y} Books";
                }
                return Math.Abs(chartPoint.Y - 1) < 2 ? $"{chartPoint.Y} Libër" : $"{chartPoint.Y} Libra";
            }

            var kategorite = _chartDataManager.GetKategoriteData();
            foreach (var data in kategorite)
            {
                pieChart1.Series.Add(new PieSeries
                {
                    Title = data.Emertimi,
                    Values = new ChartValues<int> { data.Librat},
                    DataLabels = true,
                    LabelPoint = LabelPoint
                });
            }
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        public ChartValues<int> Huazimet { get; set; }
        public ChartValues<int> Kthimet { get; set; }

    }
}

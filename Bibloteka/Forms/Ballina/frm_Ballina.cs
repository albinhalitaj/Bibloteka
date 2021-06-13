using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;
using LiveCharts;
using LiveCharts.Wpf;
using FontStyle = System.Drawing.FontStyle;

namespace Bibloteka.Forms
{
    public partial class frm_Ballina : Form
    {
        private readonly Stafi _stafi;
        private readonly KlientiManager _klientiManager;
        private readonly LibriManager _libriManager;
        private readonly ChartDataManager _chartDataManager;
        public frm_Ballina(Stafi stafi)
        {
            _stafi = stafi;
            _klientiManager = new KlientiManager();
            _libriManager = new LibriManager();
            _chartDataManager = new ChartDataManager();
            InitializeComponent();
            LoadCharts();
            LoadPieChart();
        }
        public class Aktiviteti
        {
            public string Klienti { get; set; }
            public string Libri { get; set; }
            public string Tipi { get; set; }
            public DateTime Data { get; set; }
        }

        private void frm_Ballina_Load(object sender, EventArgs e)
        {
            var aktivitetet = new List<Aktiviteti>
            {
                new Aktiviteti {Klienti = "Albin Halitaj", Libri = "Keshtjella", Data = DateTime.Now, Tipi = "Huazim"},
                new Aktiviteti
                    {Klienti = "Filan Halitaj", Libri = "Game of Thrones", Data = DateTime.Now, Tipi = "Kthim"},
                new Aktiviteti {Klienti = "Syle Sylani", Libri = "Lord of Rings", Data = DateTime.Now, Tipi = "Huazim"},
                new Aktiviteti {Klienti = "John Doe", Libri = "Palace of Dreams", Data = DateTime.Now, Tipi = "Kthim"},
                new Aktiviteti {Klienti = "Mary Jane", Libri = "Palace of Dreams", Data = DateTime.Now, Tipi = "Huazim"}
            };
            lblWelcome.Text = @"Mirësevini " + string.Concat(_stafi.Emri, " ", _stafi.Mbiemri);
            lblKlientet.Text = _klientiManager.Count().ToString();
            lblLibrat.Text = _libriManager.Count().ToString();
            var distance = 0;

            foreach (var aktiviteti in aktivitetet)
            {
                var datelbl = new Label
                {
                    Text = aktiviteti.Data.ToString("D"),
                    Top = 635 + distance,
                    Font = new Font("Poppins", 8),
                    Left = 85,
                    Width = 500
                };
                switch (aktiviteti.Tipi)
                {
                    case "Huazim":
                    {
                        var lbl = new Label
                        {
                            Text = $@"{aktiviteti.Klienti} huazoj librin '{aktiviteti.Libri}'",
                            Top = 650 + distance,
                            Font = new Font("Poppins", 11),
                            Left = 85,
                            Width = 5000
                        };
                        Controls.Add(lbl);
                        Controls.Add(datelbl);
                        distance += 58;
                        break;
                    }
                    case "Kthim":
                    {
                        var lbl = new Label
                        {
                            Text = $@"{aktiviteti.Klienti} ktheu librin '{aktiviteti.Libri}'",
                            Top = 650 + distance,
                            Font = new Font("Poppins", 11),
                            Left = 85,
                            Width = 5000
                        };
                        Controls.Add(lbl);
                        Controls.Add(datelbl);
                        distance += 58;
                        break;
                    }
                }
            }
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
                    Title = "Huazimet"
                },
                new ColumnSeries
                {
                    Values = Kthimet,
                    Title = "Kthimet"
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

        private void LoadPieChart()
        {
            string LabelPoint(ChartPoint chartPoint) => Math.Abs(chartPoint.Y - 1) < 2 ? $"{chartPoint.Y} Libër" : $"{chartPoint.Y} Libra";
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

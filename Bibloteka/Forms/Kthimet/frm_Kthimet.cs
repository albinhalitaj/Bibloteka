using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;

namespace Bibloteka.Forms
{
    public partial class frm_Kthimet : Form
    {
        private readonly Kthimi _model;
        private readonly KthimetManager _kthimetManager;
        private readonly HuazimetManager _huazimetManager;
        private readonly Stafi _stafi;
        private readonly frm_Huazimet _main;
        public frm_Kthimet(frm_Huazimet main,Kthimi model,Stafi stafi)
        {
            _stafi = stafi;
            _model = model;
            _main = main;
            _kthimetManager = new KthimetManager();
            _huazimetManager = new HuazimetManager();
            InitializeComponent();
        }

        private void btnAnulo_Click(object sender, EventArgs e) => Close();

        private void LoadData()
        {
            txtKlienti.Text = _model.Klienti;
            txtLibri.Text = _model.Libri;
            dataHuazimit.Value = _model.DataHuazimit;
            dataKthimit.Value = _model.DataKthimit;
            txtSasia.Text = _model.Sasia.ToString();
            txtPershkrimi.Text = _model.Pershkrimi;
            if (_model.DataKthimit < DateTime.Now)
            {
                txtDitet.Text = (DateTime.Now - _model.DataKthimit).Days.ToString();
                txtShuma.Enabled = true;
                label6.Enabled = true;
                label10.Enabled = true;
                label8.Enabled = true;
            }
        }

        private void frm_Kthimet_Load(object sender, EventArgs e) => LoadData();


        private void txtShuma_TextChanged(object sender, EventArgs e)
        {
            if (txtShuma.Text.Trim().Length == 0)
            {
                txtTotali.Text = string.Empty;
                return;
            }
            var ditet = (DateTime.Now - _model.DataKthimit).Days;
            var shuma = decimal.Parse(txtShuma.Text);
            var totali = shuma * ditet;
            txtTotali.Text = totali.ToString(CultureInfo.InvariantCulture);
        }

        private void btnKthe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"A jeni i sigurt që dëshironi ta ktheni këtë libër?", @"Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                var ditet = (DateTime.Now - _model.DataKthimit).Days;
                if (txtShuma.Enabled && txtShuma.Text.Trim().Length == 0)
                {
                    epKthimet.SetError(txtShuma,"Ju lutem ofroni shumën e gjobës!");
                }
                else
                {
                    if (ditet > 0)
                    {
                        var gjoba = new Gjoba
                        {
                            KlientiId = _model.KlientiId,
                            Shuma = decimal.Parse(txtTotali.Text),
                            ShumaPranuar = decimal.Parse(txtTotali.Text),
                            InsertBy = _stafi.StafiId,
                            InsertDate = DateTime.Now
                        };
                        _kthimetManager.ShtoGjobe(gjoba);
                    }
                    var act = new Aktiviteti
                    {
                        KlientiId = _model.KlientiId,
                        LibriId = _model.LibriId,
                        Tipi = Tipi.Kthim,
                        Data = DateTime.Now,
                        InsertBy = _stafi.StafiId
                    };
                    _huazimetManager.ShtoAktivitet(act);
                    _kthimetManager.Kthe(_model.LibriId, _model.HuazimiId, _model.Sasia);
                    MessageBox.Show(@"Libri u kthye me sukses!", @"Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                    _main.LoadData(_huazimetManager.GetHuazimetEMuajitAktual());
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Ndodhi nje gabim. Ju lutem provoni perseri", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;

namespace Bibloteka.Forms.Huazimet
{
    public partial class frm_HuazoLiber : Form
    {
        private readonly HuazimetManager _huazimetManager;
        private readonly Stafi _stafi;
        private readonly frm_Huazimet _main;
        private readonly LibriManager _libriManager;

        public frm_HuazoLiber(frm_Huazimet main,Stafi stafi)
        {
            _stafi = stafi;
            _libriManager = new LibriManager();
            _main = main;
            _huazimetManager = new HuazimetManager();
            InitializeComponent();
        }

        private void frm_HuazoLiber_Load(object sender, EventArgs e)
        {
            LoadKlients();
            LoadLibrat();
            comboKlienti.SelectedIndex = 0;
            comboLibri.SelectedIndex = 0;
            dataHuazimit.Value = DateTime.Today;
            dataKthimit.Value = DateTime.Today;
        }

        private void LoadKlients()
        {
            comboKlienti.DataSource = _huazimetManager.GetKlients();
            comboKlienti.DisplayMember = "FullName";
            comboKlienti.ValueMember = "KlientiId";
        }

        private void LoadLibrat()
        {
            comboLibri.DataSource = _huazimetManager.GetLibrat();
            comboLibri.DisplayMember = "Titulli";
            comboLibri.ValueMember = "LibriId";
        }

        private void btnHuazo_Click(object sender, EventArgs e)
        {
            if (comboKlienti.SelectedIndex == 0)
            {
                epHuazimet.SetError(comboKlienti,"Ju lutem selektoni klientin!");
            }
            if (comboLibri.SelectedIndex == 0)
            {
                epHuazimet.SetError(comboLibri,"Ju lutem selektoni librin");
            }
            var huazimi = new Huazimi
            {
                KlientiId = comboKlienti.SelectedValue.ToString(),
                LibriId = comboLibri.SelectedValue.ToString(),
                DataHuazimi = Convert.ToDateTime(dataHuazimit.Value),
                DataKthimit = Convert.ToDateTime(dataKthimit.Value),
                NumriKopjeve = Convert.ToInt32(txtSasia.Value),
                Statusi = true,
                Pershkrimi = txtPershkrimi.Text,
                InsertBy = _stafi.StafiId,
                InsertDate = DateTime.Now
            };
            var act = new Aktiviteti
            {
                KlientiId = comboKlienti.SelectedValue.ToString(),
                LibriId = comboLibri.SelectedValue.ToString(),
                Tipi = Tipi.Huazim,
                Data = DateTime.Now,
                InsertBy = _stafi.StafiId
            };
            _huazimetManager.Huazo(huazimi);
            _huazimetManager.ShtoAktivitet(act);
            MessageBox.Show(@"Libri u huazua me sukses!", @"Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }

        private void btnAnulo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboLibri_SelectedIndexChanged(object sender, EventArgs e)
        {
            var libriId = comboLibri.SelectedValue.ToString();
            var libri = _libriManager.FindById(libriId);
            if (libri == null) return;
            txtSasia.Maximum = libri.NumriKopjeve;
            txtSasia.Value = libri.NumriKopjeve;
        }
    }
}

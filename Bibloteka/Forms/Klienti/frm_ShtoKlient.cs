using System;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;

namespace Bibloteka.Forms
{
    public partial class frm_ShtoKlient : Form
    {
        private readonly KlientiManager _klientiManager;
        private readonly frm_Klientet _main;
        private readonly Stafi _stafi;
        public frm_ShtoKlient(Stafi stafi,frm_Klientet main)
        {
            _stafi = stafi;
            _main = main;
            _klientiManager = new KlientiManager();
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            var klienti = new Klienti
            {
                Emri = txtEmri.Text,
                Mbiemri = txtMbiemri.Text,
                Datalindjes = Convert.ToDateTime(dataKlientit.Value),
                Gjinia = radioMashkull.Checked ? "M" : "F",
                NrPersonal = txtNrPersonal.Text,
                NrKontaktues = txtNrKontaktues.Text,
                Adresa = txtAdresa.Text,
                Shteti = Convert.ToString(comboShteti.SelectedItem),
                Qyteti = Convert.ToString(comboQyteti.SelectedItem),
                KodiPostal = txtKodiPostal.Text,
                Emaili = txtEmaili.Text,
                InsertBy = _stafi.StafiId,
                InsertDate = DateTime.Now
            };
            _klientiManager.Add(klienti);
            MessageBox.Show(@"Klienti u ruajt me sukses", @"Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            _main.LoadKlients();
            Close();
        }

        private bool IsValid()
        {
            var status = true;
            if (txtEmri.Text.Trim().Length == 0)
            {
                epKlienti.SetError(txtEmri, "Ju lutem shkruani emrin e klientit!");
                status = false;
            }
            if (txtMbiemri.Text.Trim().Length == 0)
            {
                epKlienti.SetError(txtMbiemri,"Ju lutem shkruani mbiemrin e klientit!");
                status = false;
            }
            if (txtNrPersonal.Text.Trim().Length == 0)
            {
                epKlienti.SetError(txtNrPersonal, "Ju lutem shkruani numrin personal të klientit!");
                status = false;
            }
            if (txtNrKontaktues.Text.Trim().Length == 0)
            {
                epKlienti.SetError(txtNrKontaktues, "Ju lutem shkruani numrin kontaktues e klientit!");
                status = false;
            }
            if (txtAdresa.Text.Trim().Length == 0)
            {
                epKlienti.SetError(txtMbiemri, "Ju lutem shkruani adresen e klientit!");
                status = false;
            }
            return status;
        }

        private void comboShteti_SelectedIndexChanged(object sender, EventArgs e)
        {
            object[] qyetetKosove = {"Prishtinë", "Suharekë", "Ferizaj", "Mitrovicë"};
            object[] qytetetShqipteri = {"Tiranë", "Vlorë", "Berat", "Durrës"};
            if ((string) comboShteti.SelectedItem == "Kosovë")
            {
                comboQyteti.Items.Clear();
                comboQyteti.Items.AddRange(qyetetKosove);
                comboQyteti.SelectedIndex = 0;
            }
            if ((string) comboShteti.SelectedItem == "Shqipëri")
            {
                comboQyteti.Items.Clear();
                comboQyteti.Items.AddRange(qytetetShqipteri);
                comboQyteti.SelectedIndex = 0;
            }
        }

        private void frm_ShtoKlient_Load(object sender, EventArgs e)
        {
            comboShteti.SelectedIndex = 0;
            comboQyteti.SelectedIndex = 0;
        }

        private void btnAnulo_Click(object sender, EventArgs e) => Close();
    }
}

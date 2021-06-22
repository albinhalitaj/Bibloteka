using System;
using System.Data;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;
using static System.Convert;

namespace Bibloteka.Forms
{
    public partial class frm_ShtoStafi : Form
    {
        private readonly frm_Stafi _main;
        private readonly StafiManager _stafiManager;
        private readonly Stafi _stafi;
        private readonly int _id;
        private readonly int _stafiId;

        public frm_ShtoStafi(frm_Stafi main, int id, Stafi stafi,int stafiId)
        {
             _main = main;
            _id = id;
            _stafi = stafi;
            _stafiId = stafiId;
            _stafiManager = new StafiManager();
            InitializeComponent();
        }

        public void LoadComboBoxes()
        {
            var roli = _stafiManager.GetRolet();
            comboRoli.DataSource = roli;
            comboRoli.DisplayMember = "Emertimi";
            comboRoli.ValueMember = "RoliiD";

            var kualifikimet = _stafiManager.GetKualifikimet();
            comboKualifikimi.DataSource = kualifikimet;
            comboKualifikimi.DisplayMember = "Emertimi";
            comboKualifikimi.ValueMember = "KualifikimiId";

            comboRoli.SelectedIndex = 0;
            comboKualifikimi.SelectedIndex = 0;
        }



        public int LastUpdatedNumber(int id)
        {
            var lun = string.Empty;
            var stafi = _stafiManager.FindById(id);
            if (stafi.Rows.Count > 0)
                foreach (DataRow row in stafi.Rows)
                    lun = Convert.ToString(row[15]);
            var n = string.IsNullOrEmpty(lun) ? 1 : ToInt32(ToInt32(lun) + 1);
            return n;
        }

        private bool IsValid()
        {
            epStafi.Clear();
            var status = true;
            if (txtEmri.Text.Trim().Length == 0)
            {
                epStafi.SetError(txtEmri, "Ju lutem shkruani emrin e stafit!");
                status = false;
            }
            else if (txtMbiemri.Text.Trim().Length == 0)
            {
                epStafi.SetError(txtMbiemri, "Ju lutem shkruani mbiemrin e stafit!");
                status = false;
            }
            else if (txtNrPersonal.Text.Trim().Length == 0)
            {
                epStafi.SetError(txtNrPersonal, "Ju lutem shkruani numrin personal të stafit!");
                status = false;
            }
            else if (txtNrKontaktues.Text.Trim().Length == 0)
            {
                epStafi.SetError(txtNrKontaktues, "Ju lutem shkruani numrin kontaktues e stafit!");
                status = false;
            }
            else if (txtFjalekalimi.Text.Trim().Length == 0)
            {
                epStafi.SetError(txtMbiemri, "Ju lutem shkruani adresen e stafit!");
                status = false;
            }
            return status;
        }

       

        private void frm_ShtoStafin_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            if (_id <= 0) return;
            txtEmri.Text = _stafi.Emri;
            txtMbiemri.Text = _stafi.Mbiemri;
            dataStafit.Value = _stafi.Datelindja;
            if (_stafi.Gjinia.Trim() == "M")
                radioMashkull.Checked = true;
            else
                radioFemer.Checked = true;
            txtNrPersonal.Text = _stafi.NrPersonal;
            txtNrKontaktues.Text = _stafi.NrKontaktues;
            txtFjalekalimi.Text = _stafi.Password;
            txtPerdoruesi.Text = _stafi.Username;
            comboShteti.SelectedItem = _stafi.Shteti;
            comboQyteti.SelectedItem = _stafi.Qyteti;
            comboKualifikimi.SelectedValue = _stafi.KualifikimiID;
            comboRoli.SelectedValue = _stafi.RoliId;
            txtAdresa.Text = _stafi.Adresa;
            txtEmaili.Text = _stafi.Emaili;
            txtKodiPostal.Text = _stafi.KodiPostal;
        }


        private void btnShto_Click(object sender, EventArgs e)
        {
            var stafi = new Stafi
            {
                Emri = txtEmri.Text,
                Mbiemri = txtMbiemri.Text,
                Datelindja = dataStafit.Value,
                Gjinia = radioMashkull.Checked ? "M" : "F",
                NrPersonal = txtNrPersonal.Text,
                NrKontaktues = txtNrKontaktues.Text,
                KualifikimiID = ToInt32(comboKualifikimi.SelectedValue),
                Adresa = txtAdresa.Text,
                Shteti = comboShteti.SelectedItem.ToString(),
                Qyteti = comboQyteti.SelectedItem.ToString(),
                KodiPostal = txtKodiPostal.Text,
                Emaili = txtEmaili.Text
            };
            var perdoruesi = new Perdoruesi
            {
                Username = txtPerdoruesi.Text,
                Password = txtFjalekalimi.Text,
                RoliId = ToInt32(comboRoli.SelectedValue),
                Statusi = true,
                InsertBy = _stafiId,
                InsertDate = DateTime.Now
            };
            if (!IsValid()) return;
            if (_id > 0)
            {
                stafi.StafiId = _id;
                stafi.Lub = _stafiId;
                stafi.Lun = LastUpdatedNumber(_id);
                stafi.Lud = DateTime.Now;
                _stafiManager.Update(_id, stafi, perdoruesi);
                MessageBox.Show(@"Stafi u ruajt me sukses", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _main.LoadStafin(_stafiManager.Load());
                Close();
            }
            else
            {
                stafi.InsertBy = _stafiId;
                stafi.InsertDate = DateTime.Now;
                _stafiManager.Add(stafi, perdoruesi);
                MessageBox.Show(@"Stafi u ruajt me sukses", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _main.LoadStafin(_stafiManager.Load());
                Close();
            }
        }

        private void comboShteti_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboQyteti.Items.Clear();
            switch ((string)comboShteti.SelectedItem)
            {
                case "Kosovë":
                    comboQyteti.Items.AddRange(Cities.GetCities("Kosovë"));
                    comboQyteti.SelectedIndex = 16;
                    break;
                case "Shqipëri":
                    comboQyteti.Items.AddRange(Cities.GetCities("Shqipëri"));
                    comboQyteti.SelectedIndex = 0;
                    break;
                case "Mali i Zi":
                    comboQyteti.Items.AddRange(Cities.GetCities("Mali i Zi"));
                    comboQyteti.SelectedIndex = 0;
                    break;
                case "Maqedoni":
                    comboQyteti.Items.AddRange(Cities.GetCities("Maqedoni"));
                    comboQyteti.SelectedIndex = 18;
                    break;
            }
        }

        private void btnAnulo_Click(object sender, EventArgs e) => Close();
    }
}


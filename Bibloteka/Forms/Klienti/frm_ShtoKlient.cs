using System;
using System.Data;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;
using static System.Convert;

namespace Bibloteka.Forms
{
    public partial class frm_ShtoKlient : Form
    {
        private readonly KlientiManager _klientiManager;
        private readonly frm_Klientet _main;
        private readonly Stafi _stafi;
        private readonly Klienti _klienti;
        private readonly string _id;
        public frm_ShtoKlient(Stafi stafi,frm_Klientet main,string id,Klienti klienti)
        {
            _stafi = stafi;
            _main = main;
            _id = id;
            _klienti = klienti;
            _klientiManager = new KlientiManager();
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            var klienti = new Klienti
            {
                Emri = txtEmri.Text,
                Mbiemri = txtMbiemri.Text,
                Datalindjes = ToDateTime(dataKlientit.Value),
                Gjinia = radioMashkull.Checked ? "M" : "F",
                NrPersonal = txtNrPersonal.Text,
                NrKontaktues = txtNrKontaktues.Text,
                Adresa = txtAdresa.Text,
                Shteti = Convert.ToString(comboShteti.SelectedItem),
                Qyteti = Convert.ToString(comboQyteti.SelectedItem),
                KodiPostal = txtKodiPostal.Text,
                Emaili = txtEmaili.Text,
            };
            if (!IsValid()) return;
            if (!string.IsNullOrEmpty(_id))
            {
                klienti.Lub =  _stafi.StafiId;
                klienti.Lun = LastUpdatedNumber(_id);
                klienti.Lud = DateTime.Now;
                _klientiManager.Update(_id,klienti);
                MessageBox.Show(@"Klienti u ruajt me sukses", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _main.LoadKlients();
                Close();
            }
            else
            {
                klienti.InsertBy = _stafi.StafiId;
                klienti.InsertDate = DateTime.Now;
                _klientiManager.Add(klienti);
                MessageBox.Show(@"Klienti u ruajt me sukses", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _main.LoadKlients();
                Close();
            }
        }


        public int LastUpdatedNumber(string id)
        {
            var lun = string.Empty;
            var klient = _klientiManager.GetById(id);
            if (klient.Rows.Count > 0)
                foreach (DataRow row in klient.Rows)
                    lun = Convert.ToString(row[15]);
            var n = string.IsNullOrEmpty(lun) ? 1 : Convert.ToInt32(Convert.ToInt32(lun) + 1);
            return n;
        }

        private bool IsValid()
        {
            epKlienti.Clear();
            var status = true;
            if (txtEmri.Text.Trim().Length == 0)
            {
                epKlienti.SetError(txtEmri, "Ju lutem shkruani emrin e klientit!");
                status = false;
            }
            else if (txtMbiemri.Text.Trim().Length == 0)
            {
                epKlienti.SetError(txtMbiemri,"Ju lutem shkruani mbiemrin e klientit!");
                status = false;
            }
            else if(txtNrPersonal.Text.Trim().Length == 0)
            {
                epKlienti.SetError(txtNrPersonal, "Ju lutem shkruani numrin personal të klientit!");
                status = false;
            }
            else if(txtNrKontaktues.Text.Trim().Length == 0)
            {
                epKlienti.SetError(txtNrKontaktues, "Ju lutem shkruani numrin kontaktues e klientit!");
                status = false;
            }
            else if (txtAdresa.Text.Trim().Length == 0)
            {
                epKlienti.SetError(txtMbiemri, "Ju lutem shkruani adresen e klientit!");
                status = false;
            }
            return status;
        }

        private void comboShteti_SelectedIndexChanged(object sender, EventArgs e)
        {
            object[] qytetetShqipteri = {"Tirana", "Durrësi", "Shkodra", "Elbasani", "Vlora", "Korça", "Fieri", "Berati", "Lushnja", "Pogradeci", "Kavaja", "Laçi", "Lezha", "Kukësi", "Gjirokastra",
                "Patosi","Kruja","Kuçova","Saranda","Peshkopia","Burreli","Cërriku","Çorovoda","Shijaku", "Librazhdi", "Tepelena", "Gramshi", "Poliçani", "Bulqiza", "Përmeti", "Fushë-Kruja", "Kamëza",
                "Rrësheni","Ballshi","Mamurrasi","Bajram Curri", "Erseka", "Peqini", "Divjaka", "Selenica", "Bilishti", "Roskoveci", "Këlcyra", "Puka", "Memaliaj", "Rrogozhina", "Ura Vajgurore", "Himara",
                "Delvina","Vora", "Kopliku", "Maliqi", "Përrenjasi", "Shtërmeni", "Kruma", "Libohova", "Orikumi", "Fushë-Arrëza", "Shëngjini", "Rubiku", "Miloti", "Leskoviku", "Konispoli", "Krasta", "Kërraba"};
            object[] qytetetKosove = {"Deçan","Gjakovë","Gllogoc","Gjilan", "Dragash", "Istog", "Kaçanik", "Klinë", "Fushë Kosovë", "Kamenicë", "Leposaviq", "Lipjan","Obiliq",
                "Rahovec", "Pejë","Podujevë","Prishtinë","Prizren","Skënderaj","Shtime","Shtërpcë","Suharekë", "Ferizaj", "Viti", "Vushtrri", "Zubin Potok", "Zveçan", "Malishevë",
                "Novobërdë","Mitrovicë e Veriu", "Mitrovicë e Jugu", "Junik", "Hani i Elezit", "Mamushë", "Graçanicë", "Ranillug", "Partesh", "Kllokot"};
           
            if ((string) comboShteti.SelectedItem == "Kosovë")
            {
                comboQyteti.Items.Clear();
                comboQyteti.Items.AddRange(qytetetKosove);
                comboQyteti.SelectedIndex = 16;
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
            if (!string.IsNullOrEmpty(_id))
            {
                txtEmri.Text = _klienti.Emri;
                txtMbiemri.Text = _klienti.Mbiemri;
                dataKlientit.Value = _klienti.Datalindjes;
                if (_klienti.Gjinia == "Mashkull")
                    radioMashkull.Checked = true;
                else
                    radioFemer.Checked = true;
                txtNrPersonal.Text = _klienti.NrPersonal;
                txtNrKontaktues.Text = _klienti.NrKontaktues;
                txtAdresa.Text = _klienti.Adresa;
                comboShteti.SelectedItem = _klienti.Shteti;
                comboQyteti.SelectedItem = _klienti.Qyteti;
                txtKodiPostal.Text = _klienti.KodiPostal;
                txtEmaili.Text = _klienti.Emaili;
            }
            else
            {
                comboShteti.SelectedIndex = 0;
                comboQyteti.SelectedIndex = 16;
            }
        }

        private void btnAnulo_Click(object sender, EventArgs e) => Close();
    }
}

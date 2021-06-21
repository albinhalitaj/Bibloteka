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
        private readonly Stafi _stafi;
        private readonly StafiManager _stafiManager;
        private readonly RoliManager _roliManager;
        private readonly PerdoruesiManager _perdoruesiManager;
        private readonly KualifikimiManager _kualifikimiMaanger;
        private readonly string _id;

        private readonly Roli _roli;
        private  Perdoruesi _perdoruesi;
        public frm_ShtoStafi(frm_Stafi main, string id, Stafi stafi)
        {
            _stafi = stafi;
             _main = main;
            _id = id;
            _stafiManager = new StafiManager();
            _perdoruesiManager = new PerdoruesiManager();
            InitializeComponent();
            LoadComboBoxes();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            
            _stafi.Emri = txtEmri.Text;
            _stafi.Mbiemri = txtMbiemri.Text;
            _stafi.Datelindja = ToDateTime(dataStafit.Value);
            _stafi.Gjinia = radioMashkull.Checked ? "M" : "F";
            _stafi.NrPersonal = txtNrPersonal.Text;
            _stafi.NrKontaktues = txtNrKontaktues.Text;
            _stafi.KualifikimiID = Convert.ToInt32(comboKualifikimet.SelectedValue);
            _stafi.Adresa = txtPassword.Text;
            _stafi.Shteti = txtShteti.Text;
            _stafi.Qyteti = txtQyteti.Text;
            _stafi.KodiPostal = txtKodiPostal.Text;
            _stafi.Emaili = txtEmaili.Text;
            var perdoruesi = new Perdoruesi { Username = txtUsername.Text, Password = txtPassword.Text };
            var roliID = Convert.ToInt32(comboRoli.SelectedValue);
            if (!IsValid()) return;
            if (!string.IsNullOrEmpty(_id))
            {
                _stafi.Lub = _stafi.StafiId;
                _stafi.Lun = LastUpdatedNumber(_id);
                _stafi.Lud = DateTime.Now;
                _stafiManager.Update(_id, _stafi,_perdoruesi,roliID);
                MessageBox.Show(@"Stafi u ruajt me sukses", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _main.LoadStafin();
                Close();
            }
            else
            {
                _stafi.InsertBy = 1;
                _stafi.InsertDate = DateTime.Now;
                _stafiManager.Add(_stafi,perdoruesi,roliID);
                MessageBox.Show(@"Stafi u ruajt me sukses", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _main.LoadStafin();
                Close();
            }
        }
        public void LoadComboBoxes()
        {
            var roli = _stafiManager.GetRolet();
            comboRoli.DataSource = roli;
            comboRoli.DisplayMember = "Emertimi";
            comboRoli.ValueMember = "RoliiD";

            var kualifikimet = _stafiManager.GetKualifikimet();
            comboKualifikimet.DataSource = kualifikimet;
            comboKualifikimet.DisplayMember = "Emertimi";
            comboKualifikimet.ValueMember = "KualifikimiId";


            if (!string.IsNullOrEmpty(_id))
                return;
            comboRoli.SelectedIndex = 0;
            comboKualifikimet.SelectedIndex = 0;
        }




        public int LastUpdatedNumber(string id)
        {
            var lun = string.Empty;
            var stafi = _stafiManager.FindById(id);
            if (stafi.Rows.Count > 0)
                foreach (DataRow row in stafi.Rows)
                    lun = Convert.ToString(row[15]);
            var n = string.IsNullOrEmpty(lun) ? 1 : Convert.ToInt32(Convert.ToInt32(lun) + 1);
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
            else if (txtPassword.Text.Trim().Length == 0)
            {
                epStafi.SetError(txtMbiemri, "Ju lutem shkruani adresen e stafit!");
                status = false;
            }
            return status;
        }

       

        private void frm_ShtoStafin_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_id))
            {
                txtEmri.Text = _stafi.Emri;
                txtMbiemri.Text = _stafi.Mbiemri;
                dataStafit.Value = _stafi.Datelindja;
                if (_stafi.Gjinia == "Mashkull")
                    radioMashkull.Checked = true;
                else
                    radioFemer.Checked = true;
                txtNrPersonal.Text = _stafi.NrPersonal;
                txtNrKontaktues.Text = _stafi.NrKontaktues;
                txtPassword.Text = _stafi.Adresa;
                txtShteti.Text = _stafi.Shteti;
                txtQyteti.Text = _stafi.Qyteti;
                txtKodiPostal.Text = _stafi.KodiPostal;
                txtEmaili.Text = _stafi.Emaili;

            }
            
        }

        private void btnAnulo_Click(object sender, EventArgs e) => Close();

        private object[] GetCities(string shteti)
        {
            object[] qytetet = null;
            switch (shteti)
            {
                case "Kosovë":
                    qytetet = new object[] {
                    "Deçan","Gjakovë","Gllogoc","Gjilan", "Dragash", "Istog", "Kaçanik", "Klinë", "Fushë Kosovë", "Kamenicë", "Leposaviq", "Lipjan","Obiliq",
                    "Rahovec", "Pejë","Podujevë","Prishtinë","Prizren","Skënderaj","Shtime","Shtërpcë","Suharekë", "Ferizaj", "Viti", "Vushtrri", "Zubin Potok", "Zveçan", "Malishevë",
                    "Novobërdë","Mitrovicë e Veriu", "Mitrovicë e Jugu", "Junik", "Hani i Elezit", "Mamushë", "Graçanicë", "Ranillug", "Partesh", "Kllokot"};
                    break;
                case "Shqipëri":
                    qytetet = new object[] {"Tirana", "Durrësi", "Shkodra", "Elbasani", "Vlora", "Korça", "Fieri", "Berati", "Lushnja", "Pogradeci", "Kavaja", "Laçi", "Lezha", "Kukësi", "Gjirokastra",
                            "Patosi","Kruja","Kuçova","Saranda","Peshkopia","Burreli","Cërriku","Çorovoda","Shijaku", "Librazhdi", "Tepelena", "Gramshi", "Poliçani", "Bulqiza", "Përmeti", "Fushë-Kruja", "Kamëza",
                            "Rrësheni","Ballshi","Mamurrasi","Bajram Curri", "Erseka", "Peqini", "Divjaka", "Selenica", "Bilishti", "Roskoveci", "Këlcyra", "Puka", "Memaliaj", "Rrogozhina", "Ura Vajgurore", "Himara",
                            "Delvina","Vora", "Kopliku", "Maliqi", "Përrenjasi", "Shtërmeni", "Kruma", "Libohova", "Orikumi", "Fushë-Arrëza", "Shëngjini", "Rubiku", "Miloti", "Leskoviku", "Konispoli", "Krasta", "Kërraba"};
                    break;
                case "Maqedoni":
                    qytetet = new object[] {
                        "Berova", "Dellçeva", "Koçani", "Kamenica", "Peçeva", "Probishtipi", "Shtipi", "Vinica", "Kratova", "Kriva Pallanka", "Kumanova", "Manastiri", "Demir Hisari", "Krusheva", "Prilepi","Resnja",
                        "Gostivari","Tetova", "Shkupi", "Bogdanca", "Gjevgjelia", "Radovishti", "Strumica", "Vallandova", "Dibra", "Kërçova", "Brod", "Ohri", "Struga", "Demir Kapia", "Kavadari", "Negotina","Sveti Nikolla","Velesi"
                    };
                    break;
                case "Mali i Zi":
                    qytetet = new object[] {
                    "Podgorica", "Nikšić", "Herceg Novi", "Pljevlja", "Bar", "Bijelo Polje", "Cetinje", "Budva", "Kotor",
                    "Berane", "Ulcinj", "Tivat", "Rožaje"};
                    break;
            }

            return qytetet;
        }

        
    }
}


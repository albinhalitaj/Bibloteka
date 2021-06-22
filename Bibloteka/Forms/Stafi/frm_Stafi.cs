using System;
using System.Data;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;


namespace Bibloteka.Forms
{
    public partial class frm_Stafi : Form
    {
        private readonly Stafi _stafi;
        private readonly StafiManager _stafiManager;
       
        public frm_Stafi(Stafi stafi)
        {
          
            _stafi = stafi;
            _stafiManager = new StafiManager();
            InitializeComponent();
            LoadStafin(_stafiManager.Load());
        }


        public void LoadStafin(DataTable dt)
        {
            dgv_Stafi.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow stafi in dt.Rows)
                {
                    var stafiRow = new DataGridViewRow();
                    stafiRow.CreateCells(dgv_Stafi);
                    stafiRow.Cells[0].Value = Convert.ToString(stafi[0]);
                    stafiRow.Cells[1].Value = Convert.ToString(stafi[1]);
                    stafiRow.Cells[2].Value = Convert.ToString(stafi[2]);
                    stafiRow.Cells[3].Value = Convert.ToDateTime(stafi[3]).ToString("dd/MM/yyyy");
                    stafiRow.Cells[4].Value = Convert.ToString(stafi[4]);
                    stafiRow.Cells[5].Value = Convert.ToString(stafi[5]);
                    stafiRow.Cells[6].Value = Convert.ToString(stafi[6]);
                    stafiRow.Cells[7].Value = Convert.ToString(stafi[7]);
                    stafiRow.Cells[8].Value = imageList1.Images[0];
                    stafiRow.Cells[9].Value = imageList1.Images[1];
                    dgv_Stafi.Rows.Add(stafiRow);
                }
            }
        }

        private Stafi GetSelectedStafInfo(int id)
        {
            if (dgv_Stafi.Rows.Count <= 0)
                return null;
            if (dgv_Stafi.SelectedRows.Count != 1)
                return null;
            var stafi = _stafiManager.FindById(id);
            var staf = new Stafi();
            foreach (DataRow s in stafi.Rows)
            {
                staf.Emri = Convert.ToString(s[0]);
                staf.Mbiemri = Convert.ToString(s[1]);
                staf.Datelindja = Convert.ToDateTime(s[2]);
                staf.Gjinia = Convert.ToString(s[3]);
                staf.NrPersonal = Convert.ToString(s[4]);
                staf.NrKontaktues = Convert.ToString(s[5]);
                staf.KualifikimiID = Convert.ToInt32(s[6]);
                staf.Adresa = Convert.ToString(s[7]);
                staf.Qyteti = Convert.ToString(s[8]);
                staf.Shteti = Convert.ToString(s[9]);
                staf.KodiPostal = Convert.ToString(s[10]);
                staf.Emaili = Convert.ToString(s[11]);
                staf.RoliId = Convert.ToInt32(s[12]);
                staf.Username = Convert.ToString(s[13]);
                staf.Password = Convert.ToString(s[14]);
            }
            return staf;
        }

        private void NdryshoStafin()
        {
            var id = Convert.ToInt32(dgv_Stafi.CurrentRow?.Cells[0].Value);
            var ndryshoStafin = new frm_ShtoStafi( this,id, GetSelectedStafInfo(id),_stafi.StafiId);
            ndryshoStafin.ShowDialog();
        }

        private void FshiStafin()
        {
            var id = Convert.ToInt32(dgv_Stafi.CurrentRow?.Cells[0].Value);
            if (MessageBox.Show(@"A jeni i sigurt që doni ta fshihni këtë stafi?", @"Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            var result = _stafiManager.Remove(id);
            MessageBox.Show(result ? @"Stafi u fshi me sukses!" : @"Ky Staf nuk mund të fshihet!", @"Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            LoadStafin(_stafiManager.Load());
        }

        private void frm_Stafi_Load(object sender, EventArgs e)
        {

        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            var shtoStaf = new frm_ShtoStafi(this,0,new Stafi(),_stafi.StafiId);
            shtoStaf.ShowDialog();
        }

        private void dgv_Stafi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Stafi.CurrentCell.ColumnIndex.Equals(8)) NdryshoStafin();
            if (dgv_Stafi.CurrentCell.ColumnIndex.Equals(9)) FshiStafin();
        }

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            if (txtKerko.Text.Trim().Length != 0)
            {
                dgv_Stafi.Rows.Clear();
                try
                {
                    var stafi = _stafiManager.Search(txtKerko.Text);
                    LoadStafin(stafi);
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Ndodhi nje gabim. Ju lutem provoni perseri", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
                LoadStafin(_stafiManager.Load());
        }
    }
}


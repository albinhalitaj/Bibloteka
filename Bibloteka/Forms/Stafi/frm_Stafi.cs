using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;


namespace Bibloteka.Forms
{
    public partial class frm_Stafi : Form
    {
        private readonly Stafi _stafi;
        private readonly StafiManager stafiManager;
        public frm_Stafi(Stafi stafi)
        {

            _stafi = stafi;
            stafiManager = new StafiManager();
            InitializeComponent();
            LoadStafin();
        }


        public void LoadStafin()
        {
            dgv_Stafi.Rows.Clear();
            var dt = stafiManager.Load();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow stafi in dt.Rows)
                {
                    DataGridViewRow stafiRow = new DataGridViewRow();
                    stafiRow.CreateCells(dgv_Stafi);
                    stafiRow.Cells[0].Value = Convert.ToString(stafi[0]);
                    stafiRow.Cells[1].Value = Convert.ToString(stafi[1]);
                    stafiRow.Cells[2].Value = Convert.ToString(stafi[2]);
                    stafiRow.Cells[3].Value = Convert.ToDateTime(stafi[3]).ToString("dd/MM/yyyy");
                    stafiRow.Cells[4].Value = Convert.ToString(stafi[4].ToString().Trim()) == "M" ? "Mashkull" : "Femër";
                    stafiRow.Cells[5].Value = Convert.ToString(stafi[5]);
                    stafiRow.Cells[6].Value = Convert.ToString(stafi[6]);
                    stafiRow.Cells[7].Value = Convert.ToString(stafi[7]);
                    stafiRow.Cells[8].Value = Convert.ToString(stafi[8]);
                    stafiRow.Cells[9].Value = Convert.ToString(stafi[9]);
                    stafiRow.Cells[10].Value = Convert.ToString(stafi[10]);
                    //stafiRow.Cells[11].Value = imageList1.Images[0];
                    //stafiRow.Cells[12].Value = imageList1.Images[1];
                    dgv_Stafi.Rows.Add(stafiRow);
                }
            }
        }

       

        public void FshiStaf()
        {
            var id = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[0].Value);
            if (dgv_Stafi.SelectedRows.Count != 1) return;
            if (MessageBox.Show(@"A jeni i sigurt që doni ta fshihni këtë staf?", @"Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            stafiManager.Remove(id);
            MessageBox.Show(@"Stafi u fshi me sukses!", @"Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            LoadStafin();
        }

       

        private Stafi GetSelectedStafInfo()
        {
            if (dgv_Stafi.Rows.Count <= 0)
                return null;
            if (dgv_Stafi.SelectedRows.Count != 1)
                return null;
            var datalindjes = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[3].Value);
            var day = datalindjes.Substring(0, 2);
            var month = datalindjes.Substring(3, 2);
            var date = Convert.ToDateTime(string.Concat(month, "/", day, datalindjes.Substring(5, 5)));
            var staf = new Stafi()
            {
                Emri = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[1].Value),
                Mbiemri = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[2].Value),
                Datelindja = date,
                Gjinia = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[4].Value),
                NrPersonal = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[5].Value),
                NrKontaktues = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[6].Value),
                Adresa = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[7].Value),
                Shteti = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[9].Value),
                Qyteti = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[8].Value),
                KodiPostal = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[10].Value),
                Emaili = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[11].Value)
            };
            return staf;
        }

        private void NdryshoStafin()
        {
            var id = Convert.ToString(dgv_Stafi.CurrentRow?.Cells[0].Value);
            var ndryshoStafin = new frm_ShtoStafi( this,id, GetSelectedStafInfo());
            ndryshoStafin.ShowDialog();
        }

        private void dvg_Stafi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Stafi.CurrentCell.ColumnIndex.Equals(13)) FshiStaf();
            if (dgv_Stafi.CurrentCell.ColumnIndex.Equals(12)) NdryshoStafin();
        }

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            if (txtKerko.Text.Trim().Length != 0)
            {
                dgv_Stafi.Rows.Clear();
                try
                {
                    var staf = stafiManager.Search(txtKerko.Text);
                    if (staf.Rows.Count > 0)
                    {
                        foreach (DataRow item in staf.Rows)
                        {
                            var stafRow = new DataGridViewRow();
                            stafRow.CreateCells(dgv_Stafi);
                            stafRow.Cells[0].Value = Convert.ToString(item[0]);
                            stafRow.Cells[1].Value = Convert.ToString(item[1]);
                            stafRow.Cells[2].Value = Convert.ToString(item[2]);
                            stafRow.Cells[3].Value = Convert.ToDateTime(item[3]).ToString("dd/MM/yyyy");
                            stafRow.Cells[4].Value = Convert.ToString(item[4].ToString().Trim()) == "M" ? "Mashkull" : "Femër";
                            stafRow.Cells[5].Value = Convert.ToString(item[5]);
                            stafRow.Cells[6].Value = Convert.ToString(item[6]);
                            stafRow.Cells[7].Value = Convert.ToString(item[7]);
                            stafRow.Cells[8].Value = Convert.ToString(item[8]);
                            stafRow.Cells[9].Value = Convert.ToString(item[9]);
                            stafRow.Cells[10].Value = Convert.ToString(item[10]);
                            stafRow.Cells[11].Value = Convert.ToString(item[11]);
                            stafRow.Cells[12].Value = imageList1.Images[0];
                            stafRow.Cells[13].Value = imageList1.Images[1];
                            dgv_Stafi.Rows.Add(stafRow);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Ndodhi nje gabim. Ju lutem provoni perseri", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
                LoadStafin();
        }

        private void frm_Stafi_Load(object sender, EventArgs e)
        {

        }

        private void btnShto_Click_1(object sender, EventArgs e)
        {
            var shtoStaf = new frm_ShtoStafi( this,null, new Stafi());
            shtoStaf.ShowDialog();
        }
    }
}


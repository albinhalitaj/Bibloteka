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

namespace Bibloteka.Forms
{
    public partial class frm_Klientet : Form
    {
        private readonly Stafi _stafi;
        private readonly KlientiManager _klientiManager;
        public frm_Klientet(Stafi stafi)
        {
            _stafi = stafi;
            _klientiManager = new KlientiManager();
            InitializeComponent();
        }


        public void LoadKlients()
        {
            dgv_Klientet.Rows.Clear();
            var dt = _klientiManager.Load();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow klient in dt.Rows)
                {
                    var klientRow = new DataGridViewRow();
                    klientRow.CreateCells(dgv_Klientet);
                    klientRow.Cells[0].Value = Convert.ToString(klient[0]);
                    klientRow.Cells[1].Value = Convert.ToString(klient[1]);
                    klientRow.Cells[2].Value = Convert.ToString(klient[2]);
                    klientRow.Cells[3].Value = Convert.ToDateTime(klient[3]).ToString("dd/MM/yyyy");
                    klientRow.Cells[4].Value = Convert.ToString(klient[4].ToString().Trim()) == "M" ? "Mashkull" : "Femër";
                    klientRow.Cells[5].Value = Convert.ToString(klient[5]);
                    klientRow.Cells[6].Value = Convert.ToString(klient[6]);
                    klientRow.Cells[7].Value = Convert.ToString(klient[7]);
                    klientRow.Cells[8].Value = Convert.ToString(klient[8]);
                    klientRow.Cells[9].Value = Convert.ToString(klient[9]);
                    klientRow.Cells[10].Value = Convert.ToString(klient[10]);
                    klientRow.Cells[11].Value = Convert.ToString(klient[11]);
                    klientRow.Cells[12].Value = imageList1.Images[0];
                    klientRow.Cells[13].Value = imageList1.Images[1];
                    dgv_Klientet.Rows.Add(klientRow);
                }
            }
        }

        private void frm_Klientet_Load(object sender, EventArgs e)
        {
            lblTotalKlients.Text = @"Total Klientë: " + _klientiManager.Count();
            LoadKlients();
        }

        public void FshiKlient()
        {
            var id = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[0].Value);
            if (dgv_Klientet.SelectedRows.Count != 1) return;
            if (MessageBox.Show(@"A jeni i sigurt që doni ta fshihni këtë klient?", @"Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            _klientiManager.Remove(id);
            MessageBox.Show(@"Klienti u fshi me sukses!", @"Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            LoadKlients();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            var shtoKlient = new frm_ShtoKlient(_stafi, this, null,new Klienti());
            shtoKlient.ShowDialog();
        }

        private Klienti GetSelectedKlientInfo()
        {
            if (dgv_Klientet.Rows.Count <= 0)
                return null;
            if (dgv_Klientet.SelectedRows.Count != 1)
                return null;
            var datalindjes = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[3].Value);
            var day = datalindjes.Substring(0, 2);
            var month = datalindjes.Substring(3, 2);
            var date = Convert.ToDateTime(string.Concat(month, "/", day, datalindjes.Substring(5, 5)));
            var klienti = new Klienti()
            {
                Emri = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[1].Value),
                Mbiemri = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[2].Value),
                Datalindjes = date,
                Gjinia = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[4].Value),
                NrPersonal = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[5].Value),
                NrKontaktues = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[6].Value),
                Adresa = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[7].Value),
                Shteti = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[9].Value),
                Qyteti = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[8].Value),
                KodiPostal = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[10].Value),
                Emaili = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[11].Value)
            };
            return klienti;
        }

        private void NdryshoKlient()
        {
            var id = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[0].Value);
            var ndryshoKlient = new frm_ShtoKlient(_stafi, this, id,GetSelectedKlientInfo());
            ndryshoKlient.ShowDialog();
        }

        private void dgv_Klientet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Klientet.CurrentCell.ColumnIndex.Equals(13)) FshiKlient();
            if (dgv_Klientet.CurrentCell.ColumnIndex.Equals(12)) NdryshoKlient();
        }

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            if (txtKerko.Text.Trim().Length != 0)
            {
                dgv_Klientet.Rows.Clear();
                try
                {
                    var klienti = _klientiManager.Search(txtKerko.Text);
                    if (klienti.Rows.Count > 0)
                    {
                        foreach (DataRow klient in klienti.Rows)
                        {
                            var klientRow = new DataGridViewRow();
                            klientRow.CreateCells(dgv_Klientet);
                            klientRow.Cells[0].Value = Convert.ToString(klient[0]);
                            klientRow.Cells[1].Value = Convert.ToString(klient[1]);
                            klientRow.Cells[2].Value = Convert.ToString(klient[2]);
                            klientRow.Cells[3].Value = Convert.ToDateTime(klient[3]).ToString("dd/MM/yyyy");
                            klientRow.Cells[4].Value = Convert.ToString(klient[4].ToString().Trim()) == "M" ? "Mashkull" : "Femër";
                            klientRow.Cells[5].Value = Convert.ToString(klient[5]);
                            klientRow.Cells[6].Value = Convert.ToString(klient[6]);
                            klientRow.Cells[7].Value = Convert.ToString(klient[7]);
                            klientRow.Cells[8].Value = Convert.ToString(klient[8]);
                            klientRow.Cells[9].Value = Convert.ToString(klient[9]);
                            klientRow.Cells[10].Value = Convert.ToString(klient[10]);
                            klientRow.Cells[11].Value = Convert.ToString(klient[11]);
                            klientRow.Cells[12].Value = imageList1.Images[0];
                            klientRow.Cells[13].Value = imageList1.Images[1];
                            dgv_Klientet.Rows.Add(klientRow);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Ndodhi nje gabim. Ju lutem provoni perseri", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error); ;
                }
            }
            else
                LoadKlients();
        }
    }
}

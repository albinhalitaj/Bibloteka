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
using ClosedXML.Excel;

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
            dgv_Klientet.Columns[3].DefaultCellStyle.Format = "d";
        }


        public void LoadKlients(DataTable dt)
        {
            dgv_Klientet.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow klient in dt.Rows)
                {
                    var klientRow = new DataGridViewRow();
                    klientRow.CreateCells(dgv_Klientet);
                    klientRow.Cells[0].Value = Convert.ToString(klient[0]);
                    klientRow.Cells[1].Value = Convert.ToString(klient[1]);
                    klientRow.Cells[2].Value = Convert.ToString(klient[2]);
                    klientRow.Cells[3].Value = Convert.ToDateTime(klient[3]);
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
            LoadKlients(_klientiManager.Load());
        }

        public void FshiKlient()
        {
            var id = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[0].Value);
            if (dgv_Klientet.SelectedRows.Count != 1) return;
            if (MessageBox.Show(@"A jeni i sigurt që doni ta fshihni këtë klient?", @"Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            var result = _klientiManager.Remove(id);
            MessageBox.Show(result ? @"Klienti u fshi me sukses!" : @"Ky klient nuk mund të fshihet!", @"Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            LoadKlients(_klientiManager.Load());
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
            var klienti = new Klienti
            {
                Emri = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[1].Value),
                Mbiemri = Convert.ToString(dgv_Klientet.CurrentRow?.Cells[2].Value),
                Datalindjes = Convert.ToDateTime(dgv_Klientet.CurrentRow?.Cells[3].Value),
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
                    LoadKlients(klienti);
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Ndodhi nje gabim. Ju lutem provoni perseri", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
                LoadKlients(_klientiManager.Load());
        }

        private void btnShkarko_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = @"Excel WorkBook|*.xlsx"})
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var dt = workbook.Worksheets.Add(_klientiManager.Load(), "Klientët");
                            dt.Columns().AdjustToContents();
                            dt.Rows().AdjustToContents();
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show(@"Të dhënat janë eksportuar me sukses!", @"Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(@"Ndodhi një gabim ju lutem provoni përsëri", @"Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            } 
        }
    }
}

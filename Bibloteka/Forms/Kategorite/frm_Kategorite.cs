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
    public partial class frm_Kategorite : Form
    {
        private readonly Stafi _stafi;
        private readonly KategoriaManager _kategoriaManager;
        public frm_Kategorite(Stafi stafi)
        {
            _kategoriaManager = new KategoriaManager();
            _stafi = stafi;
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            var shto = new frm_Shto(this,_stafi);
            shto.ShowDialog();
        }

        public void LoadCategories()
        {
            dgv_Kategorite.Rows.Clear();
            var dt = _kategoriaManager.Load();
            if (dt.Rows.Count <= 0) return;
            foreach (DataRow kategori in dt.Rows)
            {
                var categoryRow = new DataGridViewRow();
                categoryRow.CreateCells(dgv_Kategorite);
                categoryRow.Cells[0].Value = Convert.ToInt32(kategori[0]);
                categoryRow.Cells[1].Value = Convert.ToString(kategori[1]);
                categoryRow.Cells[2].Value = Convert.ToString(kategori[2]);
                dgv_Kategorite.Rows.Add(categoryRow);
            }
            lblTotalCategories.Text = @"Total Kategori: " + _kategoriaManager.Total();
        }

        private void frm_Kategorite_Load(object sender, EventArgs e)
        {
            LoadCategories();
            lblTotalCategories.Text = @"Total Kategori: " + _kategoriaManager.Total();
        }


        private void dgv_Kategorite_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Kategorite.Rows.Count <= 0) return;
            if (dgv_Kategorite.SelectedRows.Count != 1) return;
            var kategoria = new Kategoria()
            {
                Emertimi = Convert.ToString(dgv_Kategorite.CurrentRow?.Cells[1].Value),
                Pershkrimi = Convert.ToString(dgv_Kategorite.CurrentRow?.Cells[2].Value)
            };
            var id = Convert.ToInt32(dgv_Kategorite.CurrentRow?.Cells[0].Value);
            var shto = new frm_Edito(_stafi, this, id, kategoria);
            shto.ShowDialog();
        }

        private void btnNdrysho_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgv_Kategorite.CurrentRow?.Cells[0].Value);
            var kategoria = new Kategoria()
            {
                Emertimi = Convert.ToString(dgv_Kategorite.CurrentRow?.Cells[1].Value),
                Pershkrimi = Convert.ToString(dgv_Kategorite.CurrentRow?.Cells[2].Value)
            };
            var shto = new frm_Edito(_stafi, this,id,kategoria);
            shto.ShowDialog();
        }

        public int LastUpdatedNumber(int id)
        {
            var lun = string.Empty;
            var cat = _kategoriaManager.GetById(id);
            if (cat.Rows.Count > 0)
                foreach (DataRow row in cat.Rows)
                    lun = Convert.ToString(row[6]);
            var n = string.IsNullOrEmpty(lun) ? 1 : Convert.ToInt32(Convert.ToInt32(lun) + 1);
            return n;
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgv_Kategorite.CurrentRow?.Cells[0].Value);
            if (dgv_Kategorite.SelectedRows.Count != 1) return;
            if (MessageBox.Show(@"A jeni i sigurt që doni ta fshihni këtë kategori?", @"Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            _kategoriaManager.Remove(id);
            MessageBox.Show(@"Kategoria u fshi me sukses!", @"Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            LoadCategories();
            lblTotalCategories.Text = @"Total Kategori: " + _kategoriaManager.Total();
        }

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            if (txtKerko.Text.Trim().Length != 0)
            {
                dgv_Kategorite.Rows.Clear();
                try
                {
                    var dt = _kategoriaManager.Search(txtKerko.Text);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            var categoryRow = new DataGridViewRow();
                            categoryRow.CreateCells(dgv_Kategorite);
                            categoryRow.Cells[0].Value = Convert.ToInt32(row[0]);
                            categoryRow.Cells[1].Value = Convert.ToString(row[1]);
                            categoryRow.Cells[2].Value = Convert.ToString(row[2]);
                            dgv_Kategorite.Rows.Add(categoryRow);
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
                LoadCategories();
        }
    }
}

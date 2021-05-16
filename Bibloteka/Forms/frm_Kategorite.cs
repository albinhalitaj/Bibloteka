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
            if (txtEmertimi.Text.Trim().Length == 0)
                epKategorite.SetError(txtEmertimi, "Ju lutem shkruani emertimin e kategorisë!");
            else
            {
                var kategoria = new Kategoria
                {
                    Emertimi = txtEmertimi.Text,
                    Pershkrimi = txtPershkrimi.Text,
                    InsertBy = _stafi.StafiId,
                    InsertDate = DateTime.Now
                };
                _kategoriaManager.Add(kategoria);
                MessageBox.Show("Kategoria u ruajt me sukses", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadCategories();
                ClearForm();
            }
        }

        private void LoadCategories()
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
        }

        private void frm_Kategorite_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void ClearForm()
        {
            txtEmertimi.Clear();
            txtPershkrimi.Clear();
            txtEmertimi.Focus();
            epKategorite.Clear();
        }

        private void dgv_Kategorite_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Kategorite.Rows.Count <= 0) return;
            if (dgv_Kategorite.SelectedRows.Count != 1) return;
            txtEmertimi.Text = Convert.ToString(dgv_Kategorite.CurrentRow?.Cells[1].Value);
            txtPershkrimi.Text = Convert.ToString(dgv_Kategorite.CurrentRow?.Cells[2].Value);
        }

        private void btnNdrysho_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgv_Kategorite.CurrentRow?.Cells[0].Value);
            if (txtEmertimi.Text.Trim().Length == 0)
                epKategorite.SetError(txtEmertimi, "Ju lutem shkruani emertimin e kategorisë!");
            else
            {
                var kategoria = new Kategoria
                {
                    Emertimi = txtEmertimi.Text,
                    Pershkrimi = txtPershkrimi.Text,
                    Lun = LastUpdatedNumber(id),
                    Lud = DateTime.Now,
                    Lub = _stafi.StafiId
                };
                _kategoriaManager.Update(id,kategoria);
                MessageBox.Show(@"Kategoria u përditësua me sukses!", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadCategories();
                ClearForm();
            }
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
        }
    }
}

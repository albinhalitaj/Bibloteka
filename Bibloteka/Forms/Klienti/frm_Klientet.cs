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

        private void btnShto_Click(object sender, EventArgs e)
        {
            var shtoKlient = new frm_ShtoKlient(_stafi,this);
            shtoKlient.ShowDialog();
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
                    dgv_Klientet.Rows.Add(klientRow);
                }
            }
        }

        private void frm_Klientet_Load(object sender, EventArgs e)
        {
            lblTotalKlients.Text = @"Total Klientë: " + _klientiManager.Count();
            LoadKlients();
        }

        private void btnFshi_Click(object sender, EventArgs e)
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
    }
}

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

namespace Bibloteka
{
    public partial class KlientiMain : Form
    {
        private readonly LibriManager _libriManager;
        public KlientiMain()
        {
            InitializeComponent();
            _libriManager = new LibriManager();
        }

        private void KlientiMain_Load(object sender, EventArgs e)
        {
           LoadLibrat();
        }

        public void LoadLibrat()
        {
            var dt = _libriManager.Load();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow liber in dt.Rows)
                {
                    var liberRow = new DataGridViewRow();
                    liberRow.CreateCells(dgv_Librat);
                    liberRow.Cells[0].Value = Convert.ToString(liber[0]);
                    liberRow.Cells[1].Value = Convert.ToString(liber[1]);
                    liberRow.Cells[2].Value = Convert.ToString(liber[2]);
                    liberRow.Cells[3].Value = Convert.ToString(liber[4]);
                    liberRow.Cells[4].Value = Convert.ToString(liber[5]);
                    liberRow.Cells[5].Value = Convert.ToString(liber[6]);
                    liberRow.Cells[6].Value = Convert.ToString(liber[7]);
                    liberRow.Cells[7].Value = Convert.ToString(liber[8]);
                    liberRow.Cells[8].Value = Convert.ToString(liber[9]);
                    dgv_Librat.Rows.Add(liberRow);
                }
            }
        }

        private void KlientiMain_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            if (txtKerko.Text.Trim().Length != 0)
            {
                dgv_Librat.Rows.Clear();
                try
                {
                    var librat = _libriManager.Search(txtKerko.Text);
                    if (librat.Rows.Count > 0)
                    {
                        foreach (DataRow liber in librat.Rows)
                        {
                            var liberRow = new DataGridViewRow();
                            liberRow.CreateCells(dgv_Librat);
                            liberRow.Cells[0].Value = Convert.ToString(liber[0]);
                            liberRow.Cells[1].Value = Convert.ToString(liber[1]);
                            liberRow.Cells[2].Value = Convert.ToString(liber[2]);
                            liberRow.Cells[3].Value = Convert.ToString(liber[4]);
                            liberRow.Cells[4].Value = Convert.ToString(liber[5]);
                            liberRow.Cells[5].Value = Convert.ToString(liber[6]);
                            liberRow.Cells[6].Value = Convert.ToString(liber[7]);
                            liberRow.Cells[7].Value = Convert.ToString(liber[8]);
                            liberRow.Cells[8].Value = Convert.ToString(liber[9]);
                            dgv_Librat.Rows.Add(liberRow);
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
                LoadLibrat();
        }
    }
}

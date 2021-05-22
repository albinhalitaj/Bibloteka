using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteka.BusinessObjects;
using Bibloteka.Forms.Librat;

namespace Bibloteka.Forms
{
    public partial class frm_Librat : Form
    {
        private readonly Stafi _stafi;
        public frm_Librat(Stafi stafi)
        {
            _stafi = stafi;
            InitializeComponent();
        }

        private void frm_Librat_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgv_Librat);
            row.Cells[0].Value = "BK0001";
            row.Cells[1].Value = "Programimi ne c#";
            row.Cells[2].Value = "Albin Halitaj";
            row.Cells[3].Value = "Dukagjini";
            row.Cells[4].Value = "Shqip";
            row.Cells[5].Value = "Libër";
            row.Cells[6].Value = "Teknologji";
            row.Cells[7].Value = "123456789";
            row.Cells[8].Value = imageList1.Images[0];
            row.Cells[9].Value = imageList2.Images[0];
            row.Cells[10].Value = imageList2.Images[1];
            dgv_Librat.Rows.Add(row);

            var second = new DataGridViewRow();
            second.CreateCells(dgv_Librat);
            second.Cells[0].Value = "BK0001";
            second.Cells[1].Value = "Programimi ne c#";
            second.Cells[2].Value = "Albin Halitaj";
            second.Cells[3].Value = "Dukagjini";
            second.Cells[4].Value = "Shqip";
            second.Cells[5].Value = "Libër";
            second.Cells[6].Value = "Teknologji";
            second.Cells[7].Value = "123456789";
            second.Cells[8].Value = imageList1.Images[1];
            second.Cells[9].Value = imageList2.Images[0];
            second.Cells[10].Value = imageList2.Images[1];
            dgv_Librat.Rows.Add(second);
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            var frmShto = new frm_ShtoLiber(_stafi);
            frmShto.ShowDialog();
        }
    }
}

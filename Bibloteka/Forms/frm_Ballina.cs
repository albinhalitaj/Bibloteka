﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteka.BusinessObjects;

namespace Bibloteka.Forms
{
    public partial class frm_Ballina : Form
    {
        private readonly Stafi _stafi;
        public frm_Ballina(Stafi stafi)
        {
            _stafi = stafi;
            InitializeComponent();
        }

        private void frm_Ballina_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = @"Mirësevini " + string.Concat(_stafi.Emri, " ", _stafi.Mbiemri);
        }
    }
}
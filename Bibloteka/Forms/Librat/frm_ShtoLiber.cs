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

namespace Bibloteka.Forms.Librat
{
    public partial class frm_ShtoLiber : Form
    {
        private readonly KategoriaManager _kategoriaManager;
        private readonly GjuhaManager _gjuhaManager;
        private readonly FormatiManager _formatiManager;
        private readonly Stafi _stafi;
        private readonly LibriManager _libriManager;
        private readonly string _id;
        private readonly Libri _libri;
        public frm_ShtoLiber(Stafi stafi,string id,Libri libri)
        {
            _stafi = stafi;
            _id = id;
            _libri = libri;
            _formatiManager = new FormatiManager();
            _kategoriaManager = new KategoriaManager();
            _gjuhaManager = new GjuhaManager();
            _libriManager = new LibriManager();
            InitializeComponent();
        }

        private void btnAnulo_Click(object sender, EventArgs e) => Close();

        private void frm_ShtoLiber_Load(object sender, EventArgs e)
        {
            comboStatusi.SelectedIndex = 1;
            LoadComboBoxes();
            LoadCategories();
            if (string.IsNullOrEmpty(_id)) return;
            var dt = _kategoriaManager.GetById(_libri.KategoriaId);
            var kategoria = Convert.ToString(dt.Rows[0][1]);
            txtTitulli.Text = _libri.Titulli;
            txtAutori.Text = _libri.Autori;
            txtBotuesi.Text = _libri.Botuesi;
            comboGjuha.SelectedItem = _gjuhaManager.GetName(_libri.GjuhaId);
            comboTipi.SelectedItem = _formatiManager.GetName(_libri.TipiId);
            comboKategoria.SelectedItem = kategoria;
            txtISBN.Text = _libri.Isbn;
            txtEdtitioni.Text = _libri.Editioni;
            txtSasia.Value = _libri.NumriKopjeve;
            comboStatusi.SelectedIndex = Convert.ToInt32(_libri.NumriKopjeve) > 0 ? 0 : 1;
        }

        public void LoadComboBoxes()
        {
            var gjuhet = _gjuhaManager.Load();
            comboGjuha.DataSource = gjuhet;
            comboGjuha.DisplayMember = "Emertimi";
            comboGjuha.ValueMember = "GjuhaiD";

            var formatet = _formatiManager.Load();
            comboTipi.DataSource = formatet;
            comboTipi.DisplayMember = "Emri";
            comboTipi.ValueMember = "FormatiId";
            if (!string.IsNullOrEmpty(_id)) return;
            comboGjuha.SelectedIndex = 0;
            comboTipi.SelectedIndex = 0;
        }

        public void LoadCategories()
        {
            comboKategoria.Items.Add("Zgjedh Kategorinë");
            var kategorite = new List<Kategoria>();
            var dt = _kategoriaManager.Load();
            if (dt.Rows.Count > 0)
                kategorite.AddRange(from DataRow category in dt.Rows
                    select new Kategoria {Emertimi = Convert.ToString(category[1])});
            foreach (var kategoria in kategorite) comboKategoria.Items.Add(kategoria.Emertimi);
            comboKategoria.Items.Add("Shto Kategori të re...");
            comboKategoria.SelectedIndex = 1;
        }

        private void txtSasia_ValueChanged(object sender, EventArgs e) => comboStatusi.SelectedIndex = Convert.ToInt32(txtSasia.Value) > 0 ? 0 : 1;

        private void comboKategoria_Click(object sender, EventArgs e)
        {
            comboKategoria.Items.Clear();
            LoadCategories();
            comboKategoria.SelectedIndex = 1;
        }

        private void comboKategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            var totalCategories = _kategoriaManager.Total();
            if (comboKategoria.SelectedIndex == totalCategories + 1)
            {
                var frmmain = new frm_Kategorite(_stafi);
                var frmShtoKategori = new frm_Shto(frmmain, _stafi);
                if (frmShtoKategori.ShowDialog() == DialogResult.OK)
                {
                    comboKategoria.Items.Clear();
                    LoadCategories();
                    comboKategoria.SelectedIndex = totalCategories + 1;
                    comboKategoria.SelectedIndex = 1;
                }
                else
                    comboKategoria.SelectedIndex = 1;
            }
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValid()) return;
                var statusi = comboStatusi.SelectedIndex == 0;
                var libri = new Libri
                {
                    Titulli = txtTitulli.Text,
                    Autori = txtAutori.Text,
                    Botuesi = txtBotuesi.Text,
                    GjuhaId = Convert.ToInt32(comboGjuha.SelectedValue),
                    TipiId = Convert.ToInt32(comboTipi.SelectedValue),
                    KategoriaId = _kategoriaManager.GetId(Convert.ToString(comboKategoria.SelectedItem)),
                    Isbn = txtISBN.Text,
                    Editioni = txtEdtitioni.Text,
                    NumriKopjeve = txtSasia.Value,
                    Statusi = statusi
                };
                if (_id == null)
                {
                    libri.InsertBy = _stafi.StafiId;
                    libri.InsertDate = DateTime.Now;
                    _libriManager.Add(libri);
                }
                else
                {
                    libri.Lub = _stafi.StafiId;
                    libri.Lud = DateTime.Now;
                    libri.Lun = LastUpdatedNumber(_id);
                    _libriManager.Update(_id,libri);
                }
                MessageBox.Show(@"Libri u ruajt me sukses!", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Ndodhi një gabim ju lutem provoni përsëri", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public int LastUpdatedNumber(string id)
        {
            var klient = _libriManager.FindById(id);
            var lun = klient.Lun.ToString();
            var n = string.IsNullOrEmpty(lun) ? 1 : Convert.ToInt32(Convert.ToInt32(lun) + 1);
            return n;
        }

        public bool IsValid()
        {
            epLibri.Clear();
            var status = true;
            if (txtTitulli.Text.Trim().Length == 0)
            {
                epLibri.SetError(txtTitulli,"Ju lutem shkruani titullin e librit!");
                status = false;
            }
            else if (txtAutori.Text.Trim().Length == 0)
            {
                epLibri.SetError(txtAutori,"Ju lutem shkurani autorin/ët e librit");
                status = false;
            }
            else if (txtAutori.Text.Trim().Length == 0)
            {
                epLibri.SetError(txtBotuesi,"Ju lutem shkruani botuesin e librit");
                status = false;
            }
            else if (comboGjuha.SelectedIndex == -1)
            {
                epLibri.SetError(comboGjuha,"Ju lutem selektoni një gjuhë");
                status = false;
            }
            else if (comboTipi.SelectedIndex == -1)
            {
                epLibri.SetError(comboTipi,"Ju lutem selektoni një format");
                status = false;
            }
            else if (comboKategoria.SelectedIndex == 0)
            {
                epLibri.SetError(comboKategoria,"Ju lutem selektoni një kategori");
                status = false;
            }
            else if (txtISBN.Text.Trim().Length == 0)
            {
                epLibri.SetError(txtISBN,"Ju lutem shkruani ISBN-n");
                status = false;
            }
            return status;
        }
    }
}

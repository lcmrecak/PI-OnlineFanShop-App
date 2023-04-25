using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineFanShop.Entities;
using OnlineFanShop.Klase;

namespace OnlineFanShop
{
    public partial class frmDetaljiPonudeGost : Form
    {
        RepozitorijRecenzija PregledRecenzija = new RepozitorijRecenzija();
        PopisPonude dohvacenaPonuda { get; set; }
        public frmDetaljiPonudeGost(PopisPonude ponuda)
        {
            InitializeComponent();
            dohvacenaPonuda = ponuda;    
        }

        private void frmDetaljiPonudeGost_Load(object sender, EventArgs e)
        {
            dgvOcjeneKomentari.DataSource = PregledRecenzija.PregledajRecenzije(dohvacenaPonuda);
            PopuniPodatkeSelektiranePonude();

            dgvOcjeneKomentari.Columns[0].HeaderText = "Korisničko ime";
            dgvOcjeneKomentari.Columns[1].HeaderText = "Dana ocjena";
            dgvOcjeneKomentari.Columns[2].HeaderText = "Komentar na proizvod";
        }

        private void PopuniPodatkeSelektiranePonude()
        {
            txtNaziv.Text = dohvacenaPonuda.nazivProizvoda.ToString();
            txtFransiza.Text = dohvacenaPonuda.nazivFransize.ToString();
            txtVrsta.Text = dohvacenaPonuda.nazivVrste.ToString();
            txtVelicina.Text = dohvacenaPonuda.nazivVelicine.ToString();
            txtKolicina.Text = dohvacenaPonuda.kolicina.ToString();
            txtCijena.Text = dohvacenaPonuda.cijena.ToString();
            txtOcjena.Text = dohvacenaPonuda.ocjena.ToString();

            txtCijena.ReadOnly = true;
            txtFransiza.ReadOnly = true;
            txtKolicina.ReadOnly = true;
            txtNaziv.ReadOnly = true;
            txtOcjena.ReadOnly = true;
            txtVelicina.ReadOnly = true;
            txtVrsta.ReadOnly = true;
        }
    }
}

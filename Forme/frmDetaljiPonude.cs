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
    public partial class frmDetaljiPonude : Form
    {
        RepozitorijRecenzija PregledRecenzija = new RepozitorijRecenzija();
        PopisPonude dohvacenaPonuda { get; set; }
        public int id_korisnik { get; set; }
        public frmDetaljiPonude(PopisPonude ponuda, int korisnik)
        {
            InitializeComponent();
            dohvacenaPonuda = ponuda;
            id_korisnik = korisnik;
        }

        private void frmDetaljiPonude_Load(object sender, EventArgs e)
        {
            OsvjeziRecenzije();
            PopuniPodatkeSelektiranePonude();
        }

        private void OsvjeziRecenzije()
        {
            dgvOcjeneKomentari.DataSource = PregledRecenzija.PregledajRecenzije(dohvacenaPonuda);

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

        private void btnPotvrdiRecenziju_Click(object sender, EventArgs e)
        {
            if(txtUnesiKomentar.Text=="")
            {
                MessageBox.Show("Nije unesen komentar.");
                return;
            }
            if (int.Parse(txtUnesiOcjenu.Text) < 1 || int.Parse(txtUnesiOcjenu.Text) > 5)
            {
                MessageBox.Show("Ocjena nije ispravno unesena.");
                return;
            }
            string komentar = txtUnesiKomentar.Text;
            int ocjena = int.Parse(txtUnesiOcjenu.Text);

            PregledRecenzija.DodajRecenziju(ocjena, komentar, id_korisnik, dohvacenaPonuda.ID_ponuda);
            PregledRecenzija.AžurirajOcjenuPonude(ocjena, dohvacenaPonuda.ID_ponuda);

            OsvjeziRecenzije();
            txtUnesiKomentar.Clear();
            txtUnesiOcjenu.Clear();
        }
    }
}

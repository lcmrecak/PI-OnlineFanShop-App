using OnlineFanShop.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineFanShop.Forme
{
    public partial class frmUrediOdabranuPonudu : Form
    {
        PopisPonude dohvacenaPonuda { get; set; }
        public int id_korisnik { get; set; }
        RepozitorijPonuda PregledPonude = new RepozitorijPonuda();
        public frmUrediOdabranuPonudu(PopisPonude ponuda, int korisnik)
        {
            InitializeComponent();
            dohvacenaPonuda = ponuda;
            id_korisnik = korisnik;
        }

        private void frmUrediOdabranuPonudu_Load(object sender, EventArgs e)
        {
            PopuniPodatkeSelektiranePonude();
            
        }

        private void PopuniPodatkeSelektiranePonude()
        {
            
            txtNaziv.Text = dohvacenaPonuda.nazivProizvoda.ToString();
            cmbVrsta.DataSource = PregledPonude.PopuniVrstaCMB();
            cmbVrsta.DisplayMember = "nazivVrste";
            cmbVrsta.SelectedIndex = cmbVrsta.FindString(this.dohvacenaPonuda.nazivVrste);

            cmbFransiza.DataSource = PregledPonude.PopuniFransizaCMB();
            cmbFransiza.DisplayMember = "nazivFransize";
            cmbFransiza.SelectedIndex = cmbFransiza.FindString(this.dohvacenaPonuda.nazivFransize);

            cmbVelicina.DataSource = PregledPonude.PopuniVelicinaCMB();
            cmbVelicina.DisplayMember = "nazivVelicine";
            cmbVelicina.SelectedIndex = cmbVelicina.FindString(this.dohvacenaPonuda.nazivVelicine);


            txtKolicina.Text = dohvacenaPonuda.kolicina.ToString();
            numCijena.Text = dohvacenaPonuda.cijena.ToString();
        
            }

        private void frmUrediOdabranuPonudu_Load_1(object sender, EventArgs e)
        {
            PopuniPodatkeSelektiranePonude();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUrediPonudu_Click(object sender, EventArgs e)
        {
            int id_ponude = dohvacenaPonuda.ID_ponuda2;
            int kolicina = int.Parse(txtKolicina.Text);
            string naziv = txtNaziv.Text;
            string vrsta = cmbVrsta.Text;
            string fransiza = cmbFransiza.Text;
            string velicina = cmbVelicina.Text;
            double cijena = double.Parse(numCijena.Value.ToString());

            PregledPonude.UrediTablicuPonuda(id_ponude, naziv, vrsta, fransiza, velicina, kolicina, cijena);
            MessageBox.Show("Ponuda ažuirirana!");
            Close();
            

        }

        private void btnObrisiPonudu_Click(object sender, EventArgs e)
        {
            int id_ponude = dohvacenaPonuda.ID_ponuda2;

            PregledPonude.ObrisiPonudu(id_ponude);
            MessageBox.Show("Ponuda obrisana!");
            Close();
        }
    }
}

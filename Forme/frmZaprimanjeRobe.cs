using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineFanShop.Klase;
using OnlineFanShop.Entities;
using OnlineFanShop.Izvjestaji;

namespace OnlineFanShop
{
    public partial class frmZaprimanjeRobe : Form
    {
        RepozitorijSkladiste repozitorijSkladiste = new RepozitorijSkladiste();
        RepozitorijPrimka repozitorijPrimka = new RepozitorijPrimka();
        RepozitorijPonuda repozitorijPonuda = new RepozitorijPonuda();
        RepozitorijProizvod repozitorijProizvod = new RepozitorijProizvod();
        public int selektiraniProizvod { get; set; }
        public frmZaprimanjeRobe()
        {
            InitializeComponent();
        }

        private void frmZaprimanjeRobe_Load(object sender, EventArgs e)
        {
            OsvijeziDGV();
            OsvijeziCMBProizvodi();
            OsvijeziCMBSifre();

            cmbFranšiza.DataSource = repozitorijPonuda.PopuniFransizaCMB();
            cmbVeličina.DataSource = repozitorijPonuda.PopuniVelicinaCMB();
            cmbVrsta.DataSource = repozitorijPonuda.PopuniVrstaCMB();
            cmbFranšiza.DisplayMember = "nazivFransize";
            cmbVeličina.DisplayMember = "nazivVelicine";
            cmbVrsta.DisplayMember = "nazivVrste";
        }


        private void OsvijeziDGV()
        {
            dgvStanjeSkladista.DataSource = repozitorijSkladiste.DohvatiStanjeSkladista();
            btnDetalji.Enabled = false;
        }

        private void OsvijeziCMBProizvodi()
        {
            cmbNazivProizvoda.DataSource = repozitorijProizvod.DohvatiSveProizvode();
            cmbNazivProizvoda.DisplayMember = "nazivProizvoda";
        }

        private void OsvijeziCMBSifre()
        {
            cmbSifraPrimke.DataSource = repozitorijPrimka.DohvatiSvePrime();
            cmbSifraPrimke.DisplayMember = "ID_primka";
        }

        private void btnDodajPrimku_Click(object sender, EventArgs e)
        {
            if(txtImeDobavljača.Text != "") {
                repozitorijPrimka.DodajNovuPrimku(dtpDatumPrimke.Value, txtImeDobavljača.Text.ToString());
                MessageBox.Show("Primka uspješno dodana!");
                txtImeDobavljača.Clear();
                OsvijeziCMBSifre();
            }
            else { 
                MessageBox.Show("Obavezno popunite ime dobavljača!");
            }
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            string nazivProizvoda = txtNazivProizvoda.Text.ToString();
            int IDfransize = (cmbFranšiza.SelectedItem as FransizaProizvoda).ID_fransiza;
            int IDvelicine = (cmbVeličina.SelectedItem as VelicinaProizvoda).ID_velicina;
            int IDvrste = (cmbVrsta.SelectedItem as VrstaProizvoda).ID_vrsta;
            if(nazivProizvoda != "")
            {
                repozitorijProizvod.DodajNoviProizvod(nazivProizvoda, IDfransize, IDvelicine, IDvrste);
                MessageBox.Show("Uspiješno dodan novi proizvod!");
                OsvijeziCMBProizvodi();
            }
            else
            {
                MessageBox.Show("Obavezno unesite naziv Proizvoda!");
            }
            
        }

        private void btnDodajRobu_Click(object sender, EventArgs e)
        {
            int IDprimke = int.Parse(cmbSifraPrimke.Text);
            int IDproizvoda = (cmbNazivProizvoda.SelectedItem as Proizvod).ID_proizvod;
            int kolicina = int.Parse(nudKolicina.Value.ToString());
            if(nudKolicina.Value > 0)
            {
                repozitorijSkladiste.DodajProizvodUSkladište(IDprimke, IDproizvoda, kolicina);
                MessageBox.Show("Uspješno zaprimljen proizvod!");
                OsvijeziDGV();
            }
            else
            {
                MessageBox.Show("Količina mora biti veća od nule!");
            }
        }

        private void dgvStanjeSkladista_SelectionChanged(object sender, EventArgs e)
        {
            btnDetalji.Enabled = true;
            selektiraniProizvod = (dgvStanjeSkladista.CurrentRow.DataBoundItem as StanjeSkladista).IDproizvod;
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            frmDetaljiZaprimanja form = new frmDetaljiZaprimanja(selektiraniProizvod);
            form.ShowDialog();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            frmStanjeSkladistaReport izvjestaj = new frmStanjeSkladistaReport();
            izvjestaj.ShowDialog();
        }
    }
}

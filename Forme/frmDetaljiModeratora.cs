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
    public partial class frmDetaljiModeratora : Form
    {
        PopisKorisnika Korisnik = new PopisKorisnika();
        public frmDetaljiModeratora(PopisKorisnika popisKorisnika)
        {
            InitializeComponent();
            Korisnik = popisKorisnika;
        }

        private void frmDetaljiModeratora_Load(object sender, EventArgs e)
        {
            PopuniPodatkeSelektiranogKorisnika();
        }

        private void PopuniPodatkeSelektiranogKorisnika()
        {
            txtAdresa.Text = Korisnik.adresa.ToString();
            txtIdKorisnika.Text = Korisnik.ID_korisnik.ToString();
            txtIme.Text = Korisnik.ime.ToString();
            txtKorIme.Text = Korisnik.korisnickoIme.ToString();
            txtMobitel.Text = Korisnik.brojMobitela.ToString();
            txtPrezime.Text = Korisnik.prezime.ToString();

        }
    }
}

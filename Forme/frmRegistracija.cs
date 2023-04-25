using OnlineFanShop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineFanShop.Klase;

namespace OnlineFanShop.Forme
{
    public partial class frmRegistracija : Form
    {
        RepozitorjKorisnici provjeraKorisnika = new RepozitorjKorisnici();
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            string lozinkaPonovljena = txtLozinkaPonovljena.Text;
            string email = txtEmail.Text;
            string adresa = txtAdresa.Text;
            string brojMobitela = txtBrojMobitela.Text;
            int ID_uloge = 3;

            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
             
            Regex rg = new Regex(pattern);


            if (ime == "" || prezime == "" || korisnickoIme == "" || lozinka == "" || lozinkaPonovljena == "" || email == "" || adresa == "")
            {
                MessageBox.Show("Popunite sva obavezna polja!");
            }
            else
            {
                if (!rg.IsMatch(email))
                {
                    MessageBox.Show("E-mail adresa nije valjana!");
                }
                else if (lozinka != lozinkaPonovljena)
                {
                    MessageBox.Show("Greška: lozinke se ne poklapaju!");
                }
                else if (provjeraKorisnika.ProvjeraKorisnickogImena(korisnickoIme))
                {
                    MessageBox.Show("Korisnik s istim korisničkim imenom već postoji već postoji!");
                }
                else
                {
                    using (var context = new EntitiesOnlineFanShop())
                    {
                        var korisnik = new Korisnik
                        {
                            ime = ime,
                            prezime = prezime,
                            korisnickoIme = korisnickoIme,
                            lozinka = lozinka,
                            email = email,
                            adresa = adresa,
                            brojMobitela = brojMobitela,
                            ID_uloga_FK = ID_uloge
                        };

                        context.Korisnik.Add(korisnik);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Registracija uspješna!");
                    Close();
                }
            }
        }
    }
}

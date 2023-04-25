using OnlineFanShop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineFanShop
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorime.Text;
            string lozinka = txtLozinka.Text;

            using (var context = new EntitiesOnlineFanShop())
            {
                var user = context.Korisnik.FirstOrDefault(u => u.korisnickoIme == korisnickoIme);

                if(user != null)
                {
                    if(user.lozinka == lozinka)
                    {
                        if(user.ID_uloga_FK == 1)
                        {
                            frmPocetnaAdmin form = new frmPocetnaAdmin(korisnickoIme, user.ID_korisnik);
                            Hide();
                            form.ShowDialog();
                            Close();
                        }
                        else if (user.ID_uloga_FK == 2)
                        {
                            frmPocetnaModerator form = new frmPocetnaModerator(korisnickoIme, user.ID_korisnik);
                            Hide();
                            form.ShowDialog();
                            Close();
                        }
                        else if (user.ID_uloga_FK == 3)
                        {
                            frmPocetnaKorisnik form = new frmPocetnaKorisnik(korisnickoIme, user.ID_korisnik);
                            Hide();
                            form.ShowDialog();
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pogrešna lozinka!");
                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji korisnik s ovim korisničkim imenom!");
                }
            }
        }
        private void SkrivanjeLozinke()
        {
            
            txtLozinka.Text = "";
            txtLozinka.PasswordChar = '*';

        }


    }
}

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

namespace OnlineFanShop
{
    public partial class frmListaZelja : Form
    {
        RepozitorijListaZelja repozitorijListaZelja = new RepozitorijListaZelja();
        RepozitorjKorisnici repozitorjKorisnici = new RepozitorjKorisnici();
        public int IDkorisnik { get; set; }
        public frmListaZelja(int ID_korisnik)
        {
            IDkorisnik = ID_korisnik;
            InitializeComponent();
        }

        private void frmListaZelja_Load(object sender, EventArgs e)
        {
            OsvijeziFormu();
        }

        private void OsvijeziFormu()
        {
            btnObrisi.Enabled = true;
            List<PopisListaZelja> dohvacenaListaZelja = repozitorijListaZelja.DohvatiListuZeljaZaKoriniska(IDkorisnik);
            dgvListaZelja.DataSource = dohvacenaListaZelja;
            dgvListaZelja.Columns["id_ponuda"].Visible = false;

            dgvListaZelja.Columns[1].HeaderText = "Naziv proizvoda";
            dgvListaZelja.Columns[2].HeaderText = "Velicina";
            dgvListaZelja.Columns[3].HeaderText = "Franšiza";
            dgvListaZelja.Columns[4].HeaderText = "Datum odabira";
            dgvListaZelja.Columns[5].HeaderText = "Cijena (HRK)";

            if (repozitorjKorisnici.KorisnikZeliObavijesti(IDkorisnik))
            {
                cbObavijesti.Checked = true;
                btnSpremiPromjene.Enabled = false;
            }
            else
            {
                cbObavijesti.Checked = false;
                btnSpremiPromjene.Enabled = false;
            }
        }

        private void cbObavijesti_CheckedChanged(object sender, EventArgs e)
        {
            btnSpremiPromjene.Enabled = true;
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            repozitorjKorisnici.AzurirajObavijestiZaKorisnika(IDkorisnik, cbObavijesti.Checked);
            OsvijeziFormu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int id_ponuda = (dgvListaZelja.CurrentRow.DataBoundItem as PopisListaZelja).id_ponuda;
            repozitorijListaZelja.ObrisiSListeZelja(IDkorisnik, id_ponuda);
            OsvijeziFormu();
        }
    }
}

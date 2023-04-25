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
using System.Net;
using System.Net.Mail;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Reporting.WinForms;
using OnlineFanShop.Forme;

namespace OnlineFanShop
{
    public partial class frmKosarica : Form
    {
        RepozitorijKosarica repozitorijKosarica = new RepozitorijKosarica();
        public int korisnik { get; set; }
        public frmKosarica(int korisnikID)
        {
            korisnik = korisnikID;
            InitializeComponent();
        }

        private void frmKosarica_Load(object sender, EventArgs e)
        {
            OsvijeziKosaricu();
            if (dgvKosarica.Rows.Count > 0)
            {
                btnFanKviz.Enabled = true;
                btnDovrsiKupnju.Enabled = true;
            }
            else
            {
                btnFanKviz.Enabled = false;
                btnDovrsiKupnju.Enabled = false;
            }
        }
        private void OsvijeziKosaricu()
        {
            dgvKosarica.DataSource = repozitorijKosarica.DohvatiSadrzajKosarice(korisnik);
            dgvKosarica.Columns["ID_korisnik"].Visible = false;
            dgvKosarica.Columns["ID_ponuda"].Visible = false;
            dgvKosarica.Columns["popust"].Visible = false;
            dgvKosarica.Columns["naziv"].HeaderText = "Naziv proizvoda";
            dgvKosarica.Columns["kolicina"].HeaderText = "Količina";
            dgvKosarica.Columns["cijena"].HeaderText = "Cijena";
           
            double ukupanIznos = 0;
            double popust = 0;
            double konacniIznos = 0;
            for(int i = 0; i < dgvKosarica.Rows.Count; ++i)
            {
                ukupanIznos += Convert.ToDouble(dgvKosarica.Rows[i].Cells[5].Value);
            }
            txtUkupanIznos.Text = ukupanIznos.ToString();
            for (int i = 0; i < dgvKosarica.Rows.Count; ++i)
            {
                if (Convert.ToDouble(dgvKosarica.Rows[i].Cells[4].Value) == 10)
                {
                    popust = 0.1;
                    txtPopust.Text = "10 %";
                }
                else
                {
                    txtPopust.Text = "0 %";
                }
            }

            konacniIznos = ukupanIznos - (ukupanIznos * popust);
            txtKonacniIznos.Text = konacniIznos.ToString();

        }

        private void btnFanKviz_Click(object sender, EventArgs e)
        {
                PopisKosarica odabranaStavka = dgvKosarica.CurrentRow.DataBoundItem as PopisKosarica;
                frmFanKviz form = new frmFanKviz(repozitorijKosarica.DohvatiFransizuProizvodaIzKosarice(odabranaStavka), korisnik);
                form.ShowDialog();
                OsvijeziKosaricu();
                btnFanKviz.Enabled = false;
        }

        private void btnDovrsiKupnju_Click(object sender, EventArgs e)
        {
 


            if (korisnik < 1)
            {
                MessageBox.Show("Niste prijavljeni, prijavite se ili registrirajte!");
            }
            else
            {
                DialogResult potvrdaKupnje = MessageBox.Show("Želite li završiti kupnju?", "Potvrda kupnje", MessageBoxButtons.YesNo);
                if (potvrdaKupnje == DialogResult.Yes)
                {
                    KosaricaReport form = new KosaricaReport(korisnik);
                    form.ShowDialog();
                    repozitorijKosarica.IsprazniKosaricu(korisnik);
                    Close();
                    
                  

                }
                else if (potvrdaKupnje == DialogResult.No)
                {
                }
            }
        }

        private void btnMakniProizvod_Click(object sender, EventArgs e)
        {
            int selektiranaPonuda = (dgvKosarica.CurrentRow.DataBoundItem as PopisKosarica).ID_ponuda;
            int? selektiranaPonudaKolicina = (dgvKosarica.CurrentRow.DataBoundItem as PopisKosarica).kolicina;
            int id_korisnik = korisnik;
            int kolicina = int.Parse(numKolicina.Value.ToString());

            if (kolicina == selektiranaPonudaKolicina)
            {
                repozitorijKosarica.MakniIzKosarice(id_korisnik, selektiranaPonuda, kolicina);
                MessageBox.Show("Proizvod maknut iz košarice!");
                OsvijeziKosaricu();
                
            }
            else if(kolicina < selektiranaPonudaKolicina)
            {
                repozitorijKosarica.SmanjiKolicinu(id_korisnik, selektiranaPonuda, kolicina);
                OsvijeziKosaricu();
            }
            else
            {
                MessageBox.Show("Prevelika količina!");
            }
            

        }

        private void dgvKosarica_SelectionChanged(object sender, EventArgs e)
        {
            txtOdabraniProizvod.Text = dgvKosarica.CurrentRow.Cells["naziv"].Value.ToString();
        }
    }
}

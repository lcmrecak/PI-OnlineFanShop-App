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
    public partial class frmFanKviz : Form
    {
        RepozitorijFanKviz repozitorijFanKviz = new RepozitorijFanKviz();
        RepozitorijKosarica repozitorijKosarica = new RepozitorijKosarica();
        public int fransiza { get; set; }
        public int korisnik { get; set; }
        public frmFanKviz(int fransizaKviza, int korisnikID)
        {
            korisnik = korisnikID;
            fransiza = fransizaKviza;
            InitializeComponent();
        }

        private void frmFanKviz_Load(object sender, EventArgs e)
        {
            List<FanKviz> setPitanjaOdgovori = repozitorijFanKviz.DohvatiPitanjaZaFransizu(fransiza);
            PopuniPitanjaITocneOdgovore(setPitanjaOdgovori);
            List<FanKviz> setOstalihPitanjaOdgovora = repozitorijFanKviz.DohvatiOstalaPitanja(fransiza);
            PopuniNetocneOdgovore(setOstalihPitanjaOdgovora);
        }
        private void btnPredajOdgovore_Click(object sender, EventArgs e)
        {
            bool uspjesnoRijeseno = ProvjeriTočnost();
            if (uspjesnoRijeseno)
            {
                repozitorijKosarica.DodajPopust(korisnik);
            }
            else MessageBox.Show("Neuspješno riješen kviz!");
            Close();
        }
        public void PopuniPitanjaITocneOdgovore(List<FanKviz> lista)
        {
            int i = 1;
            foreach (FanKviz item in lista)
            {
                if (i == 1)
                {
                    txtPitanje1.Text = item.pitanje.ToString();
                    rbPitanje1Odgovor2.Text = item.odgovor.ToString();
                }
                if (i == 2)
                {
                    txtPitanje2.Text = item.pitanje.ToString();
                    rbPitanje2Odgovor1.Text = item.odgovor.ToString();
                }
                if (i == 3)
                {
                    txtPitanje3.Text = item.pitanje.ToString();
                    rbPitanje3Odgovor3.Text = item.odgovor.ToString();
                }
                i++;
            }
        }

        public void PopuniNetocneOdgovore(List<FanKviz> lista)
        {
            int i = 1;
            foreach (FanKviz item in lista)
            {
                if (i == 1)
                {
                    rbPitanje1Odgovor1.Text = item.odgovor.ToString();
                }
                if (i == 2)
                {
                    rbPitanje1Odgovor3.Text = item.odgovor.ToString();
                }
                if (i == 3)
                {
                    rbPitanje2Odgovor2.Text = item.odgovor.ToString();
                }
                if (i == 4)
                {
                    rbPitanje2Odgovor3.Text = item.odgovor.ToString();
                }
                if (i == 5)
                {
                    rbPitanje3Odgovor1.Text = item.odgovor.ToString();
                }
                if (i == 6)
                {
                    rbPitanje3Odgovor2.Text = item.odgovor.ToString();
                }
                i++;
            }
        }

        public bool ProvjeriTočnost()
        {
            string prvoPitanje = txtPitanje1.Text.ToString();
            string drugoPitanje = txtPitanje2.Text.ToString();
            string trecePitanje = txtPitanje3.Text.ToString();
            string prviOdgovor = panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text.ToString();
            string drugiOdgovor = panel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text.ToString();
            string treciOdgovor = panel3.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text.ToString();
            if (repozitorijFanKviz.ProvjeriTočnostOdgovora(prvoPitanje, prviOdgovor) &&
                repozitorijFanKviz.ProvjeriTočnostOdgovora(drugoPitanje, drugiOdgovor) &&
                repozitorijFanKviz.ProvjeriTočnostOdgovora(trecePitanje, treciOdgovor))
            {
                return true;
            }
            else return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

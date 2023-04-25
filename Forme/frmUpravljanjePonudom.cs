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
    public partial class frmUpravljanjePonudom : Form
    {
        RepozitorijProizvod PregledProizvoda = new RepozitorijProizvod();
        RepozitorijPonuda PregledPonude = new RepozitorijPonuda();
        public frmUpravljanjePonudom()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
            OsvjeziPopisPonude();
        }

        private void frmDodajProizvod_Load(object sender, EventArgs e)
        {
            OsvjeziPopisPonude();

            cmbNazivProizvoda.DataSource = PregledProizvoda.DohvatiSveProizvode();
            cmbNazivProizvoda.DisplayMember = "nazivProizvoda";

        }

        private void OsvjeziPopisPonude()
        {
            dgvPonuda.DataSource = PregledPonude.PopuniPonudaDGV();
            dgvPonuda.Columns["ID_ponuda"].Visible = false;
            dgvPonuda.Columns["ID_ponuda2"].Visible = false;

            dgvPonuda.Columns[1].HeaderText = "Naziv proizvoda";
            dgvPonuda.Columns[2].HeaderText = "Vrsta proizvoda";
            dgvPonuda.Columns[3].HeaderText = "Franšiza proizvoda";
            dgvPonuda.Columns[4].HeaderText = "Veličina";
            dgvPonuda.Columns[5].HeaderText = "Ocjena";
            dgvPonuda.Columns[6].HeaderText = "Količina";
            dgvPonuda.Columns[7].HeaderText = "Cijena (HRK)";
        }

        private void btnDodajPonudu_Click(object sender, EventArgs e)
        {
            string naziv = cmbNazivProizvoda.Text;
            int kolicina = int.Parse(numKolicina.Value.ToString());
            double cijena = double.Parse(numCijena.Value.ToString());

            PregledPonude.DodajPonudu(naziv, kolicina, cijena);
            OsvjeziPopisPonude();

        }
    }
}

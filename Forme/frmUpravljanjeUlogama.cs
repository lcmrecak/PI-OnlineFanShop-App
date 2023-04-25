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

namespace OnlineFanShop
{
    public partial class frmUpravljanjeUlogama : Form
    {
        RepozitorjKorisnici Korisnici = new RepozitorjKorisnici();

        PopisKorisnika popisKorisnika = new PopisKorisnika();
        PopisKorisnika popisModeratora = new PopisKorisnika();

        public frmUpravljanjeUlogama()
        {
            InitializeComponent();
        }


        private void frmUpravljanjeUlogama_Load(object sender, EventArgs e)
        {
            RefreshDGV();
            RefreshGumbe();
        }

        private void RefreshDGV()
        {
            dgvKorisnici.DataSource = Korisnici.PopuniDGVKorisnik();
            dgvKorisnici.Columns["nazivUloge"].Visible = false;
            dgvKorisnici.Columns["ID_korisnik"].Visible = false;
            dgvKorisnici.Columns["brojMobitela"].Visible = false;
            dgvKorisnici.Columns["adresa"].Visible = false;

            dgvModeratori.DataSource = Korisnici.PopuniDGVModerator();
            dgvModeratori.Columns["nazivUloge"].Visible = false;
            dgvModeratori.Columns["ID_korisnik"].Visible = false;
            dgvModeratori.Columns["brojMobitela"].Visible = false;
            dgvModeratori.Columns["adresa"].Visible = false;
        }

        private void RefreshGumbe()
        {
            btnDodajModeratora.Enabled = false;
            btnUkloniModeratora.Enabled = false;
            btnDetaljiKorisnika.Enabled = false;
            btnDetaljiModeratora.Enabled = false;
        }

        private void dgvKorisnici_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count != 0)
            {
                btnDodajModeratora.Enabled = true;
                btnDetaljiKorisnika.Enabled = true;
                if (dgvModeratori.SelectedRows.Count != 0)
                {
                    dgvModeratori.ClearSelection();
                }
            }
        }

        private void dgvModeratori_SelectionChanged(object sender, EventArgs e)
        {
            btnUkloniModeratora.Enabled = true;
            btnDetaljiModeratora.Enabled = true;
            if (dgvKorisnici.SelectedRows.Count != 0)
            {
                dgvKorisnici.ClearSelection();
            }
        }

        private void btnDodajModeratora_Click(object sender, EventArgs e)
        {
            int id_uloga = 2;
            popisKorisnika = dgvKorisnici.CurrentRow.DataBoundItem as PopisKorisnika;
            Korisnici.DodajModeratora(popisKorisnika.ID_korisnik, id_uloga);
            RefreshDGV();
            RefreshGumbe();
        }

        private void btnUkloniModeratora_Click(object sender, EventArgs e)
        {
            int id_uloga = 3;
            popisKorisnika = dgvModeratori.CurrentRow.DataBoundItem as PopisKorisnika;
            Korisnici.DodajModeratora(popisKorisnika.ID_korisnik, id_uloga);
            RefreshDGV();
            RefreshGumbe();
        }

        private void btnDetaljiKorisnika_Click(object sender, EventArgs e)
        {
            popisKorisnika = dgvKorisnici.CurrentRow.DataBoundItem as PopisKorisnika;
            frmDetaljiKorisnika form = new frmDetaljiKorisnika(popisKorisnika);
            form.ShowDialog();
            RefreshGumbe();
        }

        private void btnDetaljiModeratora_Click(object sender, EventArgs e)
        {
            popisKorisnika = dgvModeratori.CurrentRow.DataBoundItem as PopisKorisnika;
            frmDetaljiModeratora form = new frmDetaljiModeratora(popisKorisnika);
            form.ShowDialog();
            RefreshGumbe();
        }

    }
}

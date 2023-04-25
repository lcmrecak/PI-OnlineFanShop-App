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
    public partial class frmDetaljiZaprimanja : Form
    {
        RepozitorijSkladiste repozitorijSkladiste = new RepozitorijSkladiste();
        public int IDproizvoda { get; set; }
        public frmDetaljiZaprimanja(int proizvodID)
        {
            IDproizvoda = proizvodID;
            InitializeComponent();
        }

        private void frmDetaljiZaprimanja_Load(object sender, EventArgs e)
        {
            dgvDetalji.DataSource = repozitorijSkladiste.DohvatiZapriamanjaZaProizvod(IDproizvoda);
        }
    }
}

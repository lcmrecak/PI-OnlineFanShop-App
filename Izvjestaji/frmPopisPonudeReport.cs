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

namespace OnlineFanShop.Izvjestaji
{
    public partial class frmPopisPonudeReport : Form
    {
        public frmPopisPonudeReport()
        {
            InitializeComponent();
        }

        private void frmPopisPonudeReport_Load(object sender, EventArgs e)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from ponuda in context.Ponuda
                            from proizvod in context.Proizvod
                            from vrsta in context.VrstaProizvoda
                            from fransiza in context.FransizaProizvoda
                            from velicina in context.VelicinaProizvoda
                            where ponuda.ID_proizvod_FK == proizvod.ID_proizvod
                            && proizvod.ID_fransiza_FK == fransiza.ID_fransiza
                            && proizvod.ID_velicina_FK == velicina.ID_velicina
                            && proizvod.ID_vrsta_FK == vrsta.ID_vrsta
                            select new PopisPonude
                            {
                                ID_ponuda = proizvod.ID_proizvod,
                                nazivProizvoda = proizvod.nazivProizvoda,
                                nazivVrste = vrsta.nazivVrste,
                                nazivFransize = fransiza.nazivFransize,
                                nazivVelicine = velicina.nazivVelicine,
                                ocjena = ponuda.ocjena,
                                kolicina = ponuda.kolicina,
                                cijena = ponuda.cijena
                            };

                List<PopisPonude> popisPonude = new List<PopisPonude>();
                popisPonude = query.ToList();
                PopisPonudeBindingSource.DataSource = popisPonude;
            }
            this.reportViewer1.RefreshReport();
        }
    }
}

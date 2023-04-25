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

namespace OnlineFanShop.Izvjestaji
{
    public partial class frmStanjeSkladistaReport : Form
    {
        StanjeSkladista stanjeSkladista = new StanjeSkladista();
        public frmStanjeSkladistaReport()
        {
            InitializeComponent();
        }

        private void frmStanjeSkladistaReport_Load(object sender, EventArgs e)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = (from s in context.Skladiste
                             join p in context.Proizvod
                            on s.ID_proizvod equals p.ID_proizvod
                             group s by s.ID_proizvod into g
                             select new
                             {
                                 IDproizvod = g.Key,
                                 kolicina = g.Sum(x => x.kolicina)
                             }).ToList().Select(x => new StanjeSkladista
                             {
                                 IDproizvod = x.IDproizvod,
                                 kolicina = x.kolicina
                             }).ToList();

                var query2 = from p in context.Proizvod
                             from v in context.VelicinaProizvoda
                             where p.ID_velicina_FK == v.ID_velicina
                             select new
                             {
                                 p.ID_proizvod,
                                 p.nazivProizvoda,
                                 v.nazivVelicine
                             };


                var query3 = from q in query
                             from q2 in query2
                             where q.IDproizvod == q2.ID_proizvod
                             select new StanjeSkladista
                             {
                                 IDproizvod = q.IDproizvod,
                                 nazivProizoda = q2.nazivProizvoda,
                                 velicina = q2.nazivVelicine,
                                 kolicina = q.kolicina
                             };
                List<StanjeSkladista> stanjeSkladista = new List<StanjeSkladista>();
                stanjeSkladista = query3.ToList();
                StanjeSkladistaBindingSource.DataSource = stanjeSkladista;
            }
            this.reportViewer1.RefreshReport();
        }
    }
}

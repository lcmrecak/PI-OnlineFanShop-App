using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFanShop.Entities;

namespace OnlineFanShop.Klase
{
    public class RepozitorijFanKviz
    {
        public List<FanKviz> DohvatiPitanjaZaFransizu(int fransiza)
        {
            using(var context = new EntitiesOnlineFanShop())
            {
                var query = from f in context.FanKviz
                            where f.ID_fransiza_FK == fransiza
                            select f;

                List<FanKviz> listaPitanja = new List<FanKviz>();
                listaPitanja = query.ToList();
                return listaPitanja;
            }
        }

        public List<FanKviz> DohvatiOstalaPitanja(int fransiza)
        {
            using(var context = new EntitiesOnlineFanShop())
            {
                var query = from f in context.FanKviz
                            where f.ID_fransiza_FK != fransiza
                            select f;
                List<FanKviz> netocniOdgovori = new List<FanKviz>();
                netocniOdgovori = query.ToList();
                return netocniOdgovori;
            }
        }

        public bool ProvjeriTočnostOdgovora(string pitanje, string odgovor)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from f in context.FanKviz
                            where f.pitanje == pitanje
                            select f.odgovor;
                if (query.Single().ToString() == odgovor)
                    return true;
                else return false;
            }
        }
    }
}

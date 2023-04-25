using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFanShop.Entities;

namespace OnlineFanShop.Klase
{
    public class RepozitorijProizvod
    {
        public void DodajNoviProizvod(string naziv, int fransiza, int velicina, int vrsta)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                Proizvod proizvod = new Proizvod()
                {
                    nazivProizvoda = naziv,
                    ID_fransiza_FK = fransiza,
                    ID_velicina_FK = velicina,
                    ID_vrsta_FK = vrsta

                };

                context.Proizvod.Add(proizvod);
                context.SaveChanges();
            }
        }

        public List<Proizvod> DohvatiSveProizvode()
        {
            using(var context = new EntitiesOnlineFanShop())
            {
                var query = from p in context.Proizvod
                            select p;

                List<Proizvod> proizvodi = new List<Proizvod>();
                proizvodi = query.ToList();
                return proizvodi;
            }
        }

        public void DodajProizvod(string naziv, string vrsta, string fransiza, string velicina)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                int id_vrsta = 0;
                int id_fransiza = 0;
                int id_velicina = 0;

                var queryVrsta = from v in context.VrstaProizvoda
                                 where v.nazivVrste == vrsta
                                 select v.ID_vrsta;
                id_vrsta = queryVrsta.Single();

                var queryFransiza = from f in context.FransizaProizvoda
                                    where f.nazivFransize == fransiza
                                    select f.ID_fransiza;
                id_fransiza = queryFransiza.Single();

                var queryVelicina = from v in context.VelicinaProizvoda
                                    where v.nazivVelicine == velicina
                                    select v.ID_velicina;
                id_velicina = queryVelicina.Single();

                    Proizvod proizvod = new Proizvod()
                    {
                        nazivProizvoda = naziv,
                        ID_vrsta_FK = id_vrsta,
                        ID_fransiza_FK = id_fransiza,
                        ID_velicina_FK = id_velicina
                    };

                    context.Proizvod.Add(proizvod);

                    context.SaveChanges();
                }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFanShop.Entities;
using OnlineFanShop.Klase;

namespace OnlineFanShop.Klase
{
    public class RepozitorijSkladiste
    {
        public List<StanjeSkladista> DohvatiStanjeSkladista()
        {
            using(var context = new EntitiesOnlineFanShop())
            {
                var query = (from s in context.Skladiste
                             join p in context.Proizvod
                            on s.ID_proizvod equals p.ID_proizvod
                            group s by s.ID_proizvod into g
                            select new
                            {
                                IDproizvod = g.Key,
                                kolicina = g.Sum(x => x.kolicina)
                            }).ToList().Select(x=> new StanjeSkladista
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
                List < StanjeSkladista > stanjeSkladista = new List<StanjeSkladista>();
                stanjeSkladista = query3.ToList();
                return stanjeSkladista;
            }
        }

        public List<DetaljiZaprimanja> DohvatiZapriamanjaZaProizvod(int proizvod)
        {
            using(var context = new EntitiesOnlineFanShop())
            {
                var query = from s in context.Skladiste
                            from p in context.Proizvod
                            from v in context.VelicinaProizvoda
                            from pr in context.Primka
                            where s.ID_proizvod == proizvod
                            where s.ID_proizvod == p.ID_proizvod
                            where v.ID_velicina == p.ID_velicina_FK
                            where s.ID_primka == pr.ID_primka
                            select new DetaljiZaprimanja
                            {
                                sifraProizvoda = proizvod,
                                nazivProizvoda = p.nazivProizvoda,
                                velicinaProizvoda = v.nazivVelicine,
                                sifraPrimke = pr.ID_primka,
                                imeDobavljaca = pr.imeDobavljaca,
                                datumZaprimanja = pr.datum,
                                kolicina = s.kolicina
                            };
                List<DetaljiZaprimanja> detaljiZaprimanja = new List<DetaljiZaprimanja>();
                detaljiZaprimanja = query.ToList();
                return detaljiZaprimanja;
            }
        }

        public void DodajProizvodUSkladište(int primka, int proizvod, int kolicina)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                Skladiste skladiste = new Skladiste()
                {
                    ID_primka = primka,
                    ID_proizvod = proizvod,
                    kolicina = kolicina

                };
                context.Skladiste.Add(skladiste);
                context.SaveChanges();
            }
        }
    }
}

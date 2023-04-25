using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFanShop.Entities;

namespace OnlineFanShop.Klase
{
    public class RepozitorijKosarica
    {
        public RepozitorijKosarica()
        {

        }

        public List<PopisKosarica> DohvatiSadrzajKosarice(int korisnikID)
        {
            using(var context = new EntitiesOnlineFanShop())
            {
                var query = from k in context.Kosarica
                            from p in context.Ponuda
                            from pr in context.Proizvod
                            where k.ID_korisnik == korisnikID
                            && k.ID_ponuda == p.ID_ponuda
                            && p.ID_proizvod_FK == pr.ID_proizvod
                            select new PopisKosarica
                            {
                                ID_korisnik = k.ID_korisnik,
                                ID_ponuda = k.ID_ponuda,
                                naziv = pr.nazivProizvoda,
                                kolicina = k.kolicina,
                                popust = k.popust,
                                cijena = p.cijena*k.kolicina
                            };
                List<PopisKosarica> sadrzajKosarice = new List<PopisKosarica>();
                sadrzajKosarice = query.ToList();
                return sadrzajKosarice;
            }
        }

        public int DohvatiFransizuProizvodaIzKosarice(PopisKosarica selektiraniRedak)
        {
            int ponudaID = selektiraniRedak.ID_ponuda;

            using(var context = new EntitiesOnlineFanShop())
            {
                var query = from pon in context.Ponuda
                            from pro in context.Proizvod
                            where pon.ID_proizvod_FK == pro.ID_proizvod
                            where pon.ID_ponuda == ponudaID
                            select pro.ID_fransiza_FK;

                return query.Single();
            }
        }

        public void DodajUKosaricu(int korisnik, int ponuda, int kolicina)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                Kosarica kosarica = new Kosarica()
                {
                    ID_korisnik = korisnik,
                    ID_ponuda = ponuda,
                    kolicina = kolicina,
                    popust = 0
                };

                var query = from p in context.Ponuda
                                     where p.ID_ponuda == ponuda
                                     select p;


                Ponuda smanjiKolicinu = query.Single();
                smanjiKolicinu.kolicina = smanjiKolicinu.kolicina - kolicina;

                context.Kosarica.Add(kosarica);

                context.SaveChanges();
            }
        }

        public void PovecajKolicinu(int korisnik, int ponuda, int kolicina)
        {
            if (korisnik > 0)
            {
                using (var context = new EntitiesOnlineFanShop())
                {
                    var query = from k in context.Kosarica
                                where k.ID_korisnik == korisnik
                                where k.ID_ponuda == ponuda
                                select k;

                    Kosarica povecajKolicinu = query.Single();
                    povecajKolicinu.kolicina = povecajKolicinu.kolicina + kolicina;

                    var query2 = from p in context.Ponuda
                                 where p.ID_ponuda == ponuda
                                 select p;


                    Ponuda smanjiKolicinu = query2.Single();
                    smanjiKolicinu.kolicina = smanjiKolicinu.kolicina - kolicina;

                    context.SaveChanges();

                }
            }
        }

        public void MakniIzKosarice(int korisnik, int ponuda, int kolicina)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var proizvodZaMaknuti = context.Kosarica.FirstOrDefault(x => x.ID_ponuda == ponuda);
                context.Kosarica.Remove(proizvodZaMaknuti);
                
                var query = from p in context.Ponuda
                             where p.ID_ponuda == ponuda
                             select p;

                
                Ponuda povecajKolicinu = query.Single();
                povecajKolicinu.kolicina = povecajKolicinu.kolicina + kolicina;
                
                context.SaveChanges();
            }
        }

        public void SmanjiKolicinu(int korisnik, int ponuda, int kolicina)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from k in context.Kosarica
                            where k.ID_korisnik == korisnik
                            where k.ID_ponuda == ponuda
                            select k;

                Kosarica smanjiKolicinu = query.Single();
                smanjiKolicinu.kolicina = smanjiKolicinu.kolicina - kolicina;

                var query2 = from p in context.Ponuda
                             where p.ID_ponuda == ponuda
                             select p;


                Ponuda povecajKolicinu = query2.Single();
                povecajKolicinu.kolicina = povecajKolicinu.kolicina + kolicina;

                context.SaveChanges();

            }
        }

        public void IsprazniKosaricu(int korisnik)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var kosarica = from k in context.Kosarica
                               where k.ID_korisnik == korisnik
                               select k;

                foreach (var proizvod in kosarica)
                {
                    context.Kosarica.Remove(proizvod);
                }

                context.SaveChanges();
            }

        }

        internal void DodajPopust(int korisnikID)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from k in context.Kosarica
                            where k.ID_korisnik == korisnikID
                            select k;
                foreach (var item in query)
                {
                    item.popust = 10;
                }
                context.SaveChanges();
            }
        }
    }
}

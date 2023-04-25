using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFanShop.Entities;
using OnlineFanShop.Klase;

namespace OnlineFanShop.Klase
{
    public class RepozitorjKorisnici
    {
        public List<PopisKorisnika> PopuniDGVKorisnik()
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from korisnik in context.Korisnik
                            from uloga in context.UlogaKorisnika
                            where korisnik.ID_uloga_FK == 3
                            && korisnik.ID_uloga_FK == uloga.ID_uloga
                            select new PopisKorisnika
                            {
                                ID_korisnik = korisnik.ID_korisnik,
                                korisnickoIme = korisnik.korisnickoIme,
                                ime = korisnik.ime,
                                prezime = korisnik.prezime,
                                brojMobitela = korisnik.brojMobitela,
                                adresa = korisnik.adresa,
                                nazivUloge = uloga.nazivUloge
                            };

                List<PopisKorisnika> popisKorisnika = new List<PopisKorisnika>();
                popisKorisnika = query.ToList();
                return popisKorisnika;
            }
        }
        
        public List<PopisKorisnika> PopuniDGVModerator()
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from korisnik in context.Korisnik
                            from uloga in context.UlogaKorisnika
                            where korisnik.ID_uloga_FK == 2
                            && korisnik.ID_uloga_FK == uloga.ID_uloga
                            select new PopisKorisnika
                            {
                                ID_korisnik = korisnik.ID_korisnik,
                                korisnickoIme = korisnik.korisnickoIme,
                                ime = korisnik.ime,
                                prezime = korisnik.prezime,
                                brojMobitela = korisnik.brojMobitela,
                                adresa = korisnik.adresa,
                                nazivUloge = uloga.nazivUloge
                            };

                List<PopisKorisnika> popisModeratora = new List<PopisKorisnika>();
                popisModeratora = query.ToList();
                return popisModeratora;
            }
        }

        public void DodajModeratora(int id_korisnika, int id_uloge)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from korisnik in context.Korisnik
                            where korisnik.ID_korisnik == id_korisnika
                            select korisnik;

                Korisnik selektiraniKorisnik = query.Single();
                selektiraniKorisnik.ID_uloga_FK = id_uloge;

                context.SaveChanges();
            }
        }

        public void UkloniModeratora(int id_korisnika, int id_uloge)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from korisnik in context.Korisnik
                            where korisnik.ID_korisnik == id_korisnika
                            select korisnik;

                Korisnik selektiraniKorisnik = query.Single();
                selektiraniKorisnik.ID_uloga_FK = id_uloge;

                context.SaveChanges();
            }
        }

        public bool KorisnikZeliObavijesti(int id_korisnika)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from k in context.Korisnik
                            where k.ID_korisnik == id_korisnika
                            select k.obavijest;

                return query.Single();
            }
        }

        public void AzurirajObavijestiZaKorisnika(int id_korisnika, bool obavijesti)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from k in context.Korisnik
                            where k.ID_korisnik == id_korisnika
                            select k;
                foreach (var item in query)
                {
                    item.obavijest = obavijesti;
                }
                context.SaveChanges();
            }
        }

        public bool ProvjeraKorisnickogImena(string korisnickoIme)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var user = context.Korisnik.FirstOrDefault(u => u.korisnickoIme == korisnickoIme);

                if (user != null)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}

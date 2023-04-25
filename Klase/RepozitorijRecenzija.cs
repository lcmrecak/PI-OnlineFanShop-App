using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFanShop.Entities;

namespace OnlineFanShop.Klase
{
    public class RepozitorijRecenzija
    {
        public List<PopisRecenzija> PregledajRecenzije(PopisPonude selektiranaPonuda)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from recenzija in context.RecenzijaProizvoda
                            from korisnik in context.Korisnik
                            where recenzija.ID_ponuda_FK == selektiranaPonuda.ID_ponuda
                            where korisnik.ID_korisnik == recenzija.ID_korisnik_FK
                            select new PopisRecenzija
                            { 
                                korisnickoIme = korisnik.korisnickoIme,
                                ocjena = recenzija.ocjena,
                                komentar = recenzija.komentar
                            };

                List<PopisRecenzija> popisRecenzija = new List<PopisRecenzija>();
                popisRecenzija = query.ToList();
                return popisRecenzija;
            }
        }

        public void DodajRecenziju(int ocjena, string komentar, int id_korisnik, int id_ponude)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                RecenzijaProizvoda recenzijaProizvoda = new RecenzijaProizvoda()
                {
                    ocjena = ocjena,
                    komentar = komentar,
                    ID_korisnik_FK = id_korisnik,
                    ID_ponuda_FK = id_ponude
                };               

                context.RecenzijaProizvoda.Add(recenzijaProizvoda);
                context.SaveChanges();
            }
        }

        public void AžurirajOcjenuPonude(int ocjena, int id_ponude)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var querySum = (from recenzija in context.RecenzijaProizvoda
                                where recenzija.ID_ponuda_FK == id_ponude
                                select recenzija.ocjena).Sum();

                var queryCount = (from recenzija in context.RecenzijaProizvoda
                                  where recenzija.ID_ponuda_FK == id_ponude
                                  select recenzija.ocjena).Count();

                double sum = querySum;
                double count = queryCount;

                double prosjecnaOcjena = sum / count;

                var queryUpdate = from ponuda in context.Ponuda
                                  where ponuda.ID_ponuda == id_ponude
                                  select ponuda;

                Ponuda selektiranaPonuda = queryUpdate.Single();
                selektiranaPonuda.ocjena = Math.Round(prosjecnaOcjena,2);

                context.SaveChanges();
                            
            }
        }

    }
}

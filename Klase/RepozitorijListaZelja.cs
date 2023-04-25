using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFanShop.Entities;

namespace OnlineFanShop.Klase
{
    public class RepozitorijListaZelja
    {
        public List<PopisListaZelja> DohvatiListuZeljaZaKoriniska(int korisnik)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from lz in context.ListaZelja
                            from k in context.Korisnik
                            from pon in context.Ponuda
                            from p in context.Proizvod
                            from v in context.VelicinaProizvoda
                            from f in context.FransizaProizvoda
                            where lz.ID_ponuda == pon.ID_ponuda
                            && pon.ID_proizvod_FK == p.ID_proizvod
                            && p.ID_velicina_FK == v.ID_velicina
                            && p.ID_fransiza_FK == f.ID_fransiza
                            && k.ID_korisnik == lz.ID_korisnik
                            && lz.ID_korisnik == korisnik
                            select new PopisListaZelja
                            {
                                id_ponuda = pon.ID_ponuda,
                                nazivProizvoda = p.nazivProizvoda,
                                velicina = v.nazivVelicine,
                                fransiza = f.nazivFransize,
                                datumStavljanja = lz.datum,
                                cijena = pon.cijena
                            };
                List<PopisListaZelja> listaZelja = new List<PopisListaZelja>();
                listaZelja = query.ToList();
                return listaZelja;
            }
        }
        
        public void DodajNaListuZelja(int korisnik, int ponuda)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                ListaZelja listaZelja = new ListaZelja()
                {
                    ID_korisnik = korisnik,
                    ID_ponuda = ponuda,
                    datum = DateTime.Now
                };

                context.ListaZelja.Add(listaZelja);
                context.SaveChanges();
            }
        }

        public void ObrisiSListeZelja(int korisnik, int ponuda)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from lz in context.ListaZelja
                            where lz.ID_korisnik == korisnik
                            && lz.ID_ponuda == ponuda
                            select lz;
                context.ListaZelja.Remove(query.Single());
                context.SaveChanges();
            }
        }
    }
}

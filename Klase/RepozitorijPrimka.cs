using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFanShop.Entities;

namespace OnlineFanShop.Klase
{
    public class RepozitorijPrimka
    {
        public void DodajNovuPrimku(DateTime datum, string dobavljac)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                Primka primka = new Primka()
                {
                    datum = datum,
                    imeDobavljaca = dobavljac
                };

                context.Primka.Add(primka);
                context.SaveChanges();
            }
        }

        public List<Primka> DohvatiSvePrime()
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from p in context.Primka
                            select p;
                List<Primka> primke = new List<Primka>();
                primke = query.ToList();
                return primke;
            }
        }
    }
}

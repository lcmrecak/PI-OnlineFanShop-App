using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFanShop.Entities;

namespace OnlineFanShop.Klase
{
    public class RepozitorijPonuda
    {
        public List<PopisPonude> PopuniPonudaDGV()
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
                                cijena = ponuda.cijena,
                                ID_ponuda2 = ponuda.ID_ponuda
                            };

                List<PopisPonude> popisPonude = new List<PopisPonude>();
                popisPonude = query.ToList();
                return popisPonude;
            }
        }

        public List<FransizaProizvoda> PopuniFransizaCMB()
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from fransiza in context.FransizaProizvoda
                            select fransiza;

                List<FransizaProizvoda> fransizaProizvoda = new List<FransizaProizvoda>();
                fransizaProizvoda = query.ToList();
                return fransizaProizvoda;
            }
        }

        public List<VelicinaProizvoda> PopuniVelicinaCMB()
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from velicina in context.VelicinaProizvoda
                            select velicina;

                List<VelicinaProizvoda> veicinaProizvoda = new List<VelicinaProizvoda>();
                veicinaProizvoda = query.ToList();
                return veicinaProizvoda;
            }
        }

        public List<VrstaProizvoda> PopuniVrstaCMB()
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from vrsta in context.VrstaProizvoda
                            select vrsta;

                List<VrstaProizvoda> vrstaProizvoda = new List<VrstaProizvoda>();
                vrstaProizvoda = query.ToList();
                return vrstaProizvoda;
            }
        }

        public List<PopisPonude> Filtriraj(float cijenaMin, float cijenaMax, string fransizaProizvoda, string velicinaProizvoda, string vrstaProizvoda)
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
                            && ponuda.cijena >= cijenaMin
                            && ponuda.cijena <= cijenaMax
                            && vrsta.nazivVrste.Contains(vrstaProizvoda)
                            && velicina.nazivVelicine.Contains(velicinaProizvoda)
                            && fransiza.nazivFransize.Contains(fransizaProizvoda)

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
                return popisPonude;
            }
        }

        public List<PopisPonude> Sortiraj(string sortiranjePrema)
        {
            if (sortiranjePrema == "Po vrsti")
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
                                orderby vrsta.nazivVrste

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
                    return popisPonude;
                }
            }
            else if (sortiranjePrema == "Po franšizi")
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
                                orderby fransiza.nazivFransize

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
                    return popisPonude;
                }
            }
            else if (sortiranjePrema == "Po ocjeni")
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
                                orderby ponuda.ocjena

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
                    return popisPonude;
                }
            }
            else 
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
                                orderby ponuda.cijena

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
                    return popisPonude;
                }
            }
        }

        public List<PopisPonude> Pretrazi(string naziv)
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
                            && proizvod.nazivProizvoda.Contains(naziv)
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
                return popisPonude;
            }
        }

        public void DodajPonudu(string naziv, int kolicina, double cijena)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                int id_proizvod = 0;

                var query = from p in context.Proizvod
                            where p.nazivProizvoda == naziv
                            select p.ID_proizvod;
                id_proizvod = query.FirstOrDefault();
                System.Windows.Forms.MessageBox.Show("Ponuda uspješno dodana!");
                Ponuda ponuda = new Ponuda()
                {
                    kolicina = kolicina,
                    ocjena = 0,
                    ID_proizvod_FK = id_proizvod,
                    cijena = cijena

                };
                
                context.Ponuda.Add(ponuda);
                
                context.SaveChanges();
            }
        }

        public void UrediTablicuPonuda( int id_ponude, string naziv, string vrsta, string fransiza, string velicina, int kolicina, double cijena)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var queryPonuda = from p in context.Ponuda
                                  where p.ID_ponuda == id_ponude
                                  select p;

                int id_vrsta = 0;
                int id_fransiza = 0;
                int id_velicina = 0;

                var queryVelicina = from v in context.VelicinaProizvoda
                                    where v.nazivVelicine == velicina
                                    select v.ID_velicina;
                id_velicina = queryVelicina.SingleOrDefault();

                var queryVrsta = from v in context.VrstaProizvoda
                                 where v.nazivVrste == vrsta
                                 select v.ID_vrsta;
                id_vrsta = queryVrsta.SingleOrDefault();

                var queryFransiza = from f in context.FransizaProizvoda
                                    where f.nazivFransize == fransiza
                                    select f.ID_fransiza;
                id_fransiza = queryFransiza.SingleOrDefault();

                var queryProizvod = from p in context.Proizvod
                                    from po in context.Ponuda
                                    where po.ID_ponuda == id_ponude
                                    where po.ID_proizvod_FK == p.ID_proizvod
                                    select p;
                
                Ponuda urediPonudu = queryPonuda.Single();
                urediPonudu.kolicina = kolicina;
                urediPonudu.cijena = cijena;
                urediPonudu.Proizvod.ID_velicina_FK = id_velicina;
                urediPonudu.Proizvod.ID_fransiza_FK = id_fransiza;
                urediPonudu.Proizvod.ID_vrsta_FK = id_vrsta;
                urediPonudu.Proizvod.nazivProizvoda = naziv;

                context.SaveChanges();
                
            }
        }

        public void ObrisiPonudu(int id_ponuda)
        {
            using (var context = new EntitiesOnlineFanShop())
            {

                var proizvodZaMaknuti = context.Ponuda.FirstOrDefault(x => x.ID_ponuda == id_ponuda);
                context.Ponuda.Remove(proizvodZaMaknuti);

                context.SaveChanges();
            }
        }
        
    }
}

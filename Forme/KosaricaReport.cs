using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using OnlineFanShop.Entities;
using OnlineFanShop.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warning = Microsoft.Reporting.WinForms.Warning;
using System.Net;
using System.Net.Mail;

namespace OnlineFanShop.Forme
{
    public partial class KosaricaReport : Form
    {
        public int korisnikID { get; set; }
        public KosaricaReport(int korisnik)
        {
            InitializeComponent();
            korisnikID = korisnik;
        }

        private void KosaricaReport_Load(object sender, EventArgs e)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from k in context.Kosarica
                            from p in context.Ponuda
                            from pr in context.Proizvod
                            where k.ID_korisnik == korisnikID
                            && k.ID_ponuda == p.ID_ponuda
                            && p.ID_proizvod_FK == pr.ID_proizvod
                            select new PopisKosarica
                            {
                                naziv = pr.nazivProizvoda,
                                kolicina = k.kolicina,
                                popust = k.popust,
                                cijena = p.cijena * k.kolicina
                            };
                List<PopisKosarica> sadrzajKosarice = new List<PopisKosarica>();
                sadrzajKosarice = query.ToList();
                PopisKosaricaBindingSource.DataSource = sadrzajKosarice;
            }

            this.reportViewer1.RefreshReport();

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;
            byte[] bytes = reportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);
            string FilePath = "";
            FilePath += @"racunOFS.pdf";
            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            string mailTo = "";

            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from k in context.Korisnik
                            where k.ID_korisnik == korisnikID
                            select k.email;

                mailTo = query.Single().ToString();

            }
            try
            {
                using (MailMessage mail = new MailMessage())
                {

                    mail.From = new MailAddress("onlinefanshop239@gmail.com");
                    mail.To.Add(mailTo);
                    mail.Subject = "Račun - OFS";
                    mail.Body = "Poštovani, " +
                        "\nzahvaljujemo se na vašoj kupnji. U privitku vam je priložen vaš račun." +
                        "\n\nVaš Online Fan Shop";
                    mail.Attachments.Add(new Attachment("racunOFS.pdf"));
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("onlinefanshop239@gmail.com", "onlinefanshop1");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        MessageBox.Show("Uspješna kupovina! Račun vam je isporučen na vašu e-mail adresu.");

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Close();
        }
    }
}

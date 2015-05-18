using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petLikeABoss
{
     public class Osoba
    {
         public List<Zivotinja> listaZivotinja { get; set; }
         public List< Komunikacija> komunikacijaOsobe { get; set; }
         public int osobaId { get; set; }
         public string username { get; set; }
         public string imeOsobe { get; set; }
         public string prezimeOsobe { get; set; }
         public string adresaOsobe { get; set; }
         public string emailOsobe { get; set; }
         public string brojTelefona { get; set; }
         public string password { get; set; }
        public Osoba()
        {
            listaZivotinja = new List<Zivotinja>();
            komunikacijaOsobe = new List<Komunikacija>();
        }
        public Osoba(string imeOsobe, string prezimeOsobe, string adresaOsobe, string emailOsobe, string brojTelefona)
        {
            listaZivotinja = new List<Zivotinja>();
            komunikacijaOsobe = new List<Komunikacija>();
            this.imeOsobe = imeOsobe;
            this.prezimeOsobe = prezimeOsobe;
            this.adresaOsobe = adresaOsobe;
            this.emailOsobe = emailOsobe;
            this.brojTelefona = brojTelefona;
        }
        public void dodajZivotinju(Zivotinja zivotinjaNova)
         {
             listaZivotinja.Add(zivotinjaNova);
         }
         public void dodajKomunikaciju (Komunikacija komunikacijaNova)
         {
             komunikacijaOsobe.Add(komunikacijaNova);

         }
   
    }
}

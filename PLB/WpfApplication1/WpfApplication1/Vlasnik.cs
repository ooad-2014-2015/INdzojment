using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace petLikeABoss
{
    public class Vlasnik:Osoba
    {
      
        public string brojKreditneKartice { get; set; }
        public Vlasnik() { }
        public Vlasnik (string imeOsobe, string prezimeOsobe, string adresaOsobe, string emailOsobe,
             string brojTelefona):base(imeOsobe,prezimeOsobe,adresaOsobe,emailOsobe,brojTelefona)
        {

        }

    }
}

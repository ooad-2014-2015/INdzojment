using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petLikeABoss
{
    public class Radnik:Osoba
    {
        public Radnik() { }
        public Radnik (string imeOsobe, string prezimeOsobe, string adresaOsobe, string emailOsobe,
             string brojTelefona):base(imeOsobe,prezimeOsobe,adresaOsobe,emailOsobe,brojTelefona)
        {

        }
    }
}

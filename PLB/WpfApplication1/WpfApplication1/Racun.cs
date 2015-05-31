using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace petLikeABoss
{
    public class Racun
    {
        DolazakOdlazak dolazakOdlazak { get; set; }
        Placanje placanje { get; set; }
        Racun()
        {
 
        }
        Racun(DolazakOdlazak dolazakOdlazak, Placanje placanje)
        {
            this.dolazakOdlazak = dolazakOdlazak;
            this.placanje = placanje;
        }
        void dajRacun()
        { 
        
        }

    }
}

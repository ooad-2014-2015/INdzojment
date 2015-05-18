using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace petLikeABoss
{
    public class Placanje
    {
        public enum nacinPlacanja { kes, kreditnaKartica };
        public decimal ukupno { get; set; }
        public decimal platio { get; set; }
        public decimal dug { get; set; }
        public nacinPlacanja nacinPlac;
        Placanje()
        { 
        
        }
        Placanje(decimal ukupno, decimal platio, decimal dug, nacinPlacanja nacinPlac)
        {
            this.ukupno = ukupno;
            this.platio = platio;
            this.dug = dug;
            this.nacinPlac = nacinPlac;
        }
    }
}

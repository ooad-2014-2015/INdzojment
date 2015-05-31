using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace petLikeABoss
{
    public class DolazakOdlazak
    {
        public DateTime dolazi { get; set; }
        public DateTime odlazi { get; set; }
        public List<Zivotinja> listaZivotinja { get; set; }
        DolazakOdlazak()
        {
            listaZivotinja = new List<Zivotinja>();
        }
        DolazakOdlazak(DateTime dolazi, DateTime odlazi, List<Zivotinja> zivotinje)
        {
            this.dolazi = dolazi;
            this.odlazi = odlazi;
            listaZivotinja = new List<Zivotinja>();
            listaZivotinja = zivotinje;
        }
    }   
}

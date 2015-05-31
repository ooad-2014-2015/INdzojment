using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace petLikeABoss
{
    public class Zivotinja
    {
        public int zivotinjaID { get; set; }
        public string vrsta { get; set; }
        public string rasa { get; set; }
        public string boja { get; set; }
        public Vlasnik vlasnik { get; set; }
        public int vlasnikID { get; set; }
        public List<string> Njega { get; set; }
        public Soba soba { get; set; }
        public int sobaID { get; set; }
        public Zivotinja () { }
        public Zivotinja (int zivotinjaID , string vrsta, string rasa, string boja,  Soba soba )
    {
        Njega = new List<string>();
        this.zivotinjaID=zivotinjaID;
        this.boja = boja;
        this.vrsta = vrsta;
        this.rasa = rasa;
        this.soba = soba;

    }

    }
}

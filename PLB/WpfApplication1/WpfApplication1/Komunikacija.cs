using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace petLikeABoss
{
    public class Komunikacija
    {
        public List<string> porukeZaRadnika;
        public List<string> porukeZaVlasnika;
        public int radnikIDD {get;set;}
        public int vlasnikIDD { get; set; }
        public Komunikacija() { }
        public Komunikacija(int radnikIDD, int vlasnikIDD)
        {
            this.radnikIDD = radnikIDD;
            this.vlasnikIDD = vlasnikIDD;
            porukeZaRadnika = new List<string>();
            porukeZaVlasnika = new List<string>();
        }
        
        public void dodajPorukuRadniku (string porukaZaRadnika)
        {
            porukeZaRadnika.Add(porukaZaRadnika);

        }
        public void dodajPorukuVlasniku(string porukaZaVlasnika)
        {
            porukeZaVlasnika.Add(porukaZaVlasnika);

        }
    }
}

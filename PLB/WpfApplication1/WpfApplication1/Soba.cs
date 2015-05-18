using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace petLikeABoss
{
    public class Soba
    {
        public int sobaID { get; set; }
        public Boolean zauzeta { get; set; }
        public Boolean rezervisana { get; set; }
        public List<Zivotinja> listaZivotinjaUSobi { get; set; }
        public Soba() { }
        public Soba(int sobaID, Boolean zauzeta, Boolean rezervisana)
        {
            listaZivotinjaUSobi = new List<Zivotinja>();
            this.sobaID = sobaID;
            this.zauzeta = zauzeta;
            this.rezervisana = rezervisana;
        }
        public void dodajZivotinjuUsobu(Zivotinja zivotinjaNova)
        {

            listaZivotinjaUSobi.Add(zivotinjaNova);
        }
    }
}

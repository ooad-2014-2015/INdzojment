using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petLikeABoss
{
    public class Rezervacija
    {
        public int rezervacijaID { get; set; }
        public enum tipRezervacije { online,uzivo};
        public tipRezervacije tipRezer;
        public DateTime odDatuma {get;set;}
        public DateTime doDatuma {get;set;}
        public List<Zivotinja> listaZivotinjaKojeSeRezervisu;
        public Rezervacija() 
        {
           listaZivotinjaKojeSeRezervisu=new List<Zivotinja>();
        }
        public Rezervacija(tipRezervacije tip, DateTime odDatuma, DateTime doDatuma )
        {
            listaZivotinjaKojeSeRezervisu=new List<Zivotinja>();
            tipRezer = tip;
            this.odDatuma = odDatuma;
            this.doDatuma = doDatuma;
        }
        public void generisiPassword (string adresaVlasnika)
        {
        
            listaZivotinjaKojeSeRezervisu[0].vlasnik.password = adresaVlasnika;
        
        }
        public void otkaziRezervaciju() 
        {
            listaZivotinjaKojeSeRezervisu[0].soba.rezervisana = false;
           
        }
        

    }
}

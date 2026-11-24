using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTask
{
    internal abstract class ZlecenieDruku
    {
        

        public string Numer { get; set; }
        public int LiczbaSztuk { get; set; }
        public decimal CenaSztuki = 10;

        protected ZlecenieDruku(string numer, int liczbaSztuk )
        {
            Numer = numer;
            LiczbaSztuk = liczbaSztuk;
          
        }

       





        public virtual decimal ObliczKoszt()
        {
            return LiczbaSztuk * CenaSztuki;
               
        }

        public abstract int ObliczCzasRealizacji();
        
    }
}

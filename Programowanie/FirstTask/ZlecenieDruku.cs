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

        public abstract double ObliczCzasRealizacji();

        public void WyswietlPodsumowanie(ZlecenieDruku zlecenie)
        {
            Console.WriteLine($"Numer zlecenia: {zlecenie.Numer}");
            Console.WriteLine($"Wynik Kosztu: {zlecenie.ObliczKoszt()}");
            Console.WriteLine($"Wynik Realizacji: {zlecenie.ObliczCzasRealizacji()}");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FirstTask
{
    internal class DrukDokumentu : ZlecenieDruku
    {
        public DrukDokumentu( string numer , int liczbaSztuk)
            :base(numer,liczbaSztuk)
        {


        }
        

        public override double ObliczCzasRealizacji()
        {
            double CzasRealizacji = Math.Ceiling(LiczbaSztuk / 20.0);
            return CzasRealizacji;
        }
    }
    
    }

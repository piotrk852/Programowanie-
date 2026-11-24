using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTask
{
    internal class DrukPlakatu : ZlecenieDruku
    {

        public DrukPlakatu(string numer, int liczbaSztuk)
            : base(numer, liczbaSztuk)
        {

        }

        public override decimal ObliczKoszt()
        {
            return base.ObliczKoszt() + 12;

        }
        public override double ObliczCzasRealizacji()
        {
            return 5 + LiczbaSztuk * 3;
        }

    }
}

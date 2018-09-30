using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacicJanNasljedivanje
{
    class Nastavnik:Osoba
    {
        public string predmet;

        public string GetPredmet()
        {
            return predmet;
        }

        public void SetPredmet(string value)
        {
            predmet = value;
        }
    }
}

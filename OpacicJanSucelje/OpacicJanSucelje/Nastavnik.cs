using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacicJanSucelje
{
    class Nastavnik:Osoba, MojInterface
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

        public string DohvatiDetalje()
        {
            return this.prezime + " " + this.ime + ", " + this.predmet;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacicJanSucelje
{
    class Ucenik:Osoba, MojInterface
    {
        public int razred;

        public int GetRazred()
        {
            return razred;
        }

        public void SetRazred(int value)
        {
            razred = value;
        }

        public string DohvatiDetalje()
        {
            return this.prezime + " " + this.ime + ", " + this.razred;
        }
    }
}

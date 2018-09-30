using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacicJanNasljedivanje
{
    class Ucenik:Osoba
    {
        public int razred;

        public new string DohvatiDetalje()
        {
            return this.ime + " " + this.prezime + ", " + this.razred;
        }

        public int GetRazred()
        {
            return razred;
        }

        public void SetRazred(int value)
        {
            razred = value;
        }

        public override string ToString()
        {
            return this.ime + " " + this.prezime;
        }
    }
}

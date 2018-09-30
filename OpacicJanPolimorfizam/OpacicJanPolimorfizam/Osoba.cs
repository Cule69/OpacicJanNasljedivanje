using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacicJanPolimorfizam
{
    class Osoba
    {
        public string ime;
        public string prezime;

        public string GetIme()
        {
            return ime;
        }

        public void SetIme(string value)
        {
            ime = value;
        }

        public string GetPrezime()
        {
            return prezime;
        }

        public void SetPrezime(string value)
        {
            prezime = value;
        }
        public override string ToString()
        {
            return this.ime + " " + this.prezime;
        }
    }
}

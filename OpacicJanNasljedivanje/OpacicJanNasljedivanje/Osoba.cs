using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacicJanNasljedivanje
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

        public string DohvatiDetalje()
        {
            return this.ime + " " + this.prezime;
        }
    }
}

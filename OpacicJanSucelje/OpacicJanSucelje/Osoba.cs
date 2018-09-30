using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacicJanSucelje
{
    class Osoba:IComparable
    {
        public string ime;

        public string GetIme()
        {
            return ime;
        }

        public void SetIme(string value)
        {
            ime = value;
        }

        public string prezime;

        public string GetPrezime()
        {
            return prezime;
        }

        public void SetPrezime(string value)
        {
            prezime = value;
        }

        public int CompareTo(object obj)
        {
            return this.prezime.CompareTo(((Osoba)obj).prezime);
        }
    }
}

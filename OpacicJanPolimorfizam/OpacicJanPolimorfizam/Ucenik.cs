using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacicJanPolimorfizam
{
    class Ucenik:Osoba
    {
        public override string ToString()
        {
            return this.prezime + ", " + this.ime;
        }
    }
}

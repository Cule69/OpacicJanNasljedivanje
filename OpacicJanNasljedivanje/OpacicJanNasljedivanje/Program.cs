using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacicJanNasljedivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u = new Ucenik();
            u.ime = "Jan";
            u.prezime = "Opacic";
            u.razred = 4;
            Nastavnik n = new Nastavnik();
            n.ime = "Lovro";
            n.prezime = "Sverko";
            n.predmet = "NiOP";
            Console.WriteLine("Učenik: {0}", u.DohvatiDetalje());
            Console.WriteLine("Nastavnik: {0}", n.DohvatiDetalje());
            Console.WriteLine(u.ToString());
        }
    }
}

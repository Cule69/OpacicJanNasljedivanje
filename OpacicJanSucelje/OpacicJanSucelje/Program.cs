using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacicJanSucelje
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MojInterface> lista = new List<MojInterface>();
            Nastavnik n = new Nastavnik();
            n.ime = "Lovro";
            n.prezime = "Sverko";
            n.predmet = "NiOP";
            lista.Add(n);
            Ucenik u = new Ucenik();
            u.ime = "Hrvoje";
            u.prezime = "Horvat";
            u.razred = 4;
            lista.Add(u);
            lista.Sort();
            foreach (MojInterface x in lista)
            {
                Console.WriteLine(x.DohvatiDetalje());
            }
            Console.ReadKey();
        }
    }
}

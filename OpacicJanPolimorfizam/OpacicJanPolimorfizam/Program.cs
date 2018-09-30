using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpacicJanPolimorfizam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osobe = new List<Osoba>();
            Osoba o = new Osoba();
            o.ime = "Marija";
            o.prezime = "Car";
            osobe.Add(o);
            Ucenik u = new Ucenik();
            u.ime = "Hrvoje";
            u.prezime = "Horvat";
            osobe.Add(u);
            foreach (Osoba x in osobe)
            {
                Console.WriteLine(x.ToString());
            }
            Console.ReadKey();
        }
    }
}

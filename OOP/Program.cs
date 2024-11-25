using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Carolija carolija = new Carolija(10000, 4000);
            Stack<Vestica> vestice = new Stack<Vestica>();
            vestice.Push(new Vestica("Bilja", 180, 80, 30, true, true, true, true));
            vestice.Push(new Vestica("Olja", 181, 81, 31, false, false, false, false));
            vestice.Push(new Vestica("Mika", 182, 82, 32, true, false, true, false));
            vestice.Push(new Vestica("Zika", 183, 83, 33, false, true, false, true));
            vestice.Push(new Vestica("Pera", 170, 70, 20, false, false, true, true));
            vestice.Push(new Vestica("Pavle", 171, 71, 21, false, false, false, true));
            vestice.Push(new Vestica("Nikola", 172, 72, 22, true, true, true, false));
            vestice.Push(new Vestica("Nemanja", 173, 73, 23, true, true, false, true));
            vestice.Push(new Vestica("Laza", 174, 74, 24, true, true, false, false));
            vestice.Push(new Vestica("Luka", 175, 75, 25, true, true, true, true));
            vestice.Push(new Vestica("Ana", 160, 60, 10, true, true, true, true));
            vestice.Push(new Vestica("Anja", 161, 61, 11, true, true, true, false));
            vestice.Push(new Vestica("Snezana", 162, 62, 21, true, true, false, false));
            vestice.Push(new Vestica("Svetlana", 163, 63, 13, true, true, false, false));
            vestice.Push(new Vestica("Marija", 164, 64, 14, true, true, false, false));
            vestice.Push(new Vestica("Milica", 165, 65, 20, true, true, true, true));
            try
            {
                carolija.Ulaz(vestice.Pop());
                carolija.Ulaz(vestice.Pop());
                carolija.Ulaz(vestice.Pop());
                carolija.Ulaz(vestice.Pop());
                carolija.Ulaz(vestice.Pop());
                carolija.Ulaz(vestice.Pop());
                carolija.Ulaz(vestice.Pop());
                carolija.Ulaz(vestice.Pop());
                carolija.Ulaz(vestice.Pop());
                carolija.Ulaz(vestice.Pop());

                Console.WriteLine("***********************************************************");
                carolija.Spisak();

                Console.WriteLine("***********************************************************");
                carolija.Popust();

                Console.WriteLine("***********************************************************");
                carolija.UpitVestice();

                Console.WriteLine("***********************************************************");
                Console.WriteLine("Ispis indekser:");
                Carolija carolija1 = new Carolija(10000, 4000);
                carolija1[0] = vestice.Pop();
                carolija1[1] = vestice.Pop();
                carolija1[2] = vestice.Pop();
                carolija1[3] = vestice.Pop();
                carolija1[4] = vestice.Pop();
                foreach (Vestica v in carolija1)
                {
                    Console.WriteLine(v);
                }

                Console.WriteLine("***********************************************************");
                Console.WriteLine("Demonstracija izuzetaka: \n");
                carolija.Ulaz(vestice.Pop()); // Baca izuzetak: Vestici nije dozvoljen ulaz u  radnju!
}
            catch (IzuzetakMagija im)
            {
                Console.WriteLine(im.Message);
            }
            try
            {
                // Baca izuzetak: U radnji nema vestica!
                for (int i = 0; i < carolija.BrojVestica;)
                {
                    carolija.Izlaz();
                }
            }
            catch (IzuzetakMagija im)
            {
                Console.WriteLine(im.Message);
            }
            Console.ReadLine();
        }
    }

}

 

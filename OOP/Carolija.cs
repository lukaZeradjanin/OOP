using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Carolija : ImagijaShop, IEnumerable
    {
        List<Vestica> sesir;
        List<Vestica> metla;
        private double cenaMetla;
        private double cenaSesir;
        private double popust;
        private int brojVestica;
        public Carolija(double cenaMetla, double cenaSesir)
        {
            sesir = new List<Vestica>();
            metla = new List<Vestica>();
            this.cenaMetla = cenaMetla;
            this.cenaSesir = cenaSesir;
        }
        public int BrojVestica { get => brojVestica; }
        // Implementacija interfejsa
        public void Ulaz(Vestica v)
        {
            if (v.Dozvola == true && metla.Count < 5)
            {
                metla.Add(v);
                brojVestica++;
            }
            else if (v.Clanarina == true && sesir.Count < 5)
            {
                sesir.Add(v);
                brojVestica++;
            }
            else
            {
                throw new IzuzetakMagija("Vestici nije dozvoljen ulaz u radnju!");
            }
        }
        public void Izlaz()
        {
            if (metla.Count > 0)
            {
                metla.RemoveAt(metla.Count - 1);
                if (sesir.Count > 0)
                {
                    sesir.RemoveAt(sesir.Count - 1);

                }
                else
                {
                    throw new IzuzetakMagija("U radnji nema vestica!");
                }
            }
        }
        public void Spisak()
        {
            Console.WriteLine("Sve vestice u radnji: \n");
            foreach (Vestica v in metla)
            {
                Console.WriteLine(v);
            }
            foreach (Vestica v in sesir)
            {
                Console.WriteLine(v);
            }
        }
        public double Popust()
        {
            Console.WriteLine("Ispis cene sa popustom: \n");
            foreach (Vestica v in metla)
            {
                if (v != null)
                {
                    if (v.Kupon == true)
                    {
                        popust = cenaMetla - (cenaMetla * 0.3);
                        Console.WriteLine(v.Ime + " Kupon: " + v.Kupon + " Cena metle  sa popustom: " + popust);
                    }
                }
            }
            Console.WriteLine();
            foreach (Vestica v in sesir)
            {
                if (v != null)
                {
                    if (v.Velicina == true)
                    {
                        popust = cenaSesir - (cenaSesir * 0.4);
                        Console.WriteLine(v.Ime + " Velicina: " + v.Velicina +
                        " Cena sesira sa popustom: " + popust);
                    }
                }
            }
            return popust;
        }
        // Indekser
        Vestica[] indekser = new Vestica[5];
        public Vestica this[int i]
        {
            get { return indekser[i]; }
            set { indekser[i] = value; }
        }
        public IEnumerator GetEnumerator()
        {
            return indekser.GetEnumerator();
        }

        // Linq upit
        public void UpitVestice()
        {
            Console.WriteLine("Ispis oba LINQ upita: \n");
            var upitMetla = from m in metla
                            where m.Godine > 18 && m.Dozvola == true
                            orderby m.Ime descending
                            select m;
            Console.WriteLine("Vestice starije od 18 godina i imaju dozvolu sortirane po imenu u opadajucem poretku: ");
        foreach (Vestica v in upitMetla)
            {
                Console.WriteLine(v);
            }
            var upitSesir = from s in sesir
                            where s.Kupon == true && s.Velicina == true
                            orderby s.Visina, s.Tezina
                            select s;
            Console.WriteLine("\nVestice koje imaju kupon i velicina sesira je odgovarajuca sortirane po visini i tezini: ");
        foreach (Vestica v in upitSesir)
            {
                Console.WriteLine(v);
            }
        }
    }

}


        


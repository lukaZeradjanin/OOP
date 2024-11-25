using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   
    
        class Vestica
        {
            private string ime;
            private double visina;
            private double tezina;
            private int godine;
            private bool clanarina;
            private bool dozvola;
            private bool kupon;
            private bool velicina;
            public Vestica(string ime, double visina, double tezina, int godine, bool
            clanarina, bool dozvola, bool velicina, bool kupon)
            {
                this.ime = ime;
                this.visina = visina;
                this.tezina = tezina;
                this.godine = godine;
                this.clanarina = clanarina;
                this.dozvola = dozvola;
                this.velicina = velicina;
                this.kupon = kupon;
            }
            public string Ime { get => ime; set => ime = value; }
            public double Visina { get => visina; set => visina = value; }
            public double Tezina { get => tezina; set => tezina = value; }
            public int Godine { get => godine; set => godine = value; }
            public bool Clanarina { get => clanarina; set => clanarina = value; }
            public bool Dozvola { get => dozvola; set => dozvola = value; }
            public bool Kupon { get => kupon; set => kupon = value; }
            public bool Velicina { get => velicina; set => velicina = value; }
            public override string ToString()
            {
                return  "Vestica" + ime + "Visina" + visina + "Tezina:" + tezina + "Godine:" + godine + "Clanarina:" + clanarina + "Dozvola:" + dozvola + 
                "Kupon:" + kupon + "Velicina" + velicina;
            }
        }

    }


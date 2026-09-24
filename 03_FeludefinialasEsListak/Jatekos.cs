using System;
using System.Collections.Generic;
using System.Text;

namespace _03_FeludefinialasEsListak
{
    internal class Jatekos
    {
        private string nev;
        private int szint;
        private int pontszam;
        public string Nev { get; set;  }
        public int Szint
        {
            get { return szint; }
            set
            {
                if (value < 1)
                {
                    szint = 1;
                }
                else if (value > 100)
                {
                    szint = 100;
                }
                else
                {
                    szint = value;
                }
            }
        }
        public int Pontszam
        {
            get { return pontszam; }
            set
            {
                if (value < 0) pontszam = 0;
                else pontszam = value;
            }
        }
        public Jatekos(string nev, int szint, int pontszam) 
        {
            Nev = nev;
            Szint = szint;
            Pontszam = pontszam;
        }

        public override string ToString()
        {
            return $"Játekos: {Nev} Szint: {Szint} Pontszám: {Pontszam}";
        }
    }
}

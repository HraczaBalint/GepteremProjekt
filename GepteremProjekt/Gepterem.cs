using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepteremProjekt
{
    class Gepterem
    {
        private int[,] ertekeles;
        private int helyDb;
        private string nev;
        private int sorDb;

        public int[,] Ertekeles { get => ertekeles; }
        public int HelyDb { get => helyDb; }
        public string Nev { get => nev; }
        public int SorDb { get => sorDb; }

        public Gepterem(string nev, int sorDb, int helyDb, int[,] ertekeles) 
        {
            this.nev = nev;
            this.sorDb = sorDb;
            this.helyDb = helyDb;
            this.ertekeles = ertekeles;
        }
    }
}

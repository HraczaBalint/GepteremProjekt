using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GepteremProjekt
{
    class PetrikLajosTechnikum
    {
        private List<Gepterem> geptermek = new List<Gepterem>();

        internal List<Gepterem> Geptermek { get => geptermek; }

        public PetrikLajosTechnikum(string fajlnev) 
        {
            try
            {
                using (StreamReader sr = new StreamReader(fajlnev))
                {
                    while (!sr.EndOfStream)
                    {
                        string nev = sr.ReadLine();
                        string[] gepPozicio = sr.ReadLine().Split(';');
                        int sorDb = int.Parse(gepPozicio[0]);
                        int helyDb = int.Parse(gepPozicio[1]);
                        int[,] ertekeles = new int[sorDb, helyDb];

                        for (int i = 0; i < sorDb; i++)
                        {
                            gepPozicio = sr.ReadLine().Split(';');
                            for (int j = 0; j < helyDb; j++)
                            {
                                ertekeles[i, j] = int.Parse(gepPozicio[j]);
                            }
                        }

                        Gepterem gepterem = new Gepterem(nev, sorDb, helyDb, ertekeles);
                        geptermek.Add(gepterem);

                        sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        public double AtlagPontSzam()
        {
            double osszeg = 0;
            int darabszam = 0;

            for (int aktualis = 0; aktualis < geptermek.Count; aktualis++)
            {
                for (int i = 0; i < geptermek[aktualis].SorDb; i++)
                {
                    for (int j = 0; j < geptermek[aktualis].HelyDb; j++)
                    {
                        if (geptermek[aktualis].Ertekeles[i, j] > 0)
                        {
                            osszeg += geptermek[aktualis].Ertekeles[i, j];
                            darabszam++;
                        }
                    }
                }
            }

            return Math.Round(osszeg / darabszam, 3);
        }
    }
}

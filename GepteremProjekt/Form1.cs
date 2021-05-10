using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GepteremProjekt
{
    public partial class Form_geptermek : Form
    {
        PetrikLajosTechnikum petrikLajosTechnikum = new PetrikLajosTechnikum("petrikgepek.txt");
        int aktualis = 0;
        Image[] ertekeles =
        {
            Image.FromFile(@"Kepek/Pont0.jpg"),
            Image.FromFile(@"Kepek/Pont1.jpg"),
            Image.FromFile(@"Kepek/Pont2.jpg"),
            Image.FromFile(@"Kepek/Pont3.jpg")
        };

        public Form_geptermek()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Gepterem_Betoltes();
        }

        private void Gepterem_Betoltes()
        {
            panelErtekeles.Controls.Clear();

            Gepterem aktualisGepterem = petrikLajosTechnikum.Geptermek[aktualis];

            this.Text = aktualisGepterem.Nev;
            pictureBoxNevado.Image = Image.FromFile(@"Kepek/" + aktualisGepterem.Nev.Split(' ')[0] + ".jpg");
            pictureBoxNevado.SizeMode = PictureBoxSizeMode.Zoom;

            int meret = 40;
            for (int i = 0; i < aktualisGepterem.SorDb; i++)
            {
                for (int j = 0; j < aktualisGepterem.HelyDb; j++)
                {
                    PictureBox picture = new PictureBox();
                    picture.SetBounds(j*meret, i*meret, meret, meret);
                    picture.BackgroundImage = ertekeles[aktualisGepterem.Ertekeles[i,j]];
                    picture.BackgroundImageLayout = ImageLayout.Zoom;

                    int i_erteke = i;
                    int j_erteke = j;

                    picture.Click += (o, e) => 
                    {
                        switch (aktualisGepterem.Ertekeles[i_erteke, j_erteke])
                        {
                            case 1:
                                aktualisGepterem.Ertekeles[i_erteke, j_erteke] = 2;
                                break;
                            case 2:
                                aktualisGepterem.Ertekeles[i_erteke, j_erteke] = 3;
                                break;
                            case 3:
                                aktualisGepterem.Ertekeles[i_erteke, j_erteke] = 1;
                                break;
                            default: 
                                MessageBox.Show("Az adott helyen nem ült senki!");
                                break;
                        }

                        Gepterem_Betoltes();
                    }; 

                    panelErtekeles.Controls.Add(picture);
                }
            }
        }

        private void buttonJobb_Click(object sender, EventArgs e)
        {
            aktualis++;

            if (aktualis == petrikLajosTechnikum.Geptermek.Count)
            {
                aktualis = 0;
            }

            Gepterem_Betoltes();
        }

        private void buttonBal_Click(object sender, EventArgs e)
        {
            aktualis--;

            if (aktualis < 0)
            {
                aktualis = petrikLajosTechnikum.Geptermek.Count - 1;
            }

            Gepterem_Betoltes();
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy("petrikgepek.txt", "petrikgepek.bak", true);

                using (StreamWriter sw = new StreamWriter("petrikgepek.txt"))
                {
                    foreach (Gepterem gepterem in petrikLajosTechnikum.Geptermek)
                    {
                        sw.WriteLine(gepterem.Nev);
                        sw.WriteLine($"{gepterem.SorDb};{gepterem.HelyDb}");
                        for (int i = 0; i < gepterem.SorDb; i++)
                        {
                            string s = "";
                            for (int j = 0; j < gepterem.HelyDb; j++)
                            {
                                s += gepterem.Ertekeles[i, j].ToString() + ";";
                            }
                            sw.WriteLine(s.Substring(0, s.Length - 1));
                        }
                        sw.WriteLine();
                    }
                    MessageBox.Show("Sikeres mentés!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (petrikLajosTechnikum.AtlagPontSzam() >= 2)
            {
                MessageBox.Show("Az átlagos értékelés: " + petrikLajosTechnikum.AtlagPontSzam().ToString() + "\nNem kell új imageket készíteni!");
            }
            else 
            {
                MessageBox.Show("Az átlagos értékelés: " + petrikLajosTechnikum.AtlagPontSzam().ToString() + "\nÚj imageket kell készíteni!");
            }
        }
    }
}

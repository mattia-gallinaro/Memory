using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] fiori = new string[] { "magnolia", "margherita", "primula", "campane blu" };
            int nGenmagnolia = 0, nGenMargherita = 0, nGenPrimula = 0, nGenCampane_Blu = 0;
            string[] fioriCarte = new string[8];
            Random genCarte = new Random();
            for (int i = 0; i < 8; i++)
            {
                string fioreGenerato = genCarteRandom(fiori, genCarte, ref nGenmagnolia, ref nGenMargherita, ref nGenPrimula, ref nGenCampane_Blu);
                //controlla se il fiore generato è stato sorteggiato già più di due volte
                if (i > 1 && controlloCarte(fioriCarte, ref fioreGenerato, ref nGenmagnolia, ref nGenMargherita, ref nGenPrimula, ref nGenCampane_Blu) == -1)
                {
                    i--;//torna indietro di un ciclo, per permettere quando il ciclo si conclude di ripetere
                        //dopo lo stesso ciclo per rigenerare un altro fiore per la medesima posizione nell'array
                }
                else
                {
                    fioriCarte[i] = fioreGenerato;
                }
            }
            assegnazioneSfondoCarte();
        }
        private void assegnazioneSfondoCarte()
        {
            carta1.Image = Properties.Resources.sfondo_carta;
            carta2.Image = Properties.Resources.sfondo_carta;
            carta3.Image = Properties.Resources.sfondo_carta;
            carta4.Image = Properties.Resources.sfondo_carta;
            carta5.Image = Properties.Resources.sfondo_carta;
            carta6.Image = Properties.Resources.sfondo_carta;
            carta7.Image = Properties.Resources.sfondo_carta;
            carta8.Image = Properties.Resources.sfondo_carta;
        }
        //genera un fiore
        private string genCarteRandom(string[] arrayFiori, Random gnCard, ref int nGenmagnolia, ref int nGenMargherita, ref int nGenPrimula, ref int nGenCampane_Blu)
        {
            string fioreGenerato = "";
            int posGenerata = 0;
            posGenerata = gnCard.Next(0,4);
            fioreGenerato = arrayFiori[posGenerata];
            switch (fioreGenerato)
            {
                case "magnolia":
                    nGenmagnolia = aumentoNumFioreGenerato(nGenmagnolia);
                    break;
                case "margherita":
                    nGenMargherita = aumentoNumFioreGenerato(nGenMargherita);
                    break;
                case "primula":
                    nGenPrimula = aumentoNumFioreGenerato(nGenPrimula);
                    break;
                case "campane blu":
                    nGenCampane_Blu = aumentoNumFioreGenerato(nGenCampane_Blu);
                    break;
            }
            return fioreGenerato;
        }
        //controlla se il fiore è già stato generato più di due volte
        private int controlloCarte(string[] arrayCard, ref string fioreGenerato, ref int nGenmagnolia, ref int nGenMargherita, ref int nGenPrimula, ref int nGenCampane_Blu)
        {
            //per togliere i valori nulli
            arrayCard = arrayCard.Where(c => c != null).ToArray();
            for(int i = 0; i < arrayCard.Length; i++)
            {
                if(arrayCard[i] == fioreGenerato)
                {
                    switch (fioreGenerato)
                    {
                        case "magnolia":
                            if(nGenmagnolia == 3)
                            {
                                return -1;
                            }
                            break;
                        case "margherita":
                            if (nGenMargherita == 3)
                            {
                                return -1;
                            }
                            break;
                        case "primula":
                            if (nGenPrimula == 3)
                            {
                                return -1;
                            }
                            break;
                        case "campane blu":
                            if (nGenCampane_Blu == 3)
                            {
                                return -1;
                            }
                            break;
                    }
                }
            }         
            return 1;
        }
        //controlla per tutte le variabili se sono stati sorteggiati più di due volte
        private int aumentoNumFioreGenerato(int genNum)
        {
            if (genNum < 3)
            {
                genNum++;
            }
            return genNum;
        }
        //funzione al clikc di una carta
        private void clickCarta(int numCarta)
        {
            numCarta -= 1; //per conformarlo alla posizione dell'array
        }

        private void carta1_Click(object sender, EventArgs e)
        {
            clickCarta(1);
        }

        private void carta2_Click(object sender, EventArgs e)
        {
            clickCarta(2);
        }

        private void carta3_Click(object sender, EventArgs e)
        {
            clickCarta(3);
        }

        private void carta4_Click(object sender, EventArgs e)
        {
            clickCarta(4);
        }

        private void carta5_Click(object sender, EventArgs e)
        {
            clickCarta(5);
        }

        private void carta6_Click(object sender, EventArgs e)
        {
            clickCarta(6);
        }

        private void carta7_Click(object sender, EventArgs e)
        {
            clickCarta(7);
        }

        private void carta8_Click(object sender, EventArgs e)
        {
            clickCarta(8);
        }
    }
}

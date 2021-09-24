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
            string[] fiori = new string[] {"magnolia", "margherita", "primula", "campane blu"};
            int nGenmagnolia = 0, nGenMargherita = 0, nGenPrimula = 0, nGenCampane_Blu = 0;
            string[] fioriCarte = new string[8];
            Random genCarte = new Random();
            for(int i = 0; i < 8; i++)
            {
                string fioreGenerato = genCarteRandom(fiori, genCarte);
                if (i > 1)
                {   //controlla se il fiore generato è stato sorteggiato già più di due volte
                    if(controlloCarte(ref nGenmagnolia, ref nGenMargherita, ref nGenPrimula, ref nGenCampane_Blu, fioriCarte, ref fioreGenerato) == -1)
                    {
                        i--;//torna indietro di un ciclo, per permettere quando il ciclo si conclude di ripetere
                            //dopo lo stesso ciclo per rigenerare un altro fiore per la medesima posizione nell'array
                    }
                    else
                    {
                        fioriCarte[i] = fioreGenerato;
                    }
                }
            }
        }
        //genera un fiore
        private string genCarteRandom(string[] arrayFiori, Random gnCard)
        {
            string fioreGenerato = "";
            int posGenerata = 0;
            posGenerata = gnCard.Next(0,4);
            fioreGenerato = arrayFiori[posGenerata];
            return fioreGenerato;
        }
        //controlla se il fiore è già stato generato più di due volte
        private int controlloCarte(ref int nGenmagnolia, ref int nGenMargherita, ref int nGenPrimula, ref int nGenCampane_Blu, string[] arrayCard, ref string fioreGenerato)
        {
            for(int i = 0; i < arrayCard.Length; i++)
            {
                if(arrayCard[i] == fioreGenerato)
                {
                    return -1;
                }
            }         
            return 1;
        }
        //funzione al clikc di una carta
        private void clickCarta(int numCarta)
        {
            numCarta -= 1; //per conformarlo alla posizione dell'array
        }
    }
}

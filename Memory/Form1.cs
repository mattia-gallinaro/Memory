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

        string[] fioriCarte = new string[8];
        bool turno;
        bool[] sceltaGiocatore = new bool[] {false, false, false, false, false, false, false, false};
        int carteSelezionate = 0, coppieG1 = 0, coppieG2 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            startGame();
        }

        private void startGame()
        {
            sceltaTurno();
            string[] fiori = new string[] { "magnolia", "margherita", "primula", "campane blu" };
            int nGenmagnolia = 0, nGenMargherita = 0, nGenPrimula = 0, nGenCampane_Blu = 0;
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
        //viene generato randomicamente il turno del giocatore
        private void sceltaTurno()
        {
            Random turnoRnd = new Random();
            int scelta = turnoRnd.Next(0, 2);
            if(scelta == 0)
            {
                turno = false;//giocatore 1
                this.BackColor = Color.Blue;
            }
            else
            {
                turno = true;//giocatore 2
                this.BackColor = Color.Red;
            }
        }
        //assegna alle picturebox l'immagine iniziale
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
            if(sceltaGiocatore[numCarta] == false)
            {
                switch (numCarta)
                {
                    case 0:
                        carta1.Image = cartasfondo(numCarta);
                        sceltaGiocatore[numCarta] = true;
                        controlloTurno(numCarta);
                        break;
                    case 1:
                        carta2.Image = cartasfondo(numCarta);
                        sceltaGiocatore[numCarta] = true;
                        controlloTurno(numCarta);
                        break;
                    case 2:
                        carta3.Image = cartasfondo(numCarta);
                        sceltaGiocatore[numCarta] = true;
                        controlloTurno(numCarta);
                        break;
                    case 3:
                        carta4.Image = cartasfondo(numCarta);
                        sceltaGiocatore[numCarta] = true;
                        controlloTurno(numCarta);
                        break;
                    case 4:
                        carta5.Image = cartasfondo(numCarta);
                        sceltaGiocatore[numCarta] = true;
                        controlloTurno(numCarta);
                        break;
                    case 5:
                        carta6.Image = cartasfondo(numCarta);
                        sceltaGiocatore[numCarta] = true;
                        controlloTurno(numCarta);
                        break;
                    case 6:
                        carta7.Image = cartasfondo(numCarta);
                        sceltaGiocatore[numCarta] = true;
                        controlloTurno(numCarta);
                        break;
                    case 7:
                        carta8.Image = cartasfondo(numCarta);
                        sceltaGiocatore[numCarta] = true;
                        controlloTurno(numCarta);
                        break;
                }
            }
        }
        //assegna alle carte un immagine a seconda dell'array generato
        private System.Drawing.Image cartasfondo(int nCarta)
        {
            if(fioriCarte[nCarta] == "magnolia")
            {
                return Properties.Resources.magnolia;
            }
            else if (fioriCarte[nCarta] == "margherita")
            {
                return Properties.Resources.margherita;
            }
            else if (fioriCarte[nCarta] == "primula")
            {
                return Properties.Resources.primula;
            }
            else if (fioriCarte[nCarta] == "campane blu")
            {
                return Properties.Resources.campane_blu;
            }
            return null;
        }
        private void controlloTurno(int nCard)
        {
            carteSelezionate++;
            controlloCoppie(ref nCard);
        }
        int card1, card2;
        private void controlloCoppie(ref int nCard)
        {
            if (carteSelezionate % 2 == 0)
            {
                card2 = nCard;
                if(fioriCarte[card1] != fioriCarte[card2])
                {
                    sceltaGiocatore[card1] = false;
                    sceltaGiocatore[card2] = false;
                    wait(500);//fa aspettare 0,5s all'operazione successiva
                    assegnazioneSfondoCarteNonCoppie(card1);
                    assegnazioneSfondoCarteNonCoppie(card2);
                    carteSelezionate -= 2;
                    turno = !turno;//cambia il valore da true a false o da false a true
                    if (turno)
                    {
                        this.BackColor = Color.Red;
                    }
                    else
                    {
                        this.BackColor = Color.Blue;
                    }
                }
                else
                {
                    if (turno)//assegna il punteggio a seconda del turno
                    {
                        coppieG2++;
                    }
                    else
                    {
                        coppieG1++;
                    }
                }
            }
            else
            {
                card1 = nCard;
            }
            if(carteSelezionate == 8)//mostra il tasto per ricominciare a giocare
            {
                restartGame.Visible = true;
                this.BackColor = Color.White;
                if(coppieG1 > coppieG2)
                {
                    MessageBox.Show($"La partita si è conclusa\nHa vinto il giocatore 1");
                }
                else if(coppieG2 > coppieG1)
                {
                    MessageBox.Show($"La partita si è conclusa\nHa vinto il giocatore 2");
                }
                else
                {
                    MessageBox.Show($"La partita si è conclusa\nPareggio");
                }
            }
        }

        private void assegnazioneSfondoCarteNonCoppie(int cardNum)
        {
            switch (cardNum)
            {
                case 0:
                    carta1.Image = Properties.Resources.sfondo_carta;
                    break;
                case 1:
                    carta2.Image = Properties.Resources.sfondo_carta;
                    break;
                case 2:
                    carta3.Image = Properties.Resources.sfondo_carta;
                    break;
                case 3:
                    carta4.Image = Properties.Resources.sfondo_carta;
                    break;
                case 4:
                    carta5.Image = Properties.Resources.sfondo_carta;
                    break;
                case 5:
                    carta6.Image = Properties.Resources.sfondo_carta;
                    break;
                case 6:
                    carta7.Image = Properties.Resources.sfondo_carta;
                    break;
                case 7:
                    carta8.Image = Properties.Resources.sfondo_carta;
                    break;
            }
        }

        public void wait(int milliseconds)
        {
            //crea un oggetto Timer
            var timer1 = new System.Windows.Forms.Timer();
            //controlla che il valore dei millisecondi non sia 0 o minore di 0
            if (milliseconds == 0 || milliseconds < 0) return;

            // inizia il timer
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            //controlla se il valore inserito in millisecondi è trascorso
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // finisce il timer
            };

            while (timer1.Enabled)//permette di elaborare le azioni che il form riceve
            {
                Application.DoEvents();
            }
        }

        private void restartGame_Click(object sender, EventArgs e)
        {
            carteSelezionate = 0;
            card1 = 0; card2 = 0;
            for (int i = 0; i < 8; i++) { sceltaGiocatore[i] = false; }
            coppieG1 = 0; coppieG2 = 0;
            startGame();
            restartGame.Visible = false;
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

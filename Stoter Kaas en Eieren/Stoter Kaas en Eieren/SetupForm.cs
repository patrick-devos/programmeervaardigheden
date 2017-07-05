using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Stoter_Kaas_en_Eieren
{
    public partial class SetupForm : DevComponents.DotNetBar.Office2007Form
    {
        public SetupForm()
        {
            InitializeComponent();           
        }

        public static Image SpelerFoto1;

        public static Image SpelerFoto2;

        public Image playerImage1
        {
            get
            {
                return this.pictureBox4.Image;
            }
            set
            {
                this.pictureBox4.Image = value;
            }
        }

        public Image picboximage1
        {
            get { return pictureBox4.Image; }
            set { pictureBox4.Image = value; }
        }


        MySqlDataReader DataReader2;
        MySqlConnection Connection2 = new MySqlConnection("Server=hiclothes.nl;Port=3306;Database=dehefnq201_ske;Uid=dehefnq201_skeu;Password=12345678");
        MySqlConnection Connection3 = new MySqlConnection("Server=hiclothes.nl;Port=3306;Database=dehefnq201_ske;Uid=dehefnq201_skeu;Password=12345678");
        MySqlConnection Connection = new MySqlConnection("Server=hiclothes.nl;Port=3306;Database=dehefnq201_ske;Uid=dehefnq201_skeu;Password=12345678");
        MySqlDataReader DataReader;
        MySqlDataReader DataReader3;
        private void Form1_Load(object sender, EventArgs e)
        {
            herlader.Start();
            scorePC.Text = Properties.Settings.Default.scoreJIJ.ToString();
            scoreJIJ.Text = Properties.Settings.Default.scorePC.ToString();


            selTijd.Text = "Oneindig";
            winconditite.Text = "3 op een rij";
            comboBoxEx1.Text = "3";
            comboBoxEx2.Text = "3";
            timer1.Start();
            axWindowsMediaPlayer5.Ctlcontrols.play();


            //Haal aantal spelers 1 op
            MySqlCommand Command;
            Connection.Open();
            string selectQuery = "SELECT * FROM TabelKamer1";
            Command = new MySqlCommand(selectQuery, Connection);
            DataReader = Command.ExecuteReader();
            if (DataReader.Read())
            {
                Kamer1SpelersTXT.Text = DataReader.GetString("kam1spelers");
                kamer1spelers = Convert.ToInt32(Kamer1SpelersTXT.Text);
                aantalKam1Spelers.Text = kamer1spelers.ToString() + "/2";
            }
            else
            {
                MessageBox.Show("Probleem met het ophalen van het aantal spelers.", "Stoter Kaas en Eieren");
            }
            Connection.Close();
            DataReader.Close();


            //Haal aantal spelers 2 op
            MySqlCommand CommandSelecteerSpelers;
            Connection2.Open();
            string SelecteerSpelersQuery = "SELECT * FROM TabelKamer2";
            CommandSelecteerSpelers = new MySqlCommand(SelecteerSpelersQuery, Connection2);
            DataReader2 = CommandSelecteerSpelers.ExecuteReader();
            if (DataReader2.Read())
            {
                Kamer2SpelersTXT.Text = DataReader2.GetString("kam2spelers");
                kamer2spelers = Convert.ToInt32(Kamer2SpelersTXT.Text);
                aantalKam2Spelers.Text = kamer2spelers.ToString() + "/2";
            }
            else
            {
                MessageBox.Show("Probleem met het ophalen van het aantal spelers.", "Stoter Kaas en Eieren");
            }
            Connection2.Close();
            DataReader2.Close();








        }

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            tegenpc.Image = Properties.Resources.btn1_1;
            this.Cursor = Cursors.Hand;
            hoverGeluidje.Ctlcontrols.play();
            
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            tegenpc.Image = Properties.Resources.btn11;
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            online.Image = Properties.Resources.btn2;
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            online.Image = Properties.Resources.btn2_1;
            this.Cursor = Cursors.Hand;
            hoverGeluidje.Ctlcontrols.play();
           
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            nieuwe.Image = Properties.Resources.nieuwe11;
            this.Cursor = Cursors.Hand;
            hoverGeluidje.Ctlcontrols.play();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            nieuwe.Image = Properties.Resources.nieuwe1;
            this.Cursor = Cursors.Default;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            doorgaan.Image = Properties.Resources.doorgaan11;
            this.Cursor = Cursors.Hand;
            hoverGeluidje.Ctlcontrols.play();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            doorgaan.Image = Properties.Resources.doorgaan1;
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            hoverGeluidje.Ctlcontrols.play();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseEnter_3(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            hoverGeluidje.Ctlcontrols.play();
        }

        private void gamex3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void gamex4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void gamex5_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void gamex6_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void gamex6_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            hoverGeluidje.Ctlcontrols.play();
        }

        private void gamex5_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            hoverGeluidje.Ctlcontrols.play();
        }

        private void gamex4_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            hoverGeluidje.Ctlcontrols.play();
        }

        private void pictureBox1_MouseEnter_2(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            hoverGeluidje.Ctlcontrols.play();
        }

        private void startbutton_MouseEnter(object sender, EventArgs e)
        {
            startbutton.Image = Properties.Resources.start11;
            this.Cursor = Cursors.Hand;
            hoverGeluidje.Ctlcontrols.play();
        }

        private void startbutton_MouseLeave(object sender, EventArgs e)
        {
            startbutton.Image = Properties.Resources.start1;
            this.Cursor = Cursors.Default;
        }

        private void terugknop_MouseEnter(object sender, EventArgs e)
        {
            terugknop.Image = Properties.Resources.terug11;
            this.Cursor = Cursors.Hand;
            hoverGeluidje.Ctlcontrols.play();
        }

        private void terugknop_MouseLeave(object sender, EventArgs e)
        {
            terugknop.Image = Properties.Resources.terug1;
            this.Cursor = Cursors.Default;
        }

        private void gameplay_MouseEnter(object sender, EventArgs e)
        {
            gameplay.Visible = false;
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            uploadImage1.Image = Properties.Resources.upload2;
            hoverGeluidje.Ctlcontrols.play();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            uploadImage1.Image = Properties.Resources.upload1;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            uploadImage2.Image = Properties.Resources.upload2;
            hoverGeluidje.Ctlcontrols.play();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            uploadImage2.Image = Properties.Resources.upload2;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            RStartButton.Image = Properties.Resources.butt2;
            hoverGeluidje.Ctlcontrols.play();

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            RStartButton.Image = Properties.Resources.butt1;
        }



        //          ########### MOUSE ENTER-LEAVES ###########      //


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            progressBar1.Increment(100);

            if (progressBar1.Value == 100)
            {

                verderButton.Visible = true;
                timer1.Stop();
                intro_clip.Ctlcontrols.pause();

            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(100);
            if (progressBar1.Value == 100)
            {
                timer2.Stop();
                overgangsAnimatie_Clip.Visible = false;
                gameplay.Visible = true;
                gameplay.BringToFront();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Selecteer een afbeelding";
            opFile.Filter = "jpg bestanden (*.jpg)|*.jpg|Alle bestanden (*.*)|*.*";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;   // <---
                    string filepath = opFile.FileName;    // <---
                    File.Copy(filepath, appPath + iName); // <---


                    //  IMAGES  //
                    pictureBox4.Image = new Bitmap(opFile.OpenFile());
                    SpelerFoto1 = new Bitmap(opFile.OpenFile());

                    // Succes doorgeven
                    Properties.Settings.Default.jouwplaatje = "veranderd";

                }
                catch (Exception exp)
                {
                    MessageBox.Show("Kan bestand niet openen " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e) 
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Selecteer een afbeelding";
            opFile.Filter = "jpg bestanden (*.jpg)|*.jpg|Alle bestanden (*.*)|*.*";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;   // <---
                    string filepath = opFile.FileName;    // <---
                    File.Copy(filepath, appPath + iName); // <---


                    //  IMAGES  //
                    pictureBox5.Image = new Bitmap(opFile.OpenFile());
                    SpelerFoto2 = new Bitmap(opFile.OpenFile());

                    // Succes doorgeven
                    Properties.Settings.Default.pcplaatje = "veranderd";
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Kan bestand niet openen " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEx1.Text != "3")
            {
                MessageBox.Show("Een groter bord is alleen beschikbaar voor de pro-versie van Stoter Kaas en Eieren", "Stoter Kaas en Eieren");
                comboBoxEx1.Text = "3";
            }
        }

        private void comboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEx2.Text != "3")
            {
                MessageBox.Show("Een groter bord is alleen beschikbaar voor de pro-versie van Stoter Kaas en Eieren", "Stoter Kaas en Eieren");
                comboBoxEx2.Text = "3";
            }
        }




        //          ########### MINDER BELANGRIJK ###########      //



        private void terugknop_Click(object sender, EventArgs e)            //TERUG KNOP                  ALLE SCHERMEN       
        {
            uploadImage1.Visible = false;
            uploadImage2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            comboBoxEx1.Visible = false;
            comboBoxEx2.Visible = false;

            topbackground.Image = Properties.Resources.background;
            this.BackgroundImage = Properties.Resources.background;
            selTijd.Visible = false;
            winconditite.Visible = false;
            comboBoxEx1.Visible = false;
            comboBoxEx2.Visible = false;
            RStartButton.Visible = false;
            nieuwe.Visible = false;
            doorgaan.Visible = false;
            tegenpc.Visible = true;
            online.Visible = true;
            terugknop.Visible = false;
            poppetje.Visible = false;
            startbutton.Visible = false;
            nieuwe.Visible = false;
            doorgaan.Visible = false;
            scoreJIJ.Visible = false;
            scorePC.Visible = false;
            kamerDeur1.Visible = false;
            kamerDeur2.Visible = false;

            aantalKam1Spelers.Visible = false;
            aantalKam2Spelers.Visible = false;

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)        //verderButton                SCHERM 0            
        {

            this.BackgroundImage = Properties.Resources.m;
            verderButton.Visible = false;

            intro_clip.Ctlcontrols.play();
            intro_clip.Visible = false;
            overgangsAnimatie_Clip.Visible = true;
            overgangsAnimatie_Clip.BringToFront();

            timer2.Start();
            //Ga verder met muziek
            axWindowsMediaPlayer2.Ctlcontrols.play();
            //laat de video zien
            overgangsAnimatie_Clip.Ctlcontrols.play();
            //stop oude muziek
            axWindowsMediaPlayer5.Ctlcontrols.stop();
        }

        private void online_Click(object sender, EventArgs e)               //Online Button               ScHERM 1             
        {
            online.Visible = false;
            tegenpc.Visible = false;
            topbackground.Image = Properties.Resources.kamerbackground;
            this.BackgroundImage = Properties.Resources.kamerbackground;
            terugknop.Visible = true;
            kamerDeur1.Visible = true;
            kamerDeur2.Visible = true;
            aantalKam1Spelers.Visible = true;
            aantalKam2Spelers.Visible = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)        //TEGEN COMPUTER              SCHERM 1            
        {
            topbackground.Image = Properties.Resources.scherm;
            this.BackgroundImage = Properties.Resources.game;
            tegenpc.Visible = false;
            online.Visible = false;
            nieuwe.Visible = true;
            doorgaan.Visible = true;
            terugknop.Visible = true;
            scoreJIJ.Visible = true;
            scorePC.Visible = true;
        }
                
        private void nieuwe_Click(object sender, EventArgs e)               //NIEUW SPEL                  SCHERM 2            
        {
            Properties.Settings.Default.scoreJIJ = 0;
            Properties.Settings.Default.scorePC = 0;
            startbutton.Visible = true;
            startbutton.BringToFront();
            poppetje.Visible = true;
            nieuwe.Visible = false;
            doorgaan.Visible = false;
            tegenpc.Visible = false;
            online.Visible = false;
            this.BackgroundImage = Properties.Resources.optionscreen;
            topbackground.Image = Properties.Resources.optionscreen;
            comboBoxEx1.Visible = true;
            comboBoxEx2.Visible = true;
            uploadImage1.Visible = true;
            uploadImage2.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            scoreJIJ.Visible = false;
            scorePC.Visible = false;

        }

        private void doorgaan_Click(object sender, EventArgs e)             //Doorgaan Button             SCHERM 2            
        {
            this.Hide();
            GameForm gamePlay = new GameForm();
            gamePlay.Show();
        }

        private void startbutton_Click(object sender, EventArgs e)          //VOLGENDE BUTTON             SCHERM 3            
        {
            this.BackgroundImage = Properties.Resources.tijd;
            topbackground.Image = Properties.Resources.tijd;

            uploadImage1.Visible = false;
            uploadImage2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            comboBoxEx1.Visible = false;
            comboBoxEx2.Visible = false;
            comboBoxEx1.Visible = false;
            comboBoxEx2.Visible = false;
            startbutton.Visible = false;

            winconditite.Visible = true;
            RStartButton.Visible = true;
            selTijd.Visible = true;

            //selectie grootte bord maken
            int linksbord, rechtsbord;
            linksbord = Convert.ToInt32(comboBoxEx1.Text);
            rechtsbord = Convert.ToInt32(comboBoxEx2.Text);
            if(linksbord == 3 && rechtsbord == 3)
            {
                wincon4.Text = "";
                wincon5.Text = "";
                wincon6.Text = "";
                wincon7.Text = "";
            }
            if(linksbord == 3 && rechtsbord == 4)
            {
                wincon5.Text = "";
                wincon6.Text = "";
                wincon7.Text = "";
            }
            if (linksbord == 3 && rechtsbord == 5)
            {
                wincon6.Text = "";
                wincon7.Text = "";
            }
            if (linksbord == 3 && rechtsbord == 6)
            {
                wincon7.Text = "";
            }
            if (linksbord == 3 && rechtsbord == 7)
            {
                
            }
            if (linksbord == 4 && rechtsbord == 3)
            {
                wincon5.Text = "";
                wincon6.Text = "";
                wincon7.Text = "";
            }
            if (linksbord == 4 && rechtsbord == 4)
            {
                wincon5.Text = "";
                wincon6.Text = "";
                wincon7.Text = "";
            }
            if (linksbord == 4 && rechtsbord == 5)
            {
                wincon6.Text = "";
                wincon7.Text = "";
            }
            if (linksbord == 4 && rechtsbord == 6)
            {
                wincon7.Text = "";
            }
            if (linksbord == 4 && rechtsbord == 7)
            {
                
            }
            if (linksbord == 5 && rechtsbord == 3)
            {
                wincon6.Text = "";
                wincon7.Text = "";
            }
            if (linksbord == 5 && rechtsbord == 4)
            {
                wincon6.Text = "";
                wincon7.Text = "";
            }
            if (linksbord == 5 && rechtsbord == 5)
            {
                wincon6.Text = "";
                wincon7.Text = "";
            }
            if (linksbord == 5 && rechtsbord == 6)
            {
                wincon7.Text = "";
            }
            if (linksbord == 5 && rechtsbord == 7)
            {
                
            }
            if (linksbord == 6 && rechtsbord == 3)
            {
                wincon7.Text = "";
            }
            if (linksbord == 6 && rechtsbord == 4)
            {
                wincon7.Text = "";
            }
            if (linksbord == 6 && rechtsbord == 5)
            {
                wincon7.Text = "";
            }
            if (linksbord == 6 && rechtsbord == 6)
            {
                wincon7.Text = "";
            }
            if (linksbord == 6 && rechtsbord == 7)
            {
               
            }


        }

        private void RStartButton_Click(object sender, EventArgs e)         //Start                       SCHERM 4            
        {
            if(winconditite.Text == "")
            {
                MessageBox.Show("Fout met het invullen van de winconditie", "Stoter Kaas en Eieren");
            }
            else if(comboBoxEx1.Text == "3" && comboBoxEx2.Text == "3"){
                Properties.Settings.Default.linkergrootte = comboBoxEx1.Text;
                Properties.Settings.Default.rechtergrootte = comboBoxEx2.Text;
                Properties.Settings.Default.tijd = selTijd.Text;
                this.Hide();
                GameForm game = new GameForm();
                game.Show();

            }else
            {
                MessageBox.Show("Deze functie is alleen voor pro mensen","Stoter Kaas en Eieren");
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(aantalKam1Spelers.Text == "1/2" && aantalKam1Spelers.ForeColor == Color.Green)
            {
                //code update -1 in de database
            }else if(aantalKam1Spelers.Text == "2/2" && aantalKam1Spelers.ForeColor == Color.Green)
            {
                //code update -1 in database
            }
            if (aantalKam2Spelers.Text == "1/2" && aantalKam2Spelers.ForeColor == Color.Green)
            {
                //code update -1 in de database
            }
            else if (aantalKam2Spelers.Text == "2/2" && aantalKam2Spelers.ForeColor == Color.Green)
            {
                //code update -1 in database
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void gameplay_Click(object sender, EventArgs e)
        {

        }

        public int kamer1spelers;
        public int kamer2spelers;
        private void kamerDeur1_Click(object sender, EventArgs e)
        {
            //Wanneer er 0 spelers in zitten
            if (kamer1spelers == 0)
            {
                //Update TabelKamer
                Properties.Settings.Default.ditIsSpeler = "speler1";
                kamerDeur1.Enabled = false;
                kamerDeur2.Enabled = false;
                aantalKam1Spelers.ForeColor = Color.Green;
                MySqlCommand Command2;
                Connection.Open();
                string UpdateAantalSpelers = "update TabelKamer1 set kam1spelers='" + ++kamer1spelers + "' ; ";
                Command2 = new MySqlCommand(UpdateAantalSpelers, Connection);
                DataReader = Command2.ExecuteReader();
                DataReader.Close();

                //Update kamer1spelers INT LOCAL
                MySqlCommand Command3;
                string updateInteger = "SELECT * FROM TabelKamer1";
                Command3 = new MySqlCommand(updateInteger, Connection);
                DataReader = Command3.ExecuteReader();
                if (DataReader.Read())
                {
                    Kamer1SpelersTXT.Text = DataReader.GetString("kam1spelers");
                    kamer1spelers = Convert.ToInt32(Kamer1SpelersTXT.Text);
                    aantalKam1Spelers.Text = kamer1spelers.ToString() + "/2";
                }
                Connection.Close();
                DataReader.Close();

                //Update speler1 in Lobby1
                //..
                MySqlCommand Command7;
                Connection3.Open();
                string queryUpdateSpeler1Lobby1 = "update Lobby1 set speler1='Speler1Joined' ; ";
                Command7 = new MySqlCommand(queryUpdateSpeler1Lobby1, Connection3);
                DataReader3 = Command7.ExecuteReader();
                DataReader3.Close();
                Connection3.Close();

                //Update speler1 in Lobby1 LOCAL LABEL
                MySqlCommand Command8;
                Connection3.Open();
                string queryUpdateSpeler1Lobby1Local = "SELECT speler1 FROM Lobby1";
                Command8 = new MySqlCommand(queryUpdateSpeler1Lobby1Local, Connection3);
                DataReader3 = Command8.ExecuteReader();
                if (DataReader3.Read())
                {
                    kijkSpeler1Label.Text = DataReader3.GetString("speler1");
                    Properties.Settings.Default.speler1 = "Speler1Joined";
                }
                Connection3.Close();
                DataReader3.Close();



            }
            else if(kamer1spelers == 1)
            {
                //Update TabelKamer
                Properties.Settings.Default.ditIsSpeler = "speler2";
                aantalKam1Spelers.ForeColor = Color.Green;
                kamerDeur1.Enabled = false;
                kamerDeur2.Enabled = false;
                MySqlCommand Command4;
                Connection.Open();
                string UpdateAantalSpelers2 = "update TabelKamer1 set kam1spelers='" + ++kamer1spelers + "' ; ";
                Command4 = new MySqlCommand(UpdateAantalSpelers2, Connection);
                DataReader = Command4.ExecuteReader();
                DataReader.Close();

                //Update kamer1spelers INT LOCAL
                MySqlCommand Command5;
                string updateInteger5 = "SELECT * FROM TabelKamer1";
                Command5 = new MySqlCommand(updateInteger5, Connection);
                DataReader = Command5.ExecuteReader();
                if (DataReader.Read())
                {
                    Kamer1SpelersTXT.Text = DataReader.GetString("kam1spelers");
                    kamer1spelers = Convert.ToInt32(Kamer1SpelersTXT.Text);
                    aantalKam1Spelers.Text = kamer1spelers.ToString() + "/2";
                }
                DataReader.Close();
                Connection.Close();

                //Update speler2 in Lobby1
                //..
                MySqlCommand Command0;
                Connection3.Open();
                string queryUpdateSpeler2Lobby1 = "update Lobby1 set speler2='Speler2Joined' ; ";
                Command0 = new MySqlCommand(queryUpdateSpeler2Lobby1, Connection3);
                DataReader3 = Command0.ExecuteReader();
                DataReader3.Close();
                Connection3.Close();

                //Update speler2 in Lobby1 LOCAL LABEL
                MySqlCommand Command22;
                Connection3.Open();
                string queryUpdateSpeler1Lobby1Local = "SELECT speler2 FROM Lobby1";
                Command22 = new MySqlCommand(queryUpdateSpeler1Lobby1Local, Connection3);
                DataReader3 = Command22.ExecuteReader();
                if (DataReader3.Read())
                {
                    kijkSpeler2Label.Text = DataReader3.GetString("speler2");
                    Properties.Settings.Default.speler2 = "Speler2Joined";
                }
                Connection3.Close();
                DataReader3.Close();





            }
            else if(kamer1spelers == 2)
            {
                MessageBox.Show("De kamer zit vol", "Stoter Kaas en Eieren");
            }
        }

        private void kamerDeur2_Click(object sender, EventArgs e)
        {
            if (kamer2spelers == 0)
            {
                Properties.Settings.Default.ditIsSpeler = "speler2";
                aantalKam1Spelers.ForeColor = Color.Green;
                kamerDeur1.Enabled = false;
                kamerDeur2.Enabled = false;
                //update in de database
                MySqlCommand CommandSpelerErbij;
                Connection2.Open();
                string QueryUpdateSpelers = "update TabelKamer2 set kam2spelers='" + ++kamer2spelers + "' ; ";
                CommandSpelerErbij = new MySqlCommand(QueryUpdateSpelers, Connection2);
                DataReader2 = CommandSpelerErbij.ExecuteReader();
                DataReader2.Close();

                //update lokaal
                MySqlCommand CommandUpdateInt;
                string QueryUpdateInt = "SELECT * FROM TabelKamer2";
                CommandUpdateInt = new MySqlCommand(QueryUpdateInt, Connection2);
                DataReader2 = CommandUpdateInt.ExecuteReader();
                if (DataReader2.Read())
                {
                    Kamer2SpelersTXT.Text = DataReader2.GetString("kam2spelers");
                    kamer2spelers = Convert.ToInt32(Kamer2SpelersTXT.Text);
                    aantalKam2Spelers.Text = kamer2spelers.ToString() + "/2";
                }
                Connection2.Close();
                DataReader2.Close();
            }
            else if (kamer2spelers == 1)
            {
                Properties.Settings.Default.ditIsSpeler = "speler2";

                aantalKam1Spelers.ForeColor = Color.Green;
                kamerDeur1.Enabled = false;
                kamerDeur2.Enabled = false;
                //update in database
                MySqlCommand CommandSpelerErbij2;
                Connection2.Open();
                string QueryUpdateSpelerz = "update TabelKamer2 set kam2spelers='" + ++kamer2spelers + "' ; ";
                CommandSpelerErbij2 = new MySqlCommand(QueryUpdateSpelerz, Connection2);
                DataReader2 = CommandSpelerErbij2.ExecuteReader();
                DataReader2.Close();

                MySqlCommand CommandSelecteerSel;
                string QuerySelectData = "SELECT * FROM TabelKamer2";
                CommandSelecteerSel = new MySqlCommand(QuerySelectData, Connection2);
                DataReader2 = CommandSelecteerSel.ExecuteReader();
                if (DataReader2.Read())
                {
                    Kamer2SpelersTXT.Text = DataReader2.GetString("kam2spelers");
                    kamer2spelers = Convert.ToInt32(Kamer2SpelersTXT.Text);
                    aantalKam2Spelers.Text = kamer2spelers.ToString() + "/2";
                }
                DataReader2.Close();
                Connection2.Close();
            }
            else if (kamer2spelers == 2)
            {

                MessageBox.Show("De kamer zit vol", "Stoter Kaas en Eieren");
            }


        }

        private void aantalKam1Spelers_Click(object sender, EventArgs e)
        {

        }

        private void herlader_Tick(object sender, EventArgs e)
        {
            progressBar3.Increment(5);
            if(progressBar3.Value == 100)
            {
                herlader.Stop();
                progressBar3.Value = 0;
                herlader.Start();

                if(aantalKam1Spelers.Text == "2/2" && aantalKam1Spelers.ForeColor == Color.Green)
                {
                    setupOnline setuponline = new setupOnline();
                    this.Hide();
                    setuponline.Show();
                    herlader.Stop();

                    //
                }


                MySqlCommand CommandSelecteerSel;
                Connection2.Open();
                string QuerySelectData = "SELECT * FROM TabelKamer1";
                CommandSelecteerSel = new MySqlCommand(QuerySelectData, Connection2);
                DataReader2 = CommandSelecteerSel.ExecuteReader();
                if (DataReader2.Read())
                {
                    aantalKam1Spelers.Text = DataReader2.GetString("kam1spelers") + "/2";
                    Kamer1SpelersTXT.Text = DataReader2.GetString("kam1spelers");
                    kamer1spelers = Convert.ToInt32(Kamer1SpelersTXT.Text);
                }
                DataReader2.Close();
                Connection2.Close();





            }
        }
    }
}

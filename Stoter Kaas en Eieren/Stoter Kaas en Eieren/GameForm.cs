using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoter_Kaas_en_Eieren
{
    public partial class GameForm : DevComponents.DotNetBar.Office2007Form
    {

        public GameForm()
        {
            InitializeComponent();
        }

        public int incrementValue;
        private void game_Load(object sender, EventArgs e)
        {
            jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString() ;
            pcscore.Text = Properties.Settings.Default.scorePC.ToString();

            speler1.Image = SetupForm.SpelerFoto1;
            speler2.Image = SetupForm.SpelerFoto2;

            if (Properties.Settings.Default.tijd == "Oneindig")
            {
                //alleTijd.Visible = true;
                progressBarX1.Visible = false;
                tijdPercentage.Visible = false;
               
            }else if(Properties.Settings.Default.tijd == "2 sec")
            {
                incrementValue = 10;
                timer1.Interval = 200;
                timer1.Start();
            }
            else if (Properties.Settings.Default.tijd == "5 sec")
            {
                incrementValue = 10;
                timer1.Interval = 500;
                timer1.Start();
            }
            else if (Properties.Settings.Default.tijd == "10 sec")
            {
                incrementValue = 10;
                timer1.Interval = 1000; 
                timer1.Start();
            }
            else if (Properties.Settings.Default.tijd == "15 sec")
            {
                incrementValue = 10;
                timer1.Interval = 1500;
                timer1.Start();
            }
            else if (Properties.Settings.Default.tijd == "20 sec")
            {
                incrementValue = 10;
                timer1.Interval = 2000;
                timer1.Start();
            }

        }

        private void game_FormClosing(object sender, FormClosingEventArgs e)
        {

            
                DialogResult dialogResult = MessageBox.Show("Wilt u uw score opslaan?", "Stoter Kaas en Eieren", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Properties.Settings.Default.Save();
                    this.BackColor = Color.Green;
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.BackColor = Color.Green;
                    Properties.Settings.Default.scoreJIJ = 0;
                    Properties.Settings.Default.tijd = "";
                    Properties.Settings.Default.scorePC = 0;
                    Properties.Settings.Default.Save();
                }
               
           
            
            Properties.Settings.Default.jouwplaatje = "";
            Properties.Settings.Default.pcplaatje = "";
        }

        private void game_BackColorChanged(object sender, EventArgs e)
        {
            SetupForm frm1 = new SetupForm();
            frm1.Close();
            this.Close();
        }

        private void verlaat_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Wilt u uw score opslaan?", "Stoter Kaas en Eieren", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.Save();
                this.BackColor = Color.Green;
            }
            else if (dialogResult == DialogResult.No)
            {
                Properties.Settings.Default.Save();
                Properties.Settings.Default.scoreJIJ = 0;
                Properties.Settings.Default.scorePC = 0;
                this.BackColor = Color.Green;
            }

        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            //achtergrond veranderen @menu visible
            topbackground.Image = Properties.Resources.scherm1;
            this.BackgroundImage = Properties.Resources.scherm1;
            //openMenu picturebox niet meer visible
            openMenu.Visible = false;

            //menu items visible
            verlaat_btn.Visible = true;
            contact_btn.Visible = true;
            stelin_btn.Visible = true;
            shop_btn.Visible = true;
            reset_btn.Visible = true;

            //Close menu visible
            closeMenu.Visible = true;
            openMenu.Visible = false;
               
        }

        private void closeMenu_Click(object sender, EventArgs e)
        {
            //achtergrond veranderen
            topbackground.Image = Properties.Resources.scherm0;
            this.BackgroundImage = Properties.Resources.scherm0;
            //openMenu picturebox niet visible
            openMenu.Visible = true;

            //menu items niet visible
            verlaat_btn.Visible = false;
            contact_btn.Visible = false;
            stelin_btn.Visible = false;
            shop_btn.Visible = false;
            reset_btn.Visible = false;

            //open menu visible
            openMenu.Visible = true;
            closeMenu.Visible = false;

        }

        private void contact_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gmail.com/");
        }

        private void stelin_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            SetupForm frm = new SetupForm();
            frm.Show();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u de score wil resetten?", "Stoter Kaas en Eieren", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.scoreJIJ = 0;
                Properties.Settings.Default.scorePC = 0;
                Properties.Settings.Default.Save();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.BackColor = Color.Green;
                Properties.Settings.Default.Save();
            }

        }

        private void shop_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("De shop is alleen beschikbaar voor de pro-versie van Stoter Kaas en Eieren", "Stoter Kaas en Eieren");
        }

        private void kn17_Click_1(object sender, EventArgs e)
        {
            //Knop ingedrukt
            if (Properties.Settings.Default.jouwplaatje == "veranderd")
            {
                kn17.Image = speler1.Image;
                kn17.Enabled = false;
                text17.Text = "x";
            }
            else
            {
                kn17.Image = Properties.Resources.X;
                kn17.Enabled = false;
                text17.Text = "x";
            }
            /*

                REACTIE COMPUTER

            */
            if (kn19.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn19.Image = speler2.Image;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
                else
                {
                    kn19.Image = Properties.Resources._0;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }

            }
            else if (kn33.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn33.Image = speler2.Image;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
                else
                {
                    kn33.Image = Properties.Resources._0;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
            }
            else if (kn31.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn31.Image = speler2.Image;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
                else
                {
                    kn31.Image = Properties.Resources._0;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
            }
            else if (kn25.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn25.Image = speler2.Image;
                    kn25.Enabled = false;
                    text25.Text = "o";
                }
                else
                {
                    kn25.Image = Properties.Resources._0;
                    kn25.Enabled = false;
                    text25.Text = "o";
                }
            }
            else if (kn26.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn26.Image = speler2.Image;
                    kn26.Enabled = false;
                    kn26.Text = "o";
                }
                else
                {
                    kn26.Image = Properties.Resources._0;
                    kn26.Enabled = false;
                    text26.Text = "o";
                }
            }
            else if (kn24.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn24.Image = speler2.Image;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
                else
                {
                    kn24.Image = Properties.Resources._0;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
            }
            else if (kn32.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn32.Image = speler2.Image;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
                else
                {
                    kn32.Image = Properties.Resources._0;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
            }
            else if (kn18.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn18.Image = speler2.Image;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }
                else
                {
                    kn18.Image = Properties.Resources._0;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }
            }
            //$$$$ KRUISJE WINOPTIES
            if (text17.Text == "x" && text25.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text25.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text19.Text == "x" && text26.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text18.Text == "x" && text25.Text == "x" && text32.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text24.Text == "x" && text31.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text32.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text24.Text == "x" && text25.Text == "x" && text26.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text18.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            //$$$$$ RONDJE WINOPTIES
            if (text17.Text == "o" && text25.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text25.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text19.Text == "o" && text26.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text18.Text == "o" && text25.Text == "o" && text32.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text24.Text == "o" && text31.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text32.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text24.Text == "o" && text25.Text == "o" && text26.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text18.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }



        }

        private void kn18_Click(object sender, EventArgs e)
        {
            //Knop ingedrukt
            if (Properties.Settings.Default.jouwplaatje == "veranderd")
            {
                kn18.Image = speler1.Image;
                kn18.Enabled = false;
                text18.Text = "x";
            }
            else
            {
                kn18.Image = Properties.Resources.X;
                kn18.Enabled = false;
                text18.Text = "x";
            }
            /*

                REACTIE COMPUTER

            */
            if (kn19.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn19.Image = speler2.Image;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
                else
                {
                    kn19.Image = Properties.Resources._0;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }

            }
            else if (kn33.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn33.Image = speler2.Image;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
                else
                {
                    kn33.Image = Properties.Resources._0;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
            }
            else if (kn31.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn31.Image = speler2.Image;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
                else
                {
                    kn31.Image = Properties.Resources._0;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
            }
            else if (kn25.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn25.Image = speler2.Image;
                    kn25.Enabled = false;
                    text25.Text = "o";
                }
                else
                {
                    kn25.Image = Properties.Resources._0;
                    kn25.Enabled = false;
                    text25.Text = "o";
                }
            }
            else if (kn26.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn26.Image = speler2.Image;
                    kn26.Enabled = false;
                    kn26.Text = "o";
                }
                else
                {
                    kn26.Image = Properties.Resources._0;
                    kn26.Enabled = false;
                    text26.Text = "o";
                }
            }
            else if (kn24.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn24.Image = speler2.Image;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
                else
                {
                    kn24.Image = Properties.Resources._0;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
            }
            else if (kn32.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn32.Image = speler2.Image;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
                else
                {
                    kn32.Image = Properties.Resources._0;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
            }
            else if (kn17.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn17.Image = speler2.Image;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
                else
                {
                    kn17.Image = Properties.Resources._0;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
            }
            //$$$$ KRUISJE WINOPTIES
            if (text17.Text == "x" && text25.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text25.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text19.Text == "x" && text26.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text18.Text == "x" && text25.Text == "x" && text32.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text24.Text == "x" && text31.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text32.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text24.Text == "x" && text25.Text == "x" && text26.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text18.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            //$$$$$ RONDJE WINOPTIES
            if (text17.Text == "o" && text25.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text25.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text19.Text == "o" && text26.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text18.Text == "o" && text25.Text == "o" && text32.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text24.Text == "o" && text31.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text32.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text24.Text == "o" && text25.Text == "o" && text26.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text18.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }



        }

        private void kn19_Click(object sender, EventArgs e)
        {
            //Knop ingedrukt
            if (Properties.Settings.Default.jouwplaatje == "veranderd")
            {
                kn19.Image = speler1.Image;
                kn19.Enabled = false;
                text19.Text = "x";
            }
            else
            {
                kn19.Image = Properties.Resources.X;
                kn19.Enabled = false;
                text19.Text = "x";
            }
            /*

                REACTIE COMPUTER

            */
            if (kn18.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn18.Image = speler2.Image;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }
                else
                {
                    kn18.Image = Properties.Resources._0;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }

            }
            else if (kn33.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn33.Image = speler2.Image;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
                else
                {
                    kn33.Image = Properties.Resources._0;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
            }
            else if (kn31.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn31.Image = speler2.Image;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
                else
                {
                    kn31.Image = Properties.Resources._0;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
            }
            else if (kn25.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn25.Image = speler2.Image;
                    kn25.Enabled = false;
                    text25.Text = "o";
                }
                else
                {
                    kn25.Image = Properties.Resources._0;
                    kn25.Enabled = false;
                    text25.Text = "o";
                }
            }
            else if (kn26.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn26.Image = speler2.Image;
                    kn26.Enabled = false;
                    kn26.Text = "o";
                }
                else
                {
                    kn26.Image = Properties.Resources._0;
                    kn26.Enabled = false;
                    text26.Text = "o";
                }
            }
            else if (kn24.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn24.Image = speler2.Image;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
                else
                {
                    kn24.Image = Properties.Resources._0;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
            }
            else if (kn32.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn32.Image = speler2.Image;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
                else
                {
                    kn32.Image = Properties.Resources._0;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
            }
            else if (kn17.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn17.Image = speler2.Image;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
                else
                {
                    kn17.Image = Properties.Resources._0;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
            }
            //$$$$ KRUISJE WINOPTIES
            if (text17.Text == "x" && text25.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text25.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text19.Text == "x" && text26.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text18.Text == "x" && text25.Text == "x" && text32.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text24.Text == "x" && text31.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text32.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text24.Text == "x" && text25.Text == "x" && text26.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text18.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            //$$$$$ RONDJE WINOPTIES
            if (text17.Text == "o" && text25.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text25.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text19.Text == "o" && text26.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text18.Text == "o" && text25.Text == "o" && text32.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text24.Text == "o" && text31.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text32.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text24.Text == "o" && text25.Text == "o" && text26.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text18.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }

        }

        private void kn24_Click(object sender, EventArgs e)
        {
            //Knop ingedrukt
            if (Properties.Settings.Default.jouwplaatje == "veranderd")
            {
                kn24.Image = speler1.Image;
                kn24.Enabled = false;
                text24.Text = "x";
            }
            else
            {
                kn24.Image = Properties.Resources.X;
                kn24.Enabled = false;
                text24.Text = "x";
            }
            /*

                REACTIE COMPUTER

            */
            if (kn18.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn18.Image = speler2.Image;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }
                else
                {
                    kn18.Image = Properties.Resources._0;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }

            }
            else if (kn33.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn33.Image = speler2.Image;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
                else
                {
                    kn33.Image = Properties.Resources._0;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
            }
            else if (kn31.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn31.Image = speler2.Image;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
                else
                {
                    kn31.Image = Properties.Resources._0;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
            }
            else if (kn25.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn25.Image = speler2.Image;
                    kn25.Enabled = false;
                    text25.Text = "o";
                }
                else
                {
                    kn25.Image = Properties.Resources._0;
                    kn25.Enabled = false;
                    text25.Text = "o";
                }
            }
            else if (kn26.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn26.Image = speler2.Image;
                    kn26.Enabled = false;
                    kn26.Text = "o";
                }
                else
                {
                    kn26.Image = Properties.Resources._0;
                    kn26.Enabled = false;
                    text26.Text = "o";
                }
            }
            else if (kn19.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn19.Image = speler2.Image;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
                else
                {
                    kn19.Image = Properties.Resources._0;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
            }
            else if (kn32.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn32.Image = speler2.Image;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
                else
                {
                    kn32.Image = Properties.Resources._0;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
            }
            else if (kn17.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn17.Image = speler2.Image;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
                else
                {
                    kn17.Image = Properties.Resources._0;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
            }
            //$$$$ KRUISJE WINOPTIES
            if (text17.Text == "x" && text25.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text25.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text19.Text == "x" && text26.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text18.Text == "x" && text25.Text == "x" && text32.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text24.Text == "x" && text31.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text32.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text24.Text == "x" && text25.Text == "x" && text26.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text18.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            //$$$$$ RONDJE WINOPTIES
            if (text17.Text == "o" && text25.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text25.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text19.Text == "o" && text26.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text18.Text == "o" && text25.Text == "o" && text32.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text24.Text == "o" && text31.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text32.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text24.Text == "o" && text25.Text == "o" && text26.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text18.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }

        }

        private void kn25_Click(object sender, EventArgs e)
        {
            //Knop ingedrukt
            if (Properties.Settings.Default.jouwplaatje == "veranderd")
            {
                kn25.Image = speler1.Image;
                kn25.Enabled = false;
                text25.Text = "x";
            }
            else
            {
                kn25.Image = Properties.Resources.X;
                kn25.Enabled = false;
                text25.Text = "x";
            }
            /*

                REACTIE COMPUTER

            */
            if (kn18.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn18.Image = speler2.Image;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }
                else
                {
                    kn18.Image = Properties.Resources._0;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }

            }
            else if (kn33.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn33.Image = speler2.Image;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
                else
                {
                    kn33.Image = Properties.Resources._0;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
            }
            else if (kn31.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn31.Image = speler2.Image;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
                else
                {
                    kn31.Image = Properties.Resources._0;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
            }
            else if (kn24.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn24.Image = speler2.Image;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
                else
                {
                    kn24.Image = Properties.Resources._0;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
            }
            else if (kn26.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn26.Image = speler2.Image;
                    kn26.Enabled = false;
                    kn26.Text = "o";
                }
                else
                {
                    kn26.Image = Properties.Resources._0;
                    kn26.Enabled = false;
                    text26.Text = "o";
                }
            }
            else if (kn19.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn19.Image = speler2.Image;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
                else
                {
                    kn19.Image = Properties.Resources._0;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
            }
            else if (kn32.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn32.Image = speler2.Image;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
                else
                {
                    kn32.Image = Properties.Resources._0;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
            }
            else if (kn17.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn17.Image = speler2.Image;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
                else
                {
                    kn17.Image = Properties.Resources._0;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
            }
            //$$$$ KRUISJE WINOPTIES
            if (text17.Text == "x" && text25.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text25.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text19.Text == "x" && text26.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text18.Text == "x" && text25.Text == "x" && text32.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text24.Text == "x" && text31.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text32.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text24.Text == "x" && text25.Text == "x" && text26.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text18.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            //$$$$$ RONDJE WINOPTIES
            if (text17.Text == "o" && text25.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text25.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text19.Text == "o" && text26.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text18.Text == "o" && text25.Text == "o" && text32.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text24.Text == "o" && text31.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text32.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text24.Text == "o" && text25.Text == "o" && text26.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text18.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }

        }

        private void kn26_Click(object sender, EventArgs e)
        {
            //Knop ingedrukt
            if (Properties.Settings.Default.jouwplaatje == "veranderd")
            {
                kn26.Image = speler1.Image;
                kn26.Enabled = false;
                text26.Text = "x";
            }
            else
            {
                kn26.Image = Properties.Resources.X;
                kn26.Enabled = false;
                text26.Text = "x";
            }
            /*

                REACTIE COMPUTER

            */
            if (kn18.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn18.Image = speler2.Image;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }
                else
                {
                    kn18.Image = Properties.Resources._0;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }

            }
            else if (kn33.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn33.Image = speler2.Image;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
                else
                {
                    kn33.Image = Properties.Resources._0;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
            }
            else if (kn31.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn31.Image = speler2.Image;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
                else
                {
                    kn31.Image = Properties.Resources._0;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
            }
            else if (kn24.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn24.Image = speler2.Image;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
                else
                {
                    kn24.Image = Properties.Resources._0;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
            }
            else if (kn25.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn25.Image = speler2.Image;
                    kn25.Enabled = false;
                    kn25.Text = "o";
                }
                else
                {
                    kn25.Image = Properties.Resources._0;
                    kn25.Enabled = false;
                    text25.Text = "o";
                }
            }
            else if (kn19.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn19.Image = speler2.Image;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
                else
                {
                    kn19.Image = Properties.Resources._0;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
            }
            else if (kn32.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn32.Image = speler2.Image;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
                else
                {
                    kn32.Image = Properties.Resources._0;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
            }
            else if (kn17.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn17.Image = speler2.Image;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
                else
                {
                    kn17.Image = Properties.Resources._0;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
            }
            //$$$$ KRUISJE WINOPTIES
            if (text17.Text == "x" && text25.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text25.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text19.Text == "x" && text26.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text18.Text == "x" && text25.Text == "x" && text32.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text24.Text == "x" && text31.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text32.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text24.Text == "x" && text25.Text == "x" && text26.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text18.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            //$$$$$ RONDJE WINOPTIES
            if (text17.Text == "o" && text25.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text25.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text19.Text == "o" && text26.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text18.Text == "o" && text25.Text == "o" && text32.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text24.Text == "o" && text31.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text32.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text24.Text == "o" && text25.Text == "o" && text26.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text18.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }

        }

        private void kn31_Click(object sender, EventArgs e)
        {
            //Knop ingedrukt
            if (Properties.Settings.Default.jouwplaatje == "veranderd")
            {
                kn31.Image = speler1.Image;
                kn31.Enabled = false;
                text31.Text = "x";
            }
            else
            {
                kn31.Image = Properties.Resources.X;
                kn31.Enabled = false;
                text31.Text = "x";
            }
            /*

                REACTIE COMPUTER

            */
            if (kn18.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn18.Image = speler2.Image;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }
                else
                {
                    kn18.Image = Properties.Resources._0;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }

            }
            else if (kn33.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn33.Image = speler2.Image;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
                else
                {
                    kn33.Image = Properties.Resources._0;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
            }
            else if (kn26.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn26.Image = speler2.Image;
                    kn26.Enabled = false;
                    text26.Text = "o";
                }
                else
                {
                    kn26.Image = Properties.Resources._0;
                    kn26.Enabled = false;
                    text26.Text = "o";
                }
            }
            else if (kn24.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn24.Image = speler2.Image;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
                else
                {
                    kn24.Image = Properties.Resources._0;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
            }
            else if (kn25.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn25.Image = speler2.Image;
                    kn25.Enabled = false;
                    kn25.Text = "o";
                }
                else
                {
                    kn25.Image = Properties.Resources._0;
                    kn25.Enabled = false;
                    text25.Text = "o";
                }
            }
            else if (kn19.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn19.Image = speler2.Image;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
                else
                {
                    kn19.Image = Properties.Resources._0;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
            }
            else if (kn32.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn32.Image = speler2.Image;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
                else
                {
                    kn32.Image = Properties.Resources._0;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
            }
            else if (kn17.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn17.Image = speler2.Image;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
                else
                {
                    kn17.Image = Properties.Resources._0;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
            }
            //$$$$ KRUISJE WINOPTIES
            if (text17.Text == "x" && text25.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text25.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text19.Text == "x" && text26.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text18.Text == "x" && text25.Text == "x" && text32.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text24.Text == "x" && text31.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text32.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text24.Text == "x" && text25.Text == "x" && text26.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text18.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            //$$$$$ RONDJE WINOPTIES
            if (text17.Text == "o" && text25.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text25.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text19.Text == "o" && text26.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text18.Text == "o" && text25.Text == "o" && text32.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text24.Text == "o" && text31.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text32.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text24.Text == "o" && text25.Text == "o" && text26.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text18.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }


        }

        private void kn32_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.jouwplaatje == "veranderd")
            {
                kn32.Image = speler1.Image;
                kn32.Enabled = false;
                text32.Text = "x";
            }
            else
            {
                kn32.Image = Properties.Resources.X;
                kn32.Enabled = false;
                text32.Text = "x";
            }
            /*

                REACTIE COMPUTER

            */
            if (kn18.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn18.Image = speler2.Image;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }
                else
                {
                    kn18.Image = Properties.Resources._0;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }

            }
            else if (kn33.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn33.Image = speler2.Image;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
                else
                {
                    kn33.Image = Properties.Resources._0;
                    kn33.Enabled = false;
                    text33.Text = "o";
                }
            }
            else if (kn26.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn26.Image = speler2.Image;
                    kn26.Enabled = false;
                    text26.Text = "o";
                }
                else
                {
                    kn26.Image = Properties.Resources._0;
                    kn26.Enabled = false;
                    text26.Text = "o";
                }
            }
            else if (kn24.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn24.Image = speler2.Image;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
                else
                {
                    kn24.Image = Properties.Resources._0;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
            }
            else if (kn25.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn25.Image = speler2.Image;
                    kn25.Enabled = false;
                    kn25.Text = "o";
                }
                else
                {
                    kn25.Image = Properties.Resources._0;
                    kn25.Enabled = false;
                    text25.Text = "o";
                }
            }
            else if (kn19.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn19.Image = speler2.Image;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
                else
                {
                    kn19.Image = Properties.Resources._0;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
            }
            else if (kn31.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn31.Image = speler2.Image;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
                else
                {
                    kn32.Image = Properties.Resources._0;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
            }
            else if (kn17.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn17.Image = speler2.Image;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
                else
                {
                    kn17.Image = Properties.Resources._0;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
            }
            //$$$$ KRUISJE WINOPTIES
            if (text17.Text == "x" && text25.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text25.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text19.Text == "x" && text26.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text18.Text == "x" && text25.Text == "x" && text32.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text24.Text == "x" && text31.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text32.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text24.Text == "x" && text25.Text == "x" && text26.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text18.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            //$$$$$ RONDJE WINOPTIES
            if (text17.Text == "o" && text25.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text25.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text19.Text == "o" && text26.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text18.Text == "o" && text25.Text == "o" && text32.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text24.Text == "o" && text31.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text32.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text24.Text == "o" && text25.Text == "o" && text26.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text18.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }


        }

        private void kn33_Click(object sender, EventArgs e)
        {


            if (Properties.Settings.Default.jouwplaatje == "veranderd")
            {
                kn33.Image = speler1.Image;
                kn33.Enabled = false;
                text33.Text = "x";
            }
            else
            {
                kn33.Image = Properties.Resources.X;
                kn33.Enabled = false;
                text33.Text = "x";
            }
            /*

                REACTIE COMPUTER

            */
            if (kn18.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn18.Image = speler2.Image;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }
                else
                {
                    kn18.Image = Properties.Resources._0;
                    kn18.Enabled = false;
                    text18.Text = "o";
                }

            }
            else if (kn32.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn32.Image = speler2.Image;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
                else
                {
                    kn32.Image = Properties.Resources._0;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
            }
            else if (kn26.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn26.Image = speler2.Image;
                    kn26.Enabled = false;
                    text26.Text = "o";
                }
                else
                {
                    kn26.Image = Properties.Resources._0;
                    kn26.Enabled = false;
                    text26.Text = "o";
                }
            }
            else if (kn24.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn24.Image = speler2.Image;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
                else
                {
                    kn24.Image = Properties.Resources._0;
                    kn24.Enabled = false;
                    text24.Text = "o";
                }
            }
            else if (kn25.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn25.Image = speler2.Image;
                    kn25.Enabled = false;
                    kn25.Text = "o";
                }
                else
                {
                    kn25.Image = Properties.Resources._0;
                    kn25.Enabled = false;
                    text25.Text = "o";
                }
            }
            else if (kn19.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn19.Image = speler2.Image;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
                else
                {
                    kn19.Image = Properties.Resources._0;
                    kn19.Enabled = false;
                    text19.Text = "o";
                }
            }
            else if (kn31.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn31.Image = speler2.Image;
                    kn31.Enabled = false;
                    text31.Text = "o";
                }
                else
                {
                    kn32.Image = Properties.Resources._0;
                    kn32.Enabled = false;
                    text32.Text = "o";
                }
            }
            else if (kn17.Enabled == true)
            {
                if (Properties.Settings.Default.pcplaatje == "veranderd")
                {
                    kn17.Image = speler2.Image;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
                else
                {
                    kn17.Image = Properties.Resources._0;
                    kn17.Enabled = false;
                    text17.Text = "o";
                }
            }




            //$$$$ KRUISJE WINOPTIES
            if (text17.Text == "x" && text25.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text25.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text19.Text == "x" && text26.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text18.Text == "x" && text25.Text == "x" && text32.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text24.Text == "x" && text31.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text31.Text == "x" && text32.Text == "x" && text33.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text24.Text == "x" && text25.Text == "x" && text26.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            if (text17.Text == "x" && text18.Text == "x" && text19.Text == "x")
            {
                Properties.Settings.Default.scoreJIJ++;
                jouwscore.Text = Properties.Settings.Default.scoreJIJ.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
            }
            //$$$$$ RONDJE WINOPTIES
            if (text17.Text == "o" && text25.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text25.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text19.Text == "o" && text26.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text18.Text == "o" && text25.Text == "o" && text32.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text24.Text == "o" && text31.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text31.Text == "o" && text32.Text == "o" && text33.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text24.Text == "o" && text25.Text == "o" && text26.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }
            if (text17.Text == "o" && text18.Text == "o" && text19.Text == "o")
            {
                Properties.Settings.Default.scorePC++;
                pcscore.Text = Properties.Settings.Default.scorePC.ToString();
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";

                text24.Text = "";
                text25.Text = "";
                text26.Text = "";

                text31.Text = "";
                text32.Text = "";
                text33.Text = "";

            }


        }

        private void topbackground_MouseMove(object sender, MouseEventArgs e)
        {
            if(text17.Text != "" && text18.Text != "" && text19.Text != "" && text24.Text != "" && text25.Text != "" && text26.Text != "" && text31.Text != "" && text32.Text != "" && text17.Text != "" && text33.Text != "")
            {
                text17.Text = "";
                text18.Text = "";
                text19.Text = "";
                text24.Text = "";
                text25.Text = "";
                text26.Text = "";
                text31.Text = "";
                text32.Text = "";
                text33.Text = "";
                kn17.Enabled = true;
                kn17.Image = Properties.Resources.img;
                kn18.Enabled = true;
                kn18.Image = Properties.Resources.img;
                kn19.Enabled = true;
                kn19.Image = Properties.Resources.img;
                kn24.Enabled = true;
                kn24.Image = Properties.Resources.img;
                kn25.Enabled = true;
                kn25.Image = Properties.Resources.img;
                kn26.Enabled = true;
                kn26.Image = Properties.Resources.img;
                kn31.Enabled = true;
                kn31.Image = Properties.Resources.img;
                kn32.Enabled = true;
                kn32.Image = Properties.Resources.img;
                kn33.Enabled = true;
                kn33.Image = Properties.Resources.img;


            }
        }
                
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarX1.Increment(incrementValue);

            if(progressBarX1.Value == 10)
            {
                tijdPercentage.Text = "10%";
                progressBarX1.Value = 10;
            }
            if (progressBarX1.Value == 20)
            {
                tijdPercentage.Text = "20%";
                progressBarX1.Value = 20;
            }
            if (progressBarX1.Value == 30)
            {
                tijdPercentage.Text = "30%";
                progressBarX1.Value = 30;
            }
            if (progressBarX1.Value == 40)
            {
                tijdPercentage.Text = "40%";
                progressBarX1.Value = 40;
            }
            if (progressBarX1.Value == 50)
            {
                tijdPercentage.Text = "50%";
                progressBarX1.Value = 50;
            }
            if (progressBarX1.Value == 60)
            {
                tijdPercentage.Text = "60%";
                progressBarX1.Value = 60;
            }
            if (progressBarX1.Value == 70)
            {
                tijdPercentage.Text = "70%";
                progressBarX1.Value = 70;
            }
            if (progressBarX1.Value == 80)
            {
                tijdPercentage.Text = "80%";
                progressBarX1.Value = 80;
            }
            if (progressBarX1.Value == 90)
            {
                tijdPercentage.Text = "90%";
                progressBarX1.Value = 90;
            }
            if (progressBarX1.Value == 100)
            {
                tijdPercentage.Text = "100%";
                progressBarX1.Value = 100;
            }
            //voltooid
            if (progressBarX1.Value == 100)
            {
                if(kn17.Enabled == true)
                {
                    if (Properties.Settings.Default.jouwplaatje == "veranderd")
                    {
                        kn17.Image = speler1.Image;
                        kn17.Enabled = false;
                        text17.Text = "x";
                    }
                    else
                    {
                        kn17.Image = Properties.Resources.X;
                        kn17.Enabled = false;
                        text17.Text = "x";
                    }
                }
                else if (kn18.Enabled == true)
                {
                    if (Properties.Settings.Default.jouwplaatje == "veranderd")
                    {
                        kn18.Image = speler1.Image;
                        kn18.Enabled = false;
                        text18.Text = "x";
                    }
                    else
                    {
                        kn18.Image = Properties.Resources.X;
                        kn18.Enabled = false;
                        text18.Text = "x";
                    }
                }
                else if (kn19.Enabled == true)
                {
                    if (Properties.Settings.Default.jouwplaatje == "veranderd")
                    {
                        kn19.Image = speler1.Image;
                        kn19.Enabled = false;
                        text19.Text = "x";
                    }
                    else
                    {
                        kn19.Image = Properties.Resources.X;
                        kn19.Enabled = false;
                        text19.Text = "x";
                    }
                }
                else if (kn24.Enabled == true)
                {
                    if (Properties.Settings.Default.jouwplaatje == "veranderd")
                    {
                        kn24.Image = speler1.Image;
                        kn24.Enabled = false;
                        text24.Text = "x";
                    }
                    else
                    {
                        kn24.Image = Properties.Resources.X;
                        kn24.Enabled = false;
                        text24.Text = "x";
                    }
                }
                else if (kn25.Enabled == true)
                {
                    if (Properties.Settings.Default.jouwplaatje == "veranderd")
                    {
                        kn25.Image = speler1.Image;
                        kn25.Enabled = false;
                        text25.Text = "x";
                    }
                    else
                    {
                        kn25.Image = Properties.Resources.X;
                        kn25.Enabled = false;
                        text25.Text = "x";
                    }
                }
                else if (kn26.Enabled == true)
                {
                    if (Properties.Settings.Default.jouwplaatje == "veranderd")
                    {
                        kn26.Image = speler1.Image;
                        kn26.Enabled = false;
                        text26.Text = "x";
                    }
                    else
                    {
                        kn26.Image = Properties.Resources.X;
                        kn26.Enabled = false;
                        text26.Text = "x";
                    }
                }
                else if (kn31.Enabled == true)
                {
                    if (Properties.Settings.Default.jouwplaatje == "veranderd")
                    {
                        kn31.Image = speler1.Image;
                        kn31.Enabled = false;
                        text31.Text = "x";
                    }
                    else
                    {
                        kn31.Image = Properties.Resources.X;
                        kn31.Enabled = false;
                        text31.Text = "x";
                    }
                }
                else if (kn32.Enabled == true)
                {
                    if (Properties.Settings.Default.jouwplaatje == "veranderd")
                    {
                        kn32.Image = speler1.Image;
                        kn32.Enabled = false;
                        text32.Text = "x";
                    }
                    else
                    {
                        kn32.Image = Properties.Resources.X;
                        kn32.Enabled = false;
                        text32.Text = "x";
                    }
                }
                else if (kn33.Enabled == true)
                {
                    if (Properties.Settings.Default.jouwplaatje == "veranderd")
                    {
                        kn33.Image = speler1.Image;
                        kn33.Enabled = false;
                        text33.Text = "x";
                    }
                    else
                    {
                        kn33.Image = Properties.Resources.X;
                        kn33.Enabled = false;
                        text33.Text = "x";
                    }
                }



                //reactie computer
                if (kn18.Enabled == true)
                {
                    if (Properties.Settings.Default.pcplaatje == "veranderd")
                    {
                        kn18.Image = speler2.Image;
                        kn18.Enabled = false;
                        text18.Text = "o";
                    }
                    else
                    {
                        kn18.Image = Properties.Resources._0;
                        kn18.Enabled = false;
                        text18.Text = "o";
                    }

                }
                else if (kn19.Enabled == true)
                {
                    if (Properties.Settings.Default.pcplaatje == "veranderd")
                    {
                        kn19.Image = speler2.Image;
                        kn19.Enabled = false;
                        text19.Text = "o";
                    }
                    else
                    {
                        kn19.Image = Properties.Resources._0;
                        kn19.Enabled = false;
                        text19.Text = "o";
                    }

                }
                else if (kn33.Enabled == true)
                {
                    if (Properties.Settings.Default.pcplaatje == "veranderd")
                    {
                        kn33.Image = speler2.Image;
                        kn33.Enabled = false;
                        text33.Text = "o";
                    }
                    else
                    {
                        kn33.Image = Properties.Resources._0;
                        kn33.Enabled = false;
                        text33.Text = "o";
                    }
                }
                else if (kn31.Enabled == true)
                {
                    if (Properties.Settings.Default.pcplaatje == "veranderd")
                    {
                        kn31.Image = speler2.Image;
                        kn31.Enabled = false;
                        text31.Text = "o";
                    }
                    else
                    {
                        kn31.Image = Properties.Resources._0;
                        kn31.Enabled = false;
                        text31.Text = "o";
                    }
                }
                else if (kn25.Enabled == true)
                {
                    if (Properties.Settings.Default.pcplaatje == "veranderd")
                    {
                        kn25.Image = speler2.Image;
                        kn25.Enabled = false;
                        text25.Text = "o";
                    }
                    else
                    {
                        kn25.Image = Properties.Resources._0;
                        kn25.Enabled = false;
                        text25.Text = "o";
                    }
                }
                else if (kn26.Enabled == true)
                {
                    if (Properties.Settings.Default.pcplaatje == "veranderd")
                    {
                        kn26.Image = speler2.Image;
                        kn26.Enabled = false;
                        kn26.Text = "o";
                    }
                    else
                    {
                        kn26.Image = Properties.Resources._0;
                        kn26.Enabled = false;
                        text26.Text = "o";
                    }
                }
                else if (kn24.Enabled == true)
                {
                    if (Properties.Settings.Default.pcplaatje == "veranderd")
                    {
                        kn24.Image = speler2.Image;
                        kn24.Enabled = false;
                        text24.Text = "o";
                    }
                    else
                    {
                        kn24.Image = Properties.Resources._0;
                        kn24.Enabled = false;
                        text24.Text = "o";
                    }
                }
                else if (kn32.Enabled == true)
                {
                    if (Properties.Settings.Default.pcplaatje == "veranderd")
                    {
                        kn32.Image = speler2.Image;
                        kn32.Enabled = false;
                        text32.Text = "o";
                    }
                    else
                    {
                        kn32.Image = Properties.Resources._0;
                        kn32.Enabled = false;
                        text32.Text = "o";
                    }
                }
                else if (kn18.Enabled == true)
                {
                    if (Properties.Settings.Default.pcplaatje == "veranderd")
                    {
                        kn18.Image = speler2.Image;
                        kn18.Enabled = false;
                        text18.Text = "o";
                    }
                    else
                    {
                        kn18.Image = Properties.Resources._0;
                        kn18.Enabled = false;
                        text18.Text = "o";
                    }
                }




                progressBarX1.Value = 0;
                timer1.Start();





            }
        }
          
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Stoter_Kaas_en_Eieren
{
    public partial class setupOnline : DevComponents.DotNetBar.Office2007Form
    {
        MySqlDataReader DataReader;
        MySqlConnection Connection = new MySqlConnection("Server=hiclothes.nl;Port=3306;Database=dehefnq201_ske;Uid=dehefnq201_skeu;Password=12345678;");
        MySqlDataReader DataReader2;
        MySqlConnection Connection2 = new MySqlConnection("Server=hiclothes.nl;Port=3306;Database=dehefnq201_ske;Uid=dehefnq201_skeu;Password=12345678;");
        public setupOnline()
        {
            InitializeComponent();
        }

        private void setupOnline_Load(object sender, EventArgs e)
        {
            herlder.Start();
            aantal1.Text = "3 potjes";
            tijd1.Text = "5 sec";

            if (Properties.Settings.Default.speler1 == "Speler1Joined")
            {
                //Speler1 bewerking inschakelen
                naam1.Visible = true;
                naam1_label.Visible = false;
                aantal1.Visible = true;
                aantal1_label.Visible = false;
                tijd1.Visible = true;
                tijd1_label.Visible = false;

                //Speler2 bewerking verbergen
                naam2.Visible = false;
                naam2_label.Visible = true;    


            }else if(Properties.Settings.Default.speler2 == "Speler2Joined")
            {
                //Speler2 bewerking inschakelen
                naam2.Visible = true;
                naam2_label.Visible = false;

                //Speler1 dingen verbergen 
                naam1.Visible = false;
                naam1_label.Visible = true;
                aantal1.Visible = false;
                aantal1_label.Visible = true;
                tijd1.Visible = false;
                tijd1_label.Visible = true;

            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.volgende1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.volgende2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.ditIsSpeler == "speler1")
            {
                if(naam1.Text != "" && aantal1.Text != "" && tijd1.Text != "")
                {
                    status1.Image = Properties.Resources.ready;
                    naam1_label.Text = naam1.Text;
                    aantal1_label.Text = aantal1.Text;
                    tijd1_label.Text = tijd1.Text;

                    naam1.Visible = false;
                    aantal1.Visible = false;
                    tijd1.Visible = false;

                    naam1_label.Visible = true;
                    aantal1_label.Visible = true;
                    tijd1_label.Visible = true;


                    MySqlCommand CommandVeranderNaamSpeler1;
                    Connection2.Open();
                    string QueryCommandVeranderNaamSpeler1 = "update Lobby1 set naam1='" + naam1.Text + "', aantal1='" + aantal1.Text + "', tijd1='"+tijd1.Text+"', status1='ready'; ";
                    CommandVeranderNaamSpeler1 = new MySqlCommand(QueryCommandVeranderNaamSpeler1, Connection2);
                    DataReader2 = CommandVeranderNaamSpeler1.ExecuteReader();
                    Connection2.Close();
                    
                }
            }
            else if(Properties.Settings.Default.ditIsSpeler == "speler2")
            {
                status2.Image = Properties.Resources.ready;
                
                naam2_label.Text = naam2.Text;
                naam2.Visible = false;
                naam2_label.Visible = true;


                MySqlCommand CommandVeranderNaamSpeler1;
                Connection2.Open();
                string QueryCommandVeranderNaamSpeler1 = "update Lobby1 set naam2='" + naam2.Text + "',status2='ready' ; ";
                CommandVeranderNaamSpeler1 = new MySqlCommand(QueryCommandVeranderNaamSpeler1, Connection2);
                DataReader2 = CommandVeranderNaamSpeler1.ExecuteReader();
                DataReader2.Close();
                Connection2.Close();
                



            }
        }
        
        private void herlder_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            if(progressBar1.Value == 100)
            {
                MySqlCommand CommandSelecteerSel;
                Connection2.Open();
                string QuerySelectData = "SELECT * FROM Lobby1";
                CommandSelecteerSel = new MySqlCommand(QuerySelectData, Connection2);
                DataReader2 = CommandSelecteerSel.ExecuteReader();
                if (DataReader2.Read())
                {
                    if(DataReader2.GetString("naam1") != "")
                    {
                        naam1_label.Text = DataReader2.GetString("naam1");
                    }
                    if(DataReader2.GetString("naam1") == "") 
                    {
                        naam1_label.Text = "In afwachting...";
                    }
                    if (DataReader2.GetString("naam2") != "")
                    {
                        naam2.Visible = false;
                        naam2_label.Visible = true;
                        naam2_label.Text = DataReader2.GetString("naam2");
                    }
                    if(DataReader2.GetString("naam2") == "")
                    {
                        naam2_label.Text = "In afwachting...";
                    }
                    if (DataReader2.GetString("tijd1") != "")
                    {
                        tijd1_label.Text = DataReader2.GetString("tijd1");
                        tijd2_label.Text = DataReader2.GetString("tijd1");
                    }
                    if(DataReader2.GetString("tijd1") == "")
                    {
                        tijd1_label.Text = "In afwachting...";
                        tijd2_label.Text = "In afwachting...";
                    }
                    if (DataReader2.GetString("aantal1") != ""){
                        aantal1_label.Text = DataReader2.GetString("aantal1");
                        aantal2_label.Text = DataReader2.GetString("aantal1");
                    }
                    if(DataReader2.GetString("aantal1") == "")
                    {
                        aantal1_label.Text = "In afwachting...";
                        aantal2_label.Text = "In afwachting...";
                    }
                    if(DataReader2.GetString("status2") == "ready")
                    {
                        status2.Image = Properties.Resources.ready;
                    }
                    if(DataReader2.GetString("status2") != "ready")
                    {
                        status2.Image = Properties.Resources.notready;
                    }
                    if (DataReader2.GetString("status1") == "ready")
                    {
                        status1.Image = Properties.Resources.ready;
                    }
                    if (DataReader2.GetString("status1") != "ready")
                    {
                        status1.Image = Properties.Resources.notready;
                    }
                    if(DataReader2.GetString("status1") == "ready" && DataReader2.GetString("status2") == "ready")
                    {
                        this.Hide();
                        onlineGame ong = new onlineGame();
                        ong.Show();
                        herlder.Stop();
                    }

                }
                DataReader2.Close();
                Connection2.Close();

                progressBar1.Value = 0;
            }

        }

        private void setupOnline_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*update in database
            MySqlCommand CommandSpelerErbij2;
            MySqlCommand commandSpelerBewerken;
            Connection2.Open();
            string QueryUpdateSpelerz = "update Lobby1 set speler2='' ; ";
            string QueryUpdateSpeler2 = "update Lobby1 set speler2='' ; ";
            CommandSpelerErbij2 = new MySqlCommand(QueryUpdateSpelerz, Connection2);
            commandSpelerBewerken = new MySqlCommand(QueryUpdateSpeler2, Connection2);
            DataReader2 = commandSpelerBewerken.ExecuteReader();
            DataReader2 = CommandSpelerErbij2.ExecuteReader();
            DataReader2.Close();
            Connection2.Close();
            */
        }
    }
}

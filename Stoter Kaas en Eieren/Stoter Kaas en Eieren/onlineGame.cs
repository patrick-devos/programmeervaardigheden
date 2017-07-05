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
    public partial class onlineGame : DevComponents.DotNetBar.Office2007Form
    {
        MySqlConnection Connection = new MySqlConnection("Server=hiclothes.nl;Port=3306;Database=dehefnq201_ske;Uid=dehefnq201_skeu;Password=12345678");
        MySqlDataReader DataReader;
        public onlineGame()
        {
            InitializeComponent();
        }

        private void onlineGame_Load(object sender, EventArgs e)
        {
            herlader.Start();
            MySqlCommand Command;
            Connection.Open();
            string selectQuery = "SELECT * FROM Lobby1";
            Command = new MySqlCommand(selectQuery, Connection);
            DataReader = Command.ExecuteReader();
            if (DataReader.Read())
            {
                speler1.Text = DataReader.GetString("naam1");
                speler2.Text = DataReader.GetString("naam2");
                eindscore.Text = DataReader.GetString("aantal1");
            }
            Connection.Close();
            DataReader.Close();

            


        }

        private void herlader_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);

            if(progressBar1.Value == 100)
            {
                MySqlCommand Command;
                Connection.Open();
                string selectQuery = "SELECT * FROM Game1";
                Command = new MySqlCommand(selectQuery, Connection);
                DataReader = Command.ExecuteReader();
                if (DataReader.Read())
                {
                    if (DataReader.GetString("hok2") == "zet")
                    {
                        kn18.Image = Properties.Resources._0;
                    }
                    if (DataReader.GetString("hok3") == "zet")
                    {
                        kn19.Image = Properties.Resources._0;
                    }

                }
                Connection.Close();
                DataReader.Close();


            }





        }

        private void kn17_Click(object sender, EventArgs e)
        {
            kn17.Image = Properties.Resources.X;

            /*

            MySqlCommand Command3;
            string updateInteger = "SELECT * FROM Game1";
            Command3 = new MySqlCommand(updateInteger, Connection);
            Connection.Open();
            DataReader = Command3.ExecuteReader();
            if (DataReader.Read())
            {
                if(DataReader.GetString("hok1") != "")
                {
                    MessageBox.Show("Deze plek is al gekozen.");
                }
                else
                {
                    MySqlCommand Command7;
                    string queryUpdateSpeler1Lobby1 = "update Game set hok1='" + Properties.Settings.Default.ditIsSpeler + "' ; ";
                    Command7 = new MySqlCommand(queryUpdateSpeler1Lobby1, Connection);
                    kn17.Image = Properties.Resources.X;
                    DataReader.Close();
                    DataReader = Command7.ExecuteReader();
                    DataReader.Close();
                    Connection.Close();

                }
            }
            Connection.Close();
            DataReader.Close();

            */



        }

        private void kn24_Click(object sender, EventArgs e)
        {
            kn24.Image = Properties.Resources.X;
        }

        private void kn18_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;
using InformerR;
namespace InformerR
{
    public partial class Form4 : Form
    {
        public string um;
        public string ven;
        public string tm;
        public string lec;

        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        public Form4()
        {
            InitializeComponent();
        }

        public void Form4_Load(object sender, EventArgs e)
        {
            //start voice recognition

            Choices clist = new Choices();
            clist.Add(new string[]{ "today's program","tell me today's program","send me home", "send me back"});
            Grammar gr = new Grammar(new GrammarBuilder(clist));

            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text.ToString())
            {

                case "today's program":
                    ss.SpeakAsync("you have the following units," +um + "please");
                    break;
                case "tell me today's program":
                    ss.SpeakAsync("you have the following units," + um + "please");
              
                    break;
                case "send me home":
                    ss.SpeakAsync("well, here you are");
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                    break;
                case "close":
                    Application.Exit();
                    break;
            }
            //messageContent.Text += e.Result.Text.ToString() + Environment.NewLine;



            //end voice recognition
        }

        public void button1_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            string currentTime = (Convert.ToString(current));
            string constring = "datasource=localhost;port=3307;username=root;password=root";
            string Query = "insert into informer.user (username,password,dateUpdated) values ('" + username.Text + "','" + password.Text + "','"+currentTime+"')";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    ss.SpeakAsync("Sorry, username " + username.Text + " exists. Try another username. Thank you");
                }
                else if (count < 1)
                {
                    ss.SpeakAsync("username " + username.Text + " has been successfully added into the system");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
            string tday = (Convert.ToString(today));
            
            
            DateTime current = DateTime.Now;
            string currentTime = (Convert.ToString(current));   
            string constring = "datasource=localhost;port=3307;username=root;password=root";
            string Query = "insert into informer.schedule (unitName,venue,time,day,lecturer,dayUpdated) values ('" + unitname.Text + "','" + venue.Text + "','" + time.Text + "','" + dayt.Text + "','" + lecturer.Text + "','" + currentTime + "')";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                label8.Text = ("Record Added");
               
                while (myReader.Read())
                {
                    string dayclass = myReader.GetString("day");
                    if (tday ==dayclass)
                    {
                        string um = myReader.GetString("unitname");
                        string ven = myReader.GetString("venue");
                        string tm = myReader.GetString("time");
                        string lec = myReader.GetString("lecturer");
                       // label9.Text = "you have the following units, " + um + ", at ," + ven + "" + tm + ",by" + lec + ". Please get ready, you";
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

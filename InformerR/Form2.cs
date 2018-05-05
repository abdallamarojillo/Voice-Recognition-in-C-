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
namespace InformerR
{
    public partial class Form2 : Form
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3307;username=root;password=root";
            string Query = "select username,password FROM informer.user WHERE username='"+username.Text+"' && password='"+password.Text+"'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                int count = 0;
                //positiveFeedback.Text = ("Record Added");
               // MessageBox.Show("match");
                
                
                while (myReader.Read())
                {
                    count = count + 1;
                   
                }
                if (count == 1)
                {
                    ss.SpeakAsync("You are now being logged in");
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
                else if (count < 1)
                {
                    ss.SpeakAsync("Sorry, incorrect credentials, please try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

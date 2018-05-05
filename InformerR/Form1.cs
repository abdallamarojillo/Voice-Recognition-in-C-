using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;

namespace InformerR
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PREFER TYPING


            /*DateTime now = DateTime.Now;
           MessageBox.Show(Convert.ToString(now));
           */
            //shows time without seconds ie 7:07 PM
            // MessageBox.Show(DateTime.Now.ToShortTimeString());

            //shows time hour
            // MessageBox.Show(Convert.ToString(DateTime.Now.Hour));

            //shows time minute
            //MessageBox.Show(Convert.ToString(DateTime.Now.Minute));

            //shows time second
            // MessageBox.Show(Convert.ToString(DateTime.Now.Second));

            DateTime current = DateTime.Now;
            string currentTime = (Convert.ToString(current));

            //Get current time and minutes
            string nowHour = (Convert.ToString(DateTime.Now.Hour));
            string nowMinute = (Convert.ToString(DateTime.Now.Minute));
            string nowPeriod = DateTime.Now.ToString("tt");

            //get day and month
            string nowDay = (Convert.ToString(DateTime.Now.Day));
            string nowMonth = (Convert.ToString(DateTime.Now.Month));
            //get day of week
            string dayOfWeek = (Convert.ToString(DateTime.Today.DayOfWeek));

            //MessageBox.Show(nowDay);
            //MessageBox.Show(nowMonth);
           

            //CALL THE SPEECH FUNCTION

            //INFORMATION BETWEEN 7PM TO 10PM
            if ((Convert.ToInt32(nowHour) > Convert.ToInt32(18) && (Convert.ToInt32(nowHour) < Convert.ToInt32(22)) && nowPeriod == "PM"))
            {
                /*
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync("it is " + nowHour + "hours," + nowMinute + " minutes. Abdalla, have you done assignments? Have you accomplished your day's target? Have you read for exams? Before going to bed, please ensure you accomplish those tasks. Thank you.");
            */
            }

            //INFORMATION  BETWEEN 4AM TO 7PM MORNING
            if ((Convert.ToInt32(nowHour) > Convert.ToInt32(04) && (Convert.ToInt32(nowHour) < Convert.ToInt32(07)) && nowPeriod == "AM"))
            {

                ss.Dispose();
                ss = new SpeechSynthesizer();
                ss.SpeakAsync("it is " + nowHour + "hours," + nowMinute + " minutes.Good Morning Abdalla. Please write down your today's program. Don't forget to attend all classes. Don't forget to explore programming. Keep smiling. Have a blessed day.");
            }

            //INFORMATION BETWEEN 8AM - 12AM
            if ((Convert.ToInt32(nowHour) >= Convert.ToInt32(07) && (Convert.ToInt32(nowHour) < Convert.ToInt32(12)) && nowPeriod == "AM"))
            {

                ss.Dispose();
                ss = new SpeechSynthesizer();
                ss.SpeakAsync("it is" + dayOfWeek + "," + nowHour + " hours," + nowMinute + " you have started your day. Make it a success.");
            }
            //INFORMATION BETWEEN 1PM  TO 6PM
            if ((Convert.ToInt32(nowHour) >= Convert.ToInt32(13) && (Convert.ToInt32(nowHour) <= Convert.ToInt32(18)) && nowPeriod == "PM"))
            {

                ss.Dispose();
                ss = new SpeechSynthesizer();
                ss.SpeakAsync("it is " + nowHour + "hours, " + nowMinute + "good");
            }
            //start voice recognition

            Choices clist = new Choices();
            clist.Add(new string[]{ "hi","i am doing great, what about you","nice to hear so", "tell me about you","who made you","Who is Abdalla","really",
                "tell me about the one who made you","do you have a family","goodmorning","i had a great night","you are the one to tell me","please log me in", 
                 "what is the current time",
                 "thank you","play music",
                 "close","exit" });
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
        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text.ToString())
            {
                   
                case "hi":
                    ss.SpeakAsync("hi too, long time, how are you doing");
                    break;
                case "i am doing great, what about you":
                    ss.SpeakAsync("technically,  i am okay.");
                    break;
                case "nice to hear so":
                    ss.SpeakAsync("Pleasure is mine");
                    break;
                case "tell me about you":
                    ss.SpeakAsync("well, what specifically");
                    break;
                case "who made you":
                    ss.SpeakAsync("Abdalla is the one who made me");
                    break;
                case "Who is Abdalla":
                    ss.SpeakAsync("Abdalla is Cate's boyfriend?");
                    break;
                case "really":
                    ss.SpeakAsync("yes");
                    break;
                case "tell me about the one who made you":
                    ss.SpeakAsync("sorry, i cannot tell that, kindly enquire from him");
                    break;
                case "do you have a family":
                    ss.SpeakAsync("i am not sure about that, but i guess i do");
                    break;
                case "goodmorning":
                    ss.SpeakAsync("morning to you how was you night");
                    break;
                case "i had a great night":
                    ss.SpeakAsync("nice to here that, any plans for the day?");
                    break;
                case "you are the one to tell me":
                    ss.SpeakAsync("well, if that's the case, please log in an i will read for you your today's program");
                    break;
                case "please log me in":
                    ss.SpeakAsync("Sure, opening log in page, please enter you credentials");
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    break;
                case "what is the current time":
                    ss.SpeakAsync("current time is " + DateTime.Now.ToLongTimeString());
                    break;
                case "thank you":
                    ss.SpeakAsync("You are welcome");
                    break;
                case "play music":
                    Process.Start("E:\\Videos\\Music\\Western\\Summer Paradise 2016 - Best Of Tropical Deep House Music Chill Out - Mix By Regard.mp4");
                    break;
                case "close":
                    Application.Exit();
                    break;
                case "exit":
                    Application.Exit();
                    break;
                    
            }
            //messageContent.Text += e.Result.Text.ToString() + Environment.NewLine;
            //end voice recognition
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

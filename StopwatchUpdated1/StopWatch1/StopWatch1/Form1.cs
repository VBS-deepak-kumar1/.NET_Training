using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Globalization;
using System.Speech.Synthesis;

namespace StopWatch1
{
    public partial class Form1 : Form
    {
        int  Sec, Min,Hr;
        bool isActive;
       SpeechSynthesizer synth = new SpeechSynthesizer();
        

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

           
            Sec = 0;
            Min = 0;
            Hr = 0;
            isActive = false;
            

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                Sec++;
                if (Sec > 60)
                {
                    Min++;
                    Sec = 0;
                    if (Min > 60)
                    {
                        Hr++;
                        Min = 0;
                    }
                }
            
            }
            DisplayData();

        }
        private void DisplayData()
        {
           // btnMilSec.Text = MilSec.ToString();
            btnSec.Text = Sec.ToString();
            btnMin.Text = Min.ToString();
            btnHr.Text = Hr.ToString();
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Start");
        }
        private void stop_btn_Click(object sender, EventArgs e)
        {
            isActive = false;
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Stop");
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            isActive = false;
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Reset");
            Sec = 0;
            Min = 0;
            Hr = 0;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnSec_Click(object sender, EventArgs e)
        {

        }

        

        private void S_label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}



/*
   btnMilSec.Text = string.Format("{0}", MilSec);
   btnSec.Text = string.Format("{0}", Sec); 
   btnMin.Text = string.Format("{0}", Min);
   btnHr.Text = string.Format("{0}", Hr);
*/
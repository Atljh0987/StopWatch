using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace StopWatch
{
    public partial class Timer : Form
    {
        private int currentTime = 0;        
        public Timer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime--;

            //alert.Text = currentTime.ToString();

            int hourCount = currentTime / 3600;
            int minCount = (currentTime - hourCount * 3600) / 60;
            int secCount = currentTime - minCount * 60 - hourCount * 3600;

            hour.Text = hourCount.ToString();
            minute.Text = minCount.ToString();
            second.Text = secCount.ToString();

            if (currentTime <= 0)
            {
                SystemSounds.Asterisk.Play();                
                timer1.Stop();
                start.Text = "Start";
                //MessageBox.Show("Time's up!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            start.Text = "Start";
            currentTime = 0;
            second.Text = minute.Text = hour.Text = "";
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                start.Text = "Start";
            }
            else if (second.Text != "" && second.Text != "0" || minute.Text != "" && minute.Text != "0" || hour.Text != "" && hour.Text != "0")
            {
                int seconds = (second.Text == "") ? 0 : int.Parse(second.Text);
                int minutes = (minute.Text == "") ? 0 : int.Parse(minute.Text);
                int hours = (hour.Text == "") ? 0 : int.Parse(hour.Text);

                if(currentTime == 0) currentTime = seconds + minutes * 60 + hours * 3600;
                timer1.Interval = 1;
                timer1.Start();
                start.Text = "Pause";
            }
            //else
                //alert.Text = "Укажите время";
        }

        private void second_TextChanged(object sender, EventArgs e)
        {
            //alert.Text = "";
        }

        private void hour_TextChanged(object sender, EventArgs e)
        {
            second_TextChanged(sender, e);
        }

        private void minute_TextChanged(object sender, EventArgs e)
        {
            second_TextChanged(sender, e);
        }

        // ---------------------

        private void second_KeyPress(object sender, KeyPressEventArgs e)
        {
            KPress(sender, e, second.Text);          
        }

        private void minute_KeyPress(object sender, KeyPressEventArgs e)
        {
            KPress(sender, e, minute.Text);
        }

        private void hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            KPress(sender, e, hour.Text);
        }

        private void KPress(object sender, KeyPressEventArgs e, string text)
        {
            if (e.KeyChar == (char)8)
                e.Handled = false;
            else
            {
                if (text != "")
                {
                    if (int.Parse(text) > 5)
                        e.Handled = true;
                }                    
                else
                {
                    if (text.Length == 0)
                        if (e.KeyChar == (char)48 || e.KeyChar == (char)96)
                            e.Handled = true;
                }
                    

                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
    }
}

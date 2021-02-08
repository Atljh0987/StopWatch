using System;
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

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            currentTime--;

            int hourCount = currentTime / 3600;
            int minCount = (currentTime - hourCount * 3600) / 60;
            int secCount = currentTime - minCount * 60 - hourCount * 3600;

            hour.Text = hourCount.ToString();
            minute.Text = minCount.ToString();
            second.Text = secCount.ToString();

            if (currentTime <= 0)
            {                                    
                mainTimer.Stop();
                start.Text = "Start";

                second.ReadOnly = minute.ReadOnly = hour.ReadOnly = false;

                signalTimer.Start();
                SystemSounds.Asterisk.Play();

                DialogResult res = MessageBox.Show((notification.Text == "")? "Time's up!" : notification.Text);

                if (res == DialogResult.OK)
                    signalTimer.Stop();
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
            start.Text = "Start";
            currentTime = 0;
            second.Text = minute.Text = hour.Text = "";
            second.ReadOnly = minute.ReadOnly = hour.ReadOnly = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (mainTimer.Enabled)
            {
                mainTimer.Stop();
                start.Text = "Start";
            }
            else if (second.Text != "" && second.Text != "0" || 
                     minute.Text != "" && minute.Text != "0" || 
                     hour.Text != "" && hour.Text != "0")
            {
                int seconds = (second.Text == "") ? 0 : int.Parse(second.Text);
                int minutes = (minute.Text == "") ? 0 : int.Parse(minute.Text);
                int hours = (hour.Text == "") ? 0 : int.Parse(hour.Text);

                if(currentTime == 0) currentTime = seconds + minutes * 60 + hours * 3600;
                mainTimer.Interval = 1;
                mainTimer.Start();
                start.Text = "Pause";

                second.ReadOnly = true;
                minute.ReadOnly = true;
                hour.ReadOnly = true;
            }
        }

        // ---------------------

        private void second_KeyPress(object sender, KeyPressEventArgs e) => KPress(sender, e, second.Text);
        private void minute_KeyPress(object sender, KeyPressEventArgs e) => KPress(sender, e, minute.Text);
        private void hour_KeyPress(object sender, KeyPressEventArgs e) => KPress(sender, e, hour.Text);

        private void KPress(object sender, KeyPressEventArgs e, string text)
        {
            if (e.KeyChar == (char)13)
            {
                start_Click(this, new EventArgs());
            }

            if (text == "0")
            {
                second.Text = "";
                minute.Text = "";
                hour.Text = "";
            }                

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

        private void signalTimer_Tick_1(object sender, EventArgs e) => SystemSounds.Asterisk.Play();
    }
}

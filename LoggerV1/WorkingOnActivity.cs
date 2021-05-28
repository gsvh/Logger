using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoggerV1
{
    public partial class WorkingOnActivity : Form
    {
        Connection c = new Connection();
        
        
        //timer variables
        Int16 seconds = 0;
        Int16 minutes = 0;
        Int16 hours = 0;

        public WorkingOnActivity()
        {
            InitializeComponent();
            SecondTimer.Enabled = true; //starts timer
            c.GetData();
           
        }



        
        private void SecondTimer_Tick_1(object sender, EventArgs e) //Timer ticks every second
        {
            seconds += 1;

            if (seconds == 60)  // if a minute has passed 
            {
                seconds = 0;
                minutes += 1;

            }
            else if (minutes == 60) // if an hour has passed
            {
                minutes = 0;
                hours += 1;
            }


            //Update Timer Label
            int[] _timer = { seconds, minutes, hours };
            string[] _labels = { "", "", "" }; //seconds, minutes, hours
            int label_flag = 0;
            foreach (int item in _timer)
            {


                if (item <= 9)
                {
                    _labels[label_flag] = "0" + item;
                    label_flag += 1;
                }
                else if (item > 9)
                {
                    _labels[label_flag] = "" + item;
                    label_flag += 1;
                }

                if (label_flag == 3)
                {
                    label_flag = 0;
                }

            }
            lblTimer.Text = _labels[2] + ":" + _labels[1] + ":" + _labels[0];
        }
        private int MinutesSpent() //Calculates amounts of minutes
        {
            return minutes + 60 * hours;
        }
        private void btnEnd_Click(object sender, EventArgs e) // Finish & Log Activity [btn]
        {
            c.AddToLog(dtPicker.Value.ToString(), lblSubject.Text, lblActivity.Text, txtActivityNotes.Text, MinutesSpent());
            SecondTimer.Enabled = false; //stops timer
            MessageBox.Show("Activity successfully logged!", "Great Success");
            Logger l = new Logger();
            l.Show();
            this.Hide(); //return to previous screen
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;


namespace LoggerV1
{
    public partial class Logger : Form
    {


        public Logger()
        {
            InitializeComponent();
            Connection c = new Connection(); //All sql & database operations in Connection.cs
            c.GetData(); //Loads data
            cbSubjects.Items.AddRange(c.subjects); //populates subjects combo box
            cbActivities.Items.AddRange(c.activities); //populates activities combo box
        }
        
        private int MinutesSpent() // calculations for manulally entering time spent
        {
            int min = 0;
            int hr = 0;
            if (txtHSpent.Text != "")
            {
                hr = Convert.ToInt16(txtHSpent.Text);
            } 
            if (txtMSpent.Text != "")
            {
                min = Convert.ToInt16(txtMSpent.Text);
            }
            return min + 60 * hr;
        }
        private void btnLogActivity_Click(object sender, EventArgs e) // Log Activity [btn]
        {
            if (cbSubjects.SelectedIndex > -1 && cbActivities.SelectedIndex > -1 && MinutesSpent() != 0) // if a subject,activity has been selected and time is entered
            {  
                Connection c = new Connection();
                c.GetData();
                c.AddToLog(dtPicker.Value.ToString() ,cbSubjects.SelectedItem.ToString(), cbActivities.SelectedItem.ToString(), txtActivityNotes.Text, MinutesSpent()); //Add to UserLogTable Datatable
                MessageBox.Show("Activity successfully logged!", "Great Success");
                Logger l = new Logger();    //new instance of Logger
                l.Show();
                this.Hide(); //reset
            }
            
            else 
            {
                MessageBox.Show("Did you fill all fields?\n\nAlso remember to click 'Add Subject/Activity' when entering a new Subject/Activity.", "Error 694-20");
            }
            



        }

        

        public void llOverrideTimer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Enter time manually [link]
        {

            if (!txtHSpent.Visible)                                             //controlls which elements of enter time spent display together
            {
                txtHSpent.Visible = true;
                txtMSpent.Visible = true;
                lblH.Visible = true;
                lblM.Visible = true;
                llOverrideTimer.Text = "Use timer instead";
                lblTimer.Visible = false;
                btnLogActivity.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                txtHSpent.Visible = false;
                txtMSpent.Visible = false;
                lblH.Visible = false;
                lblM.Visible = false;
                txtHSpent.Text = "";
                llOverrideTimer.Text = "Manually enter min spent";
                lblTimer.Visible = true;
                btnLogActivity.Enabled = false;
                btnStart.Enabled = true;
            }

        }

        private void txtHSpent_TextChanged(object sender, EventArgs e)
        {
            int ms;
            try                                                      // ensures user enters int values only
            {
                ms = Convert.ToInt32(txtHSpent.Text.ToString());
                lblError.Visible = false;   
            }
            catch
            {
                lblError.Visible = true;                            // sets Error label to visible when user enters invalid character
                txtHSpent.Text = "";
            }
        }
        private void txtMSpent_TextChanged(object sender, EventArgs e)
        {
            int ms;
            try                                                     // ensures user enters int values only
            {
                ms = Convert.ToInt32(txtMSpent.Text.ToString());
                lblError.Visible = false;
            }
            catch
            {
                lblError.Visible = true;                            // sets Error label to visible when user enters invalid character
                txtMSpent.Text = "";
            }
        }
        private void btnStart_Click(object sender, EventArgs e) // Start Activity [btn]
        {
            if (cbSubjects.Text != "" && cbActivities.Text != "")
            {
                WorkingOnActivity woa = new WorkingOnActivity(); // redirects to new form
                woa.lblSubject.Text = cbSubjects.Text; // sets labels of new form
                woa.lblActivity.Text = cbActivities.Text;
                woa.txtActivityNotes.Text = txtActivityNotes.Text;

                woa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Did you fill all fields?\n\nAlso remember to click 'Add Subject/Activity' when entering a new Subject/Activity.", "Error 694-20");
            }

        }

        private void btnAddSub_Click(object sender, EventArgs e)    // Add Subject [btn]
        {
            Connection c = new Connection();
            c.GetData();

            if (!c.subjects.Contains(cbSubjects.Text) && cbSubjects.Text != "") // if new subject is not in list of subjects AND new subject field is not empty
            {
                c.AddToSubjects(cbSubjects.Text);
                MessageBox.Show("Successfully added " + cbSubjects.Text + " to Subjects");
                Logger l = new Logger();
                l.Show();
                this.Hide();//reset
            }
            else if (cbSubjects.Text != null )
            {
                MessageBox.Show("Field cannot be empty, or item already exists in Subjects", "Invalid Input" );
            }
        }

        private void btnAddActiv_Click(object sender, EventArgs e)  // Add Activity [btn]
        {
            Connection c = new Connection();
            c.GetData();
            

            if (!c.activities.Contains(cbActivities.Text) && cbActivities.Text != "")   // if new activity is not in list of activities AND new activity field is not empty
            {
                c.AddToActivities(cbActivities.Text);
                MessageBox.Show("Successfully added " + cbActivities.Text + " to Activities");
                Logger l = new Logger();
                l.Show();
                this.Hide();//reset
            }
            else if (cbActivities.Text != null)
            {
                MessageBox.Show("Field cannot be empty, or item already exists in Activities", "Invalid Input");
            }
        }

        private void btnRemoveSub_Click(object sender, EventArgs e) // Remove Subject [btn]
        {
            try
            {
                Connection c = new Connection();
                c.RemoveFromSubjects(cbSubjects.SelectedItem.ToString()); // Remove from subjects list
                MessageBox.Show(cbSubjects.SelectedItem.ToString() + " removed from Subjects", "Great Success");
                Logger l = new Logger();
                l.Show();
                this.Hide();//reset
            }
            catch( Exception ee)
            {
                MessageBox.Show(ee.Message + "\n\n" + ee, "ERROR 694-20");
            }
        }

        private void btnRemoveActivity_Click(object sender, EventArgs e) // Remove Activity [btn]
        {
            try
            {
                Connection c = new Connection();
                c.RemoveFromActivities(cbActivities.SelectedItem.ToString());   // Remove from activities list
                MessageBox.Show(cbActivities.SelectedItem.ToString() + " removed from Activities", "Great Success");
                Logger l = new Logger();
                l.Show();
                this.Hide();//reset
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message + "\n\n" + ee, "ERROR 694-20");
            }
        }

        private void btnViewLog_Click(object sender, EventArgs e)   // View my log datatable [btn]
        {
            MyLog m = new MyLog();
            m.Show();
            this.Hide();
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e) //Date Picker 
        {
            if (dtPicker.Value.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy") && !txtHSpent.Visible) //if the date selected is today
            {
                btnLogActivity.Enabled = false;
                btnStart.Enabled = true;
            }
            else                                                      //controlls which elements of select date spent display together
            {
                btnLogActivity.Enabled = true;
                btnStart.Enabled = false;
            }
        }
    }    
}

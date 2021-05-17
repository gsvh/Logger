using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoggerV1
{
    public partial class MyLog : Form
    {
        Connection c = new Connection();
        SaveFileDialog sfd = new SaveFileDialog(); // Dialog that user can select where to save as well as enter doc name

        public MyLog()
        {
            InitializeComponent();
            //c.CreateDatabase();

            try
            {
                c.GetData();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            }

        
        private void PopulateLog() //populates Data Grid View table
        {
            foreach (DataRow item in c.Log.Rows)
            {
                int n = dgvLog.Rows.Add();
                dgvLog.Rows[n].Cells[0].Value = item["ID"]; //ID
                dgvLog.Rows[n].Cells[1].Value = item["Date"].ToString(); //Date
                dgvLog.Rows[n].Cells[2].Value = item["Subject"].ToString(); //Subjects
                dgvLog.Rows[n].Cells[3].Value = item["Activity"].ToString(); //Activities
                dgvLog.Rows[n].Cells[4].Value = item["ActivityNotes"].ToString(); //ActivityNotes
                dgvLog.Rows[n].Cells[5].Value = item["TimeSpent"]; //TimeSpent
            }
            cbDelete.DataSource = c.id; // sets the source of the combo box for delete row button
        }
        
        
        private void MyLog_Load(object sender, EventArgs e) //runs PopulateLog() when loading MyLog
        {
            PopulateLog();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e) // Delete row [btn]
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to delete row " + cbDelete.Text + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) // confirm delete prompt
                try
                {
                    c.RemoveFromLog(Convert.ToInt16(cbDelete.Text));
                    MessageBox.Show("Successfully deleted row " + Convert.ToInt16(cbDelete.Text) + ".", "Great Success!");
                    MyLog ML = new MyLog();
                    ML.Show(); //reset
                    this.Hide();
                }

                catch
                {
                    MessageBox.Show("Deletion failed", "ERROR 694-20");
                }

        }

        private void btnExport_Click(object sender, EventArgs e) //Export as PDF
        {
            
            if (txtName.Text == "") // if name field is empty
            {
                MessageBox.Show("Empty field","Invalid Input");
            }
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //sets the default directory to user's Documents folder
                string docName = sfd.FileName; //gets filename that user entered
                PDFDocument logDoc = new PDFDocument(); //create new instance
                logDoc.CreateDocuments(txtName.Text, docName); // new document with username and document name
                MyLog ML = new MyLog();
                ML.Show(); //reset
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) // Cancel [btn]
        {
            Logger l = new Logger();
            l.Show();
            this.Hide(); //return to previous screen
        }
    }
}

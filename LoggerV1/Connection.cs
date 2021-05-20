using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace LoggerV1
{
    class Connection
    {
        //connection to LOGGER.mdf file in LocalDB
        SqlConnection con = new SqlConnection(@"Server=./SqlExpress;Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Public\Documents\Logger\LOGGER.mdf;Database=LOGGER.mdf;Integrated Security=True");

        //public datatables and arrays
        public DataTable Subjects = new DataTable();
        public DataTable Activities = new DataTable(); 
        public DataTable ID = new DataTable();
        public DataTable Log = new DataTable();
        public List<DataTable> SubjectLogs = new List<DataTable>(); //list of logs for each subject individually
        public string[] subjects;
        public string[] activities;
        public int[] id;
        
        public void GetData()   //fills public datatables and arrays
        {
            string getLog = "SELECT * FROM UserActivityLog";        //fills Log datatable
            SqlCommand cmdL = new SqlCommand(getLog, con);
            SqlDataAdapter sdaL = new SqlDataAdapter(cmdL);
            sdaL.Fill(Log);     

            string getSubjects = "SELECT * FROM Subjects";          //fills Subjects datatable
            var cmdS = new SqlCommand(getSubjects, con);
            SqlDataAdapter sdaS = new SqlDataAdapter(cmdS);
            sdaS.Fill(Subjects);
            //add subjects to list and convert to array
            List<string> l = new List<string>();
            for (int i = 0; i<Subjects.Rows.Count; i++)
            {
                l.Add(Subjects.Rows[i][1].ToString());
            }
            subjects = l.ToArray();    //fills subjects array 

            string getActivities = "SELECT * FROM Activities";      //fills Activities datatable
            var cmdA = new SqlCommand(getActivities, con);
            SqlDataAdapter sdaA = new SqlDataAdapter(cmdA);
            sdaA.Fill(Activities);
            //add activities to list and convert to array
            List<string> li = new List<string>();
            for (int i = 0; i < Activities.Rows.Count; i++)
            {
                li.Add(Activities.Rows[i][1].ToString());
            }
            activities = li.ToArray();  //fills activities array

            string getID = "SELECT ID FROM UserActivityLog";        //fills ID array
            SqlCommand cmdID = new SqlCommand(getID, con);
            SqlDataAdapter sdaID = new SqlDataAdapter(cmdID);
            sdaL.Fill(ID);
            List<int> _id = new List<int>();
            for (int i = 0; i < ID.Rows.Count; i++)
            {
                _id.Add(Convert.ToInt16(ID.Rows[i][0]));
            }
            id = _id.ToArray();

            for (int i = 0; i < Subjects.Rows.Count; i++)       // Logs activities for each subject individually, then adds the log to a list (SubjectLogs)
            {
                string getSubLogs = "SELECT ID, Date, Activity, ActivityNotes, TimeSpent FROM UserActivityLog WHERE Subject = @sub";
                SqlCommand cmdSL = new SqlCommand(getSubLogs, con);
                cmdSL.Parameters.AddWithValue("@Sub", Subjects.Rows[i][1].ToString());
                SqlDataAdapter sdaSL = new SqlDataAdapter(cmdSL);
                DataTable _SubjectLogs = new DataTable();
                sdaSL.Fill(_SubjectLogs);
                SubjectLogs.Add(_SubjectLogs);
            }
        }

        public void AddToLog(string _date, string sub, string activ, string activNotes, int minSpent)       //Logs activity to UserActivityLog [sql]
        {
            string addToLog = "INSERT INTO UserActivityLog VALUES(@date, @sub, @activ, @activNotes, @minSpent)";
            //string date = _date.Replace("00:00:00","");
            SqlCommand cmd = new SqlCommand(addToLog, con);
            cmd.Parameters.AddWithValue("@date", _date);
            cmd.Parameters.AddWithValue("@sub", sub);
            cmd.Parameters.AddWithValue("@activ", activ);
            cmd.Parameters.AddWithValue("@activNotes", activNotes);
            cmd.Parameters.AddWithValue("@minSpent", minSpent);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        public void RemoveFromLog(int ID)       //Deletes row number 'ID' in UserLogActivity [sql]
        {
            string remove = "DELETE FROM UserActivityLog WHERE ID = @id";
            SqlCommand cmd = new SqlCommand(remove, con);
            cmd.Parameters.AddWithValue("@id", ID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        public void AddToSubjects (string sub) //Adds to Subjects datatable [sql]
        {
            string addtosubjects = "INSERT INTO Subjects VALUES(@sub)";
            SqlCommand cmd = new SqlCommand(addtosubjects, con);
            cmd.Parameters.AddWithValue("@sub", sub);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

        }
        public void AddToActivities(string act) //Adds to Activities datatable [sql]
        {
            string addtosubjects = "INSERT INTO Activities VALUES(@act)";
            SqlCommand cmd = new SqlCommand(addtosubjects, con);
            cmd.Parameters.AddWithValue("@act", act);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

        }

        public void RemoveFromSubjects(string sub) //Removes from Subjects datatable [sql]
        {
            string remove = "DELETE FROM Subjects WHERE Subject = @sub";
            SqlCommand cmd = new SqlCommand(remove, con);
            cmd.Parameters.AddWithValue("@sub", sub);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }
        public void RemoveFromActivities(string act) //Removes from Activities datatable [sql]
        {
            string remove = "DELETE FROM Activities WHERE Activity = @act";
            SqlCommand cmd = new SqlCommand(remove, con);
            cmd.Parameters.AddWithValue("@act", act);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        public int TotalTimeSpent (string sub) //Calculates total minutes spent for subject 'sub' 
        {
            string getTimes = "SELECT TimeSpent FROM UserActivityLog WHERE Subject = @sub";
            SqlCommand cmd = new SqlCommand(getTimes, con);
            cmd.Parameters.AddWithValue("@sub", sub);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int c = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                c += Convert.ToInt32(dt.Rows[i][0]);
            }


            return c;
        }








        //          method to update information (never implemented/tested)

        //public void UpdateField(int ID, string Column, string newValue ) 
        //{
        //    string updateSub = "UPDATE UserActivityLog SET Subject = @sub WHERE ID = @id" ;
        //    string updateAct = "UPDATE UserActivityLog SET Activity = @act WHERE ID = @id" ;
        //    string updateNotes = "UPDATE UserActivityLog SET ActivityNotes = @notes WHERE ID = @id" ;
        //    string updateTime = "UPDATE UserActivityLog SET TimeSpent = @time WHERE ID = @id" ;

        //    if (Column == "Subject")
        //    {
        //        SqlCommand cmd = new SqlCommand(updateSub, con);
        //        cmd.Parameters.AddWithValue("@sub", newValue);
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);
        //    }
        //    else if (Column == "Activity")
        //    {
        //        SqlCommand cmd = new SqlCommand(updateAct, con);
        //        cmd.Parameters.AddWithValue("@act", newValue);
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);
        //    }
        //    else if (Column == "ActivityNotes")
        //    {
        //        SqlCommand cmd = new SqlCommand(updateNotes, con);
        //        cmd.Parameters.AddWithValue("@notes", newValue);
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);
        //    }
        //    else if (Column == "TimeSpent")
        //    {
        //        SqlCommand cmd = new SqlCommand(updateTime, con);
        //        cmd.Parameters.AddWithValue("@time", newValue);
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);
        //    }

        //}


        // create database (never implemented/tested)

        //public void CreateDatabase()
        //{
        //    string createDatabase = "CREATE DATABASE LOGGER GO CREATE TABLE Subjects(SubID INT PRIMARY KEY IDENTITY(1, 1), Subject VARCHAR(55)) CREATE TABLE Activities(ActID INT PRIMARY KEY IDENTITY(1, 1), Activity VARCHAR(55)) CREATE TABLE UserActivityLog(ID INT PRIMARY KEY IDENTITY(1, 1), Date DATE, Subject VARCHAR(55), Activity VARCHAR(55), ActivityNotes VARCHAR(100), TimeSpent INT) INSERT INTO Subjects VALUES('Digital Literacy'),('Personal Development'),('Software Development Fundamentals'),('Database Development Fundamentals'),('Web Development Fundamentals'),('Programming in C#'),('Compiling of the POE') INSERT INTO Activities VALUES('Classroom attendance'),('Online-Class attendance'),('Watching Class Recordings'),('Watching additional videos'),('Group work'),('Additional Research'),('Online Quiz'),('Preparing for an assessment [Specify]'),('Writing an assessment [Specify]'),('Aditional activities [Specify]'),('Other [Specify]')";
        //    SqlCommand cmd = new SqlCommand(createDatabase, con);
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //}

    }
}

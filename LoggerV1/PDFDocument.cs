using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ceTe.DynamicPDF;                      // to create pdf
using ceTe.DynamicPDF.PageElements;
using Label = ceTe.DynamicPDF.PageElements.Label; //to ensure Label is not System.Something.Something.Label

namespace LoggerV1
{
    class PDFDocument
    {
        Connection c = new Connection();
        // public document and page objects and variables
        public Document document = new Document();
        public List<Page> pageList = new List<Page>();
        public int pageCount; //keeps track of which page it's working on
        public int totalPageCountVar = 0; //if a subject has activities that doesn't fit on one page, this counter will add the extra page(s) to the total

        public void CreateDocuments(string username, string docname) //creates new document
        {
            c.GetData();

            for (pageCount = 0; pageCount < c.subjects.Length + totalPageCountVar; pageCount++) // for the amount of pages
            {
                pageList.Add(new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f));   //add new page to list of pages
                document.Pages.Add(pageList[pageCount]);    //add page to document
                string subject = c.subjects[pageCount - totalPageCountVar]; // selects subject from subject array
                CreateNewPage(0, subject, username, docname, pageList[pageCount], document); // creates new page with 0 being the starting index of activities
            }
            document.Draw(docname + ".pdf"); //creates document with name and extension
            MessageBox.Show("Successfully created " + docname + ".pdf ("+ pageCount + " pages)", "Great Success!"); // mbox indicating success with docname and number of pages
        }
        void CreateNewPage(int _i, string subject, string username, string docname, Page page, Document document)  //creates a new page
        {
            try
            {
                // variables
                var font = Font.TimesRoman;
                var fontBold = Font.TimesBold;
                int fontSize = 10;

                //postion on page variables
                int y = 12; // 12*56 = 1 page
                int x = 30;
                           // id, a,  n,   t
                int[] yPos = { 0, y, 2*y, 3*y };            //four default tab postions
                int[] xPos = { 0, x, 3*x, 14*x };           //default line positions for group of 4 items

                // Lists of strings and Labels for ID, Date, Activity, Activity Notes and Time Spent
                List<string> idS = new List<string>();
                List<Label> idL = new List<Label>();
                List<string> dateS = new List<string>();
                List<Label> dateL = new List<Label>();
                List<string> actS = new List<string>();
                List<Label> actL = new List<Label>();
                List<string> noteS = new List<string>();
                List<Label> noteL = new List<Label>();
                List<string> timeS = new List<string>();
                List<Label> timeL = new List<Label>();

                //Page Headers
                string header1 = "Logbook";
                Label lblHead1 = new Label(header1, 0,0, 504, 100, font, fontSize + 58, TextAlign.Center); 
                page.Elements.Add(lblHead1);

                string header2 = "Information Technology: Systems Development";
                Label lblHead2 = new Label(header2, 0, 5*y + 15 , 504, 100, font, fontSize + 6, TextAlign.Center);
                page.Elements.Add(lblHead2);

                string header3 = "Subject : " + subject;
                Label lblHead3 = new Label(header3, 0, 6*y + 23, 504, 100, font, fontSize + 4, TextAlign.Center);
                page.Elements.Add(lblHead3);

                Label lblName = new Label(username, 0, 0 + 10, 504, 100, font, fontSize, TextAlign.Left);   // Username
                page.Elements.Add(lblName);

                string tTotalTime = "Total time spent: " + c.TotalTimeSpent(subject)/60 + " hours and " + c.TotalTimeSpent(subject) % 60 + " minutes";
                Label lblTotalTime = new Label(tTotalTime, 0, 7 * y + 30, 504, 100, font, fontSize-2, TextAlign.Center);
                page.Elements.Add(lblTotalTime);

                //Table Headers
                string tID = "ID";
                Label lblID = new Label(tID, xPos[0], 12 * y, 504, 100, fontBold, fontSize, TextAlign.Left);
                page.Elements.Add(lblID);

                string tDate = "Date";
                Label lblDate = new Label(tDate, xPos[1], 12 * y, 504, 100, fontBold, fontSize, TextAlign.Left);
                page.Elements.Add(lblDate);

                string tActNote = "Activity & Notes";
                Label lblAN = new Label(tActNote, xPos[2], 12 * y, 504, 100, fontBold, fontSize, TextAlign.Left);
                page.Elements.Add(lblAN);

                string tTime = "Time Spent";
                Label lblTime = new Label(tTime, xPos[3], 12 * y, 504, 100, fontBold, fontSize, TextAlign.Left);
                page.Elements.Add(lblTime);


                for (int j = 0; j < yPos.Length; j++)
                {
                    yPos[j] += 14 * y; //adds 14*y to each default yPos
                }

                int idx = Array.IndexOf(c.subjects, subject); // idx is index of the subject in the subjects array
                for (int i = _i; i < c.SubjectLogs[idx].Rows.Count; i++)
                {
                    //ID
                    idS.Add(c.SubjectLogs[idx].Rows[i][0].ToString() + ".");     
                    idL.Add(new Label(idS[i-_i], xPos[0], yPos[0], 504, 100, fontBold, fontSize, TextAlign.Left)); 
                    page.Elements.Add(idL[i-_i]);

                    //Date
                    dateS.Add(c.SubjectLogs[idx].Rows[i][1].ToString().Replace(" 00:00:00","").Replace("/","-"));     // removes the hr:min:sec from datetime string
                    dateL.Add(new Label(dateS[i-_i], xPos[1], yPos[0], 504, 100, font, fontSize-2, TextAlign.Left));
                    page.Elements.Add(dateL[i - _i]);

                    //Activity
                    actS.Add(c.SubjectLogs[idx].Rows[i][2].ToString());         
                    actL.Add(new Label(actS[i - _i], xPos[2], yPos[0], 504, 100, font, fontSize, TextAlign.Left));
                    page.Elements.Add(actL[i - _i]);

                    //Activity Notes
                    noteS.Add(c.SubjectLogs[idx].Rows[i][3].ToString());        //Activity Notes
                    noteL.Add(new Label(noteS[i - _i], xPos[2], yPos[1], 504, 100, font, fontSize-2, TextAlign.Left));
                    page.Elements.Add(noteL[i - _i]);

                    //Time spent                                                            
                    timeS.Add(Convert.ToInt16(c.SubjectLogs[idx].Rows[i][4])/60 + " hours and " + Convert.ToInt16(c.SubjectLogs[idx].Rows[i][4]) % 60 + " minutes");
                    timeL.Add(new Label(timeS[i - _i], xPos[3], yPos[0], 504, 100, font, fontSize-2, TextAlign.Left));
                    page.Elements.Add(timeL[i - _i]);

                   
                    for (int j = 0; j < yPos.Length; j++)
                    {
                        yPos[j] += 2*y; // adds 2*y to all yPos (to create space between each entry)
                    }

                    if (yPos[3] > 12 * 60) // if the page is full
                    {

                        pageList.Add(new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f));
                        pageCount += 1;
                        totalPageCountVar += 1;
                        document.Pages.Add(pageList[pageCount]);
                        CreateNewPage(i+1, subject, username, docname, pageList[pageCount], document); //use recursion to add new page
                        i += 1000; // kills curent for loop
                    }
                }

                //      Page measurer tool
                //for (int i = 0; i < 1000; i++)
                //{
                //    string _s = i + "";
                //    Label _ss = new Label(_s, xPos[0], i * y, 504, 100, font, fontSize, TextAlign.Left);
                //    page.Elements.Add(_ss);
                //}

            }
            catch (Exception e)
            {
                MessageBox.Show(e + "\n\r" + e.Message);
            }
        }

        
    }
}

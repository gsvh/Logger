using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Reflection;
using System.Xml;

namespace LoggerV1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                string docPath = AppDomain.CurrentDomain.BaseDirectory + "adatasetup.xml"; //directory of XML file
                XmlDocument doc = new XmlDocument();
                doc.Load(docPath); //load the document to instance
                XmlNode node = doc.SelectSingleNode("movestatus"); //select the flag
                if (node.InnerXml == "incomplete") //if flag is incomplete, move database files to directory
                {
                    string loggerFolderPath = @"C:\Users\Public\Documents\Logger"; //database dirrectory
                    System.IO.Directory.CreateDirectory(loggerFolderPath); //creates Logger folder in Public Documents
                    System.IO.File.Move(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Logger\LOGGER.mdf", loggerFolderPath + @"\LOGGER.mdf");
                    System.IO.File.Move(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Logger\LOGGER_log.ldf", loggerFolderPath + @"\LOGGER_log.ldf"); //move database files
                    
                    node.InnerText = "complete"; //change flag to complete
                    doc.Save(docPath); //save changes made to XML file

                    //runs app
                    Application.EnableVisualStyles(); 
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Logger());
                    
                }
                else
                {
                    //runs app
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Logger());
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString() + "\n\n" + e.Message); 
            }
        }
    }
}

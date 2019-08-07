using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;


namespace FxP
{

    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string alllogged = "";
            string content1;
            this.dataGridView2.DataSource = null;
            string mu = "http://www.fxp.co.il/";

            using (WebClient webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                content1 = webClient.DownloadString("http://www.fxp.co.il/showgroups.php");
            }
            using (StringReader reader = new StringReader(content1))
            {
                List<string> input = new List<string>();
                List<string> inputs = new List<string>();
                
                string line;
                string content2;
                string content3;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("class=\"username online\""))
                    {
                        if (!line.Contains("\"><span style=\"font-weight: bold;"))
                        {
                            input.Add(line);
                        }
                    }
                    else if (line.Contains("\"><span style=\"font-weight: bold;"))
                    {
                        inputs.Add(line);
                    }
                }
                List<string> list = removeDuplicates(input);
                List<string> input2 = removeDuplicates(inputs);
                for (int i = 0; i < list.Count; i++)
                {

                    string[] loggedresult = Form1.GetStringInBetween("title=\"", " מחובר/ת כרגע", list[i], false, false);
                    string[] loggedresult1 = Form1.GetStringInBetween("<a href=\"", "\" class=\"", list[i], false, false);
                    string[] loggedresult2 = Form1.GetStringInBetween("color:", "\">", list[i], false, false);
                    string[] loggedresult3 = Form1.GetStringInBetween("color:", ";font", list[i], false, false);
                    string[] loggedresult4 = Form1.GetStringInBetween("color:", "'>", list[i], false, false);
                    string[] loggedresult5 = Form1.GetStringInBetween("color:", ";\">", list[i], false, false);
                    alllogged += loggedresult[0] + ";";
                    if (loggedresult2[0].CompareTo("blue") == 0) { dataGridView2.Rows.Add(loggedresult[0], "מפקח/ת", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("red") == 0) { dataGridView2.Rows.Add(loggedresult[0], "מנהל/ת פורום", mu + loggedresult1[0]);  } // מנהל רגיל
                    else if (loggedresult5[0].CompareTo("#2fa52d") == 0) { dataGridView2.Rows.Add(loggedresult[0], "מנהל/ת פורום", mu + loggedresult1[0]);  } // צבע של דיבורים
                    else if (loggedresult3[0].CompareTo("#FF0000") == 0) { dataGridView2.Rows.Add(loggedresult[0], "מנהל/ת פורום*", mu + loggedresult1[0]);  } // ווינר אצל מנהל
                    else if (loggedresult5[0].CompareTo(" #ff8600") == 0) { dataGridView2.Rows.Add(loggedresult[0], "משתמש/ת כבוד", mu + loggedresult1[0]); }
                    else if (loggedresult5[0].CompareTo("#b3297a") == 0) { dataGridView2.Rows.Add(loggedresult[0], "מנהל/ת בכיר/ה", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#3ab085") == 0) { dataGridView2.Rows.Add(loggedresult[0], "צוות סיקורים", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#33ccff") == 0) { dataGridView2.Rows.Add(loggedresult[0], "צוות הגהה", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#0099ff") == 0) { dataGridView2.Rows.Add(loggedresult[0], "צוות כחולבן", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#008bbb") == 0) { dataGridView2.Rows.Add(loggedresult[0], "עדכוני מולטימדיה", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#690190") == 0) { dataGridView2.Rows.Add(loggedresult[0], "צוות פרוייקטים", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#daa250") == 0) { dataGridView2.Rows.Add(loggedresult[0], "צוות משחקים", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#b52b52") == 0) { dataGridView2.Rows.Add(loggedresult[0], "צוות מעצבים", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#808000") == 0) { dataGridView2.Rows.Add(loggedresult[0], "צוות מארחים", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#cc33cc") == 0) { dataGridView2.Rows.Add(loggedresult[0], "צוות עדכונים", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#cc6699") == 0) { dataGridView2.Rows.Add(loggedresult[0], "צוות עיתונאים", mu + loggedresult1[0]); }
                    else if (loggedresult4[0].CompareTo("#43C6DB") == 0) { dataGridView2.Rows.Add(loggedresult[0], "מנהל/ת השבוע", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#ECB44B") == 0) { dataGridView2.Rows.Add(loggedresult[0], "צ'אמפ", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#000000") == 0) { dataGridView2.Rows.Add(loggedresult[0], "משתמש רגיל", mu + loggedresult1[0]); }
                    else if (loggedresult3[0].CompareTo("#FF8C00") == 0) { dataGridView2.Rows.Add(loggedresult[0], "+ משתמש/ת כבוד", mu + loggedresult1[0]); }
                    else if (loggedresult3[0].CompareTo("#00a671") == 0) { dataGridView2.Rows.Add(loggedresult[0], "מומח/ית", mu + loggedresult1[0]); }
                    else if (loggedresult2[0].CompareTo("#00a671") == 0) { dataGridView2.Rows.Add(loggedresult[0], "משתמש הנהלה", mu + loggedresult1[0]); }
                }
                Clipboard.SetText(alllogged);
                
                for (int x = 0; x < input2.Count; x++)
                {
                    
                    string[] inputprofile = Form1.GetStringInBetween("<a href=\"", "\" class=\"", input2[x], false, false);
                    string[] inputcolor = Form1.GetStringInBetween("color:", "\">", input2[x], false, false);
                    string[] inputstatus = Form1.GetStringInBetween("class=\"", "\" title=", input2[x], false, false);
                    string[] inputname = Form1.GetStringInBetween("title=\"", " ", input2[x], false, false);
                    

                        if (inputcolor[0].CompareTo("#006699") == 0)
                        {
                            using (WebClient webClient1 = new WebClient())
                            {
                                webClient1.Encoding = Encoding.UTF8;
                                content2 = webClient1.DownloadString(mu + inputprofile[0]);
                                if (content2.Contains(inputname[0] + " מחובר/ת כרגע")) { dataGridView2.Rows.Add(inputname[0], "מנהל/ת ראשי/ת", mu + inputprofile[0]); }
                            }
                        }
                        else if (inputcolor[0].CompareTo("yellowgreen") == 0)
                        {
                            using (WebClient webClient1 = new WebClient())
                            {
                                webClient1.Encoding = Encoding.UTF8;
                                content3 = webClient1.DownloadString(mu + inputprofile[0]);
                                if (content3.Contains(inputname[0] + " מחובר/ת כרגע")) { dataGridView2.Rows.Add(inputname[0], "מנכ\"ל/ית", mu + inputprofile[0]); }
                            }
                           
                        }


                        else if (inputcolor[0].CompareTo("#f570f0") == 0)
                        {
                            using (WebClient webClient1 = new WebClient())
                            {
                                webClient1.Encoding = Encoding.UTF8;
                                content3 = webClient1.DownloadString(mu + inputprofile[0]);
                                if (content3.Contains(inputname[0] + " מחובר/ת כרגע")) { dataGridView2.Rows.Add(inputname[0], "יו\"ר האתר", mu + inputprofile[0]);  }
                            }
                            
                        }
                        label3.Text = "(" + ((this.dataGridView2.Rows.Count)-1) +")";
                    }
                    list.Clear();
                    content1 = "";
                }


                var cells = dataGridView2.Rows.Cast<DataGridViewRow>()
             .SelectMany(row => dataGridView2.Columns.Cast<DataGridViewColumn>()
                              .Select(col => row.Cells[col.Name]))
             .Where(cell => Convert.ToString(cell.Value).Contains("מפקח/ת"));
                foreach (var cell in cells)
                {
                    cell.Style.ForeColor = Color.Blue;
                }

                var cells1 = dataGridView2.Rows.Cast<DataGridViewRow>()
             .SelectMany(row => dataGridView2.Columns.Cast<DataGridViewColumn>()
                              .Select(col => row.Cells[col.Name]))
             .Where(cell1 => Convert.ToString(cell1.Value).Contains("מנהל/ת פורום"));
                foreach (var cell1 in cells1)
                {
                    cell1.Style.ForeColor = Color.Red;
                }

                var cells2 = dataGridView2.Rows.Cast<DataGridViewRow>()
             .SelectMany(row => dataGridView2.Columns.Cast<DataGridViewColumn>()
                              .Select(col => row.Cells[col.Name]))
             .Where(cell2 => Convert.ToString(cell2.Value).Contains("מנהל/ת ראשי/ת"));
                foreach (var cell2 in cells2)
                {
                    cell2.Style.ForeColor = System.Drawing.ColorTranslator.FromHtml("#006699");
                }

                var cells3 = dataGridView2.Rows.Cast<DataGridViewRow>()
             .SelectMany(row => dataGridView2.Columns.Cast<DataGridViewColumn>()
                              .Select(col => row.Cells[col.Name]))
             .Where(cell3 => Convert.ToString(cell3.Value).Contains("מנכ\"ל/ית"));
                foreach (var cell3 in cells3)
                {
                    cell3.Style.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D7FF5D");
                }
                var cells4 = dataGridView2.Rows.Cast<DataGridViewRow>()
             .SelectMany(row => dataGridView2.Columns.Cast<DataGridViewColumn>()
                              .Select(col => row.Cells[col.Name]))
             .Where(cell4 => Convert.ToString(cell4.Value).Contains("משתמש/ת כבוד"));
                foreach (var cell4 in cells4)
                {

                    cell4.Style.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff8600");
                }
                var cells5 = dataGridView2.Rows.Cast<DataGridViewRow>()
                 .SelectMany(row => dataGridView2.Columns.Cast<DataGridViewColumn>()
                                  .Select(col => row.Cells[col.Name]))
                 .Where(cell5 => Convert.ToString(cell5.Value).Contains("יו\"ר האתר"));
                foreach (var cell5 in cells5)
                {
                    cell5.Style.ForeColor = System.Drawing.ColorTranslator.FromHtml("#f570f0");
                }
                var cells6 = dataGridView2.Rows.Cast<DataGridViewRow>()
                    .SelectMany(row => dataGridView2.Columns.Cast<DataGridViewColumn>()
                                     .Select(col => row.Cells[col.Name]))
                    .Where(cell6 => Convert.ToString(cell6.Value).Contains("+ משתמש/ת כבוד"));
                foreach (var cell6 in cells6)
                {
                    cell6.Style.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF8C00");
                }

                var cells7 = dataGridView2.Rows.Cast<DataGridViewRow>()
                        .SelectMany(row => dataGridView2.Columns.Cast<DataGridViewColumn>()
                                         .Select(col => row.Cells[col.Name]))
                        .Where(cell7 => Convert.ToString(cell7.Value).Contains("מנהל/ת בכיר/ה"));
                foreach (var cell7 in cells7)
                {
                    cell7.Style.ForeColor = System.Drawing.ColorTranslator.FromHtml("#b3297a");
                }


            }
        

        public static List<string> removeDuplicates(List<string> inputList)
        {
            Dictionary<string, int> uniqueStore = new Dictionary<string, int>();
            List<string> finalList = new List<string>();

            foreach (string currValue in inputList)
            {
                if (!uniqueStore.ContainsKey(currValue))
                {
                    uniqueStore.Add(currValue, 0);
                    finalList.Add(currValue);
                }
            }
            return finalList;
        }
        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sUrl = dataGridView2.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            ProcessStartInfo sInfo = new ProcessStartInfo(sUrl);
            Process.Start(sInfo);
        }


        private void Form3_FormClose(object sender, FormClosedEventArgs e)
        {

            System.Windows.Forms.Application.Restart();
        }



    }



}

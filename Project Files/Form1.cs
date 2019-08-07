using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using FxP;
using System.Web;
using System.Collections.Specialized;

// Developer: Tomer Simantov
// Created due to 23/9/15
namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string You = "http://admin.fxp.co.il/ManagemenT/user.php?do=editaccess&u=";
            You += textBox2.Text + "&pid=" + textBox1.Text;
            System.Diagnostics.Process.Start(You);
            textBox1.Text = "";
            textBox2.Text = "";
            Status.ForeColor = System.Drawing.Color.Blue;
            Status.Text = "נכנסת למערכת ההרשאות הידניות";
            Application.DoEvents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string You = "<a href=\"/forumdisplay.php?f=";
            You += CatgID.Text + "\"target=\"_self\" style=\"text-decoration:none; font-weight:bold; font-size:10pt; color:#0099FF;\">" + Text2.Text + "</a>";
            Clipboard.SetText(You);
            CatgID.Text = "";
            Text2.Text = "";
            Status.ForeColor = System.Drawing.Color.Blue;
            Status.Text = "יש לך תת ניק מוכן למפקח, רק להדביק וזהו";
            Application.DoEvents();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string c1 = "<span style=\"color:";
            string c3 = ";font-size:8pt;font-weight: bold;\">";
            string c4 = ";font-size:10pt;font-weight: bold;\">";
            string c2 = "</span>";
            string You1 = "<span class=\"mo\">";
            if (comboBox1.Text.CompareTo("מנהלים") == 0){
                You1 += Text1.Text + "</span>";
                Clipboard.SetText(You1);}
            if (comboBox1.Text.CompareTo("משתמש כבוד") == 0){
                c1 += "#FF8C00" + c4 + Text1.Text + c2;
                Clipboard.SetText(c1);}
            if (comboBox1.Text.CompareTo("צוות עיתונאים") == 0)
            {
                c1 += "#cc6699" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);}
            if (comboBox1.Text.CompareTo("צוות סיקורים") == 0)
            {
                c1 += "#3AB085" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("צוות הגהה") == 0)
            {
                c1 += "#33CCFF" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("צוות כחולבן") == 0)
            {
                c1 += "#0099FF" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("צוות עדכוני מולטימדיה") == 0)
            {
                c1 += "#008B8B" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("צוות פרוייקטים") == 0)
            {
                c1 += "#690190" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("צוות משחקים") == 0)
            {
                c1 += "#daa250" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("צוות מעצבים") == 0)
            {
                c1 += "#B52B52" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("צוות מארחים") == 0)
            {
                c1 += "#808000" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("צוות עדכונים") == 0)
            {
                c1 += "#CC33CC" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("צוות דיבורים") == 0)
            {
                c1 += "#2FA52D" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("ניהול בכיר") == 0)
            {
                c1 += "#B3297A" + c4 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("צוות תוכן") == 0)
            {
                c1 += "#3366CC" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("צוות האולימפוס") == 0)
            {
                c1 += "#006699" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("משתמש ומנהל השבוע") == 0)
            {
                c1 += "#0099ff" + c4 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("דרגת משקיען כבוד") == 0)
            {
                c1 += "#008B8B" + c4 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("דרגת הדיאמונד") == 0)
            {
                c1 += "#6699FF" + c4 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("דרגת הצ'אמפ") == 0)
            {
                c1 += "#DAA520" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }
            if (comboBox1.Text.CompareTo("דרגת הווינר") == 0)
            {
                c1 += "#000066" + c3 + Text1.Text + c2;
                Clipboard.SetText(c1);
            }



            Text1.Text = "";
            Status.ForeColor = System.Drawing.Color.Red;
            Status.Text = "יש לך תת ניק מוכן, רק להדביק וזהו";
            Application.DoEvents();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string You2 = "<span style=\"color:";
            You2 += ForumColor.Text + ";\">" + ForumName.Text + "</span>";
            Clipboard.SetText(You2);
            ForumColor.Text = "";
            ForumName.Text = "";
            Status.ForeColor = System.Drawing.Color.Green;
            Status.Text = "עכשיו יש לך שם מוכן לפורום, רק להדביק וזהו";
            Application.DoEvents();
        }

        private void CopyPic_Click(object sender, EventArgs e)
        {
            string You4 = "<img src=\"";
            You4 += PicTitle.Text + " \">";
            Clipboard.SetText(You4);
            PicTitle.Text = "";
            Status.ForeColor = System.Drawing.Color.Orange;
            Status.Text = "עכשיו יש לך תת ניק תמונה מוכן, רק להדביק וזה..";
            Application.DoEvents();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "")
            {
                string You5 = "http://www.fxp.co.il/modcp/banning.php?do=banuser&username=";
                You5 += Nickname.Text;
                System.Diagnostics.Process.Start(You5);
                Nickname.Text = "";
                Status.ForeColor = System.Drawing.Color.Red;
                Status.Text = "נכנסתי למערכת ההרחקה, תבלה בנעימים";
                Application.DoEvents();
            }

            if (UserID.Text != "")
            {
                string You6 = "http://www.fxp.co.il/modcp/banning.php?do=banuser&u=";
                You6 += UserID.Text;
                System.Diagnostics.Process.Start(You6);
                UserID.Text = "";
                Status.ForeColor = System.Drawing.Color.Red;
                Status.Text = "נכנסתי למערכת ההרחקה, תבלה בנעימים";
                Application.DoEvents();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (ProfileName.Text != "")
            {
                string You8 = "http://www.fxp.co.il/member.php?username=";
                You8 += ProfileName.Text;
                System.Diagnostics.Process.Start(You8);
                Status.ForeColor = System.Drawing.Color.Blue;
                Status.Text = "נכנסתי לפרופיל של " + ProfileName.Text;
                ProfileName.Text = "";
                Application.DoEvents();

            }

            if (ProfileID.Text != "")
            {
                string You9 = "http://www.fxp.co.il/member.php?u=";
                You9 += ProfileID.Text;
                System.Diagnostics.Process.Start(You9);
                Status.ForeColor = System.Drawing.Color.Blue;
                Status.Text = "נכנסתי לפרופיל של איידי " + ProfileID.Text;
                ProfileID.Text = "";
                Application.DoEvents();
            }

        }


        private void button8_Click(object sender, EventArgs e)
        {
            string You10 = "http://images.fxp.co.il/forumbg/";
            You10 += Banner.Text + ".gif";
            using (WebClient client = new WebClient())
            {
                string fileName = Path.GetFileName(You10);
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (RemoteFileExists(You10) == true)
                {

                    client.DownloadFile(You10, path + @"\" + fileName);
                    Status.ForeColor = System.Drawing.Color.Green;
                    Status.Text = " הורדתי לשולחן העבודה, גאון שכמותי ";
                    Application.DoEvents();
                    Banner.Text = "";
                    fileName = null;
                }
                else
                {
                    Status.ForeColor = System.Drawing.Color.Red;
                    Status.Text = "אי אפשר להוריד.. בטח טעית בפורום";
                    Application.DoEvents();
                }


            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string You11 = "http://www.fxp.co.il/forumdisplay.php?f=";
            You11 += ForumID1.Text + "&daysprune=" + Days.Text;
            System.Diagnostics.Process.Start(You11);
            Status.ForeColor = System.Drawing.Color.Green;
            Status.Text = "האשכולות ב-" + Days.Text + " הימים האחרונים בפורום מספר " + ForumID1.Text;
            ProfileID.Text = "";
        }

        private bool RemoteFileExists(string url)
        {
            try
            {
                //Creating the HttpWebRequest
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //Setting the Request method HEAD, you can also use GET too.
                request.Method = "HEAD";
                //Getting the Web Response.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Returns TURE if the Status code == 200
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                //Any exception will returns false.
                return false;
            }
        }
        private void Status_Click(object sender, EventArgs e)
        {
            Status.Text = "סתם כי זה כיף ללחוץ עליי(:";
            Status.ForeColor = System.Drawing.Color.Pink;
        }
        private void make_Click(object sender, EventArgs e)
        {
            string text = editor.Text;
            string colorselect;

            if (editor.Text != "")
            {
                // תגיות מיותרות
                if (text.IndexOf("[RIGHT]") != -1)
                {
                    editor.Rtf = editor.Rtf.Replace("[RIGHT]", "");
                    editor.Rtf = editor.Rtf.Replace("[/RIGHT]", "");
                }
                if (text.IndexOf("[CENTER]") != -1)
                {
                    editor.Rtf = editor.Rtf.Replace("[CENTER]", "");
                    editor.Rtf = editor.Rtf.Replace("[/CENTER]", "");
                }
                if (text.IndexOf("[LEFT]") != -1)
                {
                    editor.Rtf = editor.Rtf.Replace("[LEFT]", "");
                    editor.Rtf = editor.Rtf.Replace("[/LEFT]", "");
                }
                // צבע
                if (text.IndexOf("[COLOR=") != -1)
                {
                    string[] result = GetStringInBetween("[COLOR=", "]", editor.Text, false, false);
                    string color = result[0];
                    label16.ForeColor = System.Drawing.Color.Green;
                    label16.Text = color;
                    editor.Rtf = editor.Rtf.Replace("[COLOR=" + color + "]", "");
                    editor.Rtf = editor.Rtf.Replace("[/COLOR]", "");
                    Application.DoEvents();
                    colorselect = "color:" + color + ";";
                }
                else
                {
                    label16.ForeColor = System.Drawing.Color.Red;
                    label16.Text = "אין";
                    Application.DoEvents();
                    colorselect = "";
                }
                // גודל
                string selectsize;
                if (text.IndexOf("[SIZE=") != -1)
                {
                    string[] result1 = GetStringInBetween("[SIZE=", "]", editor.Text, false, false);
                    int[] realsize = new int[7];
                    realsize[0] = Convert.ToInt32(result1[0]);
                    if (realsize[0] == 1) { realsize[0] = 8; }
                    if (realsize[0] == 2) { realsize[0] = 10; }
                    if (realsize[0] == 3) { realsize[0] = 12; }
                    if (realsize[0] == 4) { realsize[0] = 14; }
                    if (realsize[0] == 5) { realsize[0] = 16; }
                    if (realsize[0] == 6) { realsize[0] = 18; }
                    if (realsize[0] == 7) { realsize[0] = 20; }
                    int size = realsize[0];
                    sizelabel.ForeColor = System.Drawing.Color.Green;
                    sizelabel.Text = result1[0];
                    editor.Rtf = editor.Rtf.Replace("[SIZE=" + result1[0] + "]", "");
                    editor.Rtf = editor.Rtf.Replace("[/SIZE]", "");
                    Application.DoEvents();
                    selectsize = "font-size:" + size + "pt;";
                }
                else
                {
                    selectsize = "";
                    sizelabel.ForeColor = System.Drawing.Color.Red;
                    sizelabel.Text = "אין";
                }
                // בולד
                string selectbold;
                if (text.IndexOf("[B]") != -1)
                {
                    boldlabel.ForeColor = System.Drawing.Color.Green;
                    boldlabel.Text = "יש";
                    editor.Rtf = editor.Rtf.Replace("[B]", "");
                    editor.Rtf = editor.Rtf.Replace("[/B]", "");
                    selectbold = "font-weight:bold;";
                    Application.DoEvents();
                }
                else
                {
                    boldlabel.ForeColor = System.Drawing.Color.Red;
                    boldlabel.Text = "אין";
                    selectbold = "";
                    Application.DoEvents();
                }
                // פונט
                string fontselect;
                if (text.IndexOf("[FONT=") != -1)
                {
                    string[] result2 = GetStringInBetween("[FONT=", "]", editor.Text, false, false);
                    string font = result2[0];
                    fontlabel.TextAlign = ContentAlignment.MiddleRight;
                    fontlabel.ForeColor = System.Drawing.Color.Green;
                    fontlabel.Text = font;
                    if (font.CompareTo("arial") == 0) { fontselect = ""; fontlabel.Text = "Arial"; }
                    else{fontselect = "font-family:" + font + ";";}
                    editor.Rtf = editor.Rtf.Replace("[FONT=" + font + "]", "");
                    editor.Rtf = editor.Rtf.Replace("[/FONT]", "");
                    Application.DoEvents();}
                else
                {
                    fontlabel.Text = "Arial";
                    fontlabel.ForeColor = System.Drawing.Color.Red;
                    fontlabel.TextAlign = ContentAlignment.MiddleRight;
                    fontselect = "";
                    Application.DoEvents();}
                // קו תחתון
                string underline;
                if (text.IndexOf("[U]") != -1)
                {
                    Ulabel.ForeColor = System.Drawing.Color.Green;
                    Ulabel.Text = "יש";
                    editor.Rtf = editor.Rtf.Replace("[U]", "");
                    editor.Rtf = editor.Rtf.Replace("[/U]", "");
                    Application.DoEvents();
                    underline = "text-decoration:underline;";
                }
                else
                {
                    Ulabel.ForeColor = System.Drawing.Color.Red;
                    Ulabel.Text = "אין";
                    Application.DoEvents();
                    underline = "";
                }
                // קו נטוי
                string italic;
                if (text.IndexOf("[I]") != -1)
                {
                    Ilabel.ForeColor = System.Drawing.Color.Green;
                    Ilabel.Text = "יש";
                    editor.Rtf = editor.Rtf.Replace("[I]", "");
                    editor.Rtf = editor.Rtf.Replace("[/I]", "");
                    Application.DoEvents();
                    italic = "font-style:italic;";
                }
                else
                {
                    Ilabel.ForeColor = System.Drawing.Color.Red;
                    Ilabel.Text = "אין";
                    Application.DoEvents();
                    italic = "";
                }
                // תמונה
                string image;
                if (text.IndexOf("[IMG]") != -1)
                {
                    string fileName3;
                    string[] result3 = GetStringInBetween("[IMG]", "[/IMG]", editor.Text, false, false);
                    string img = result3[0];
                    using (WebClient client1 = new WebClient())
                    { fileName3 = Path.GetFileName(img); }
                    piclabel.TextAlign = ContentAlignment.MiddleRight;
                    piclabel.ForeColor = System.Drawing.Color.Green;
                    piclabel.Text = fileName3;
                    editor.Rtf = editor.Rtf.Replace("[IMG]" + img, "");
                    editor.Rtf = editor.Rtf.Replace("[/IMG]", "");
                    Application.DoEvents();
                    image = "<img src=\"" + img + "\" />";
                }
                else
                {
                    piclabel.ForeColor = System.Drawing.Color.Red;
                    piclabel.Text = "אין";
                    Application.DoEvents();
                    image = "";
                }
               
                string finaltitle = "<span style=\"" + fontselect + colorselect + selectsize + selectbold + underline + italic + "\">" + editor.Text + "</span>" + image;
                string finaltitle2 = "";
                if ((finaltitle.Count()) <= 146)
                {
                    if (finaltitle.Contains(("<span style=\"\">")) == true)
                    {
                        finaltitle2 = finaltitle.Replace("<span style=\"\">", "<span style>");
                        Clipboard.SetText(finaltitle2);
                    }
                    else 
                    { 
                        Clipboard.SetText(finaltitle); 
                    }
                Status.ForeColor = System.Drawing.Color.DarkBlue;
                Status.Text = "הקוד מוכן, להדביק ולבדוק שהכל בסדר(:";
                editor.Rtf = editor.Rtf.Replace(editor.Text, "");
                Application.DoEvents(); }
                else
                {
                    Status.ForeColor = System.Drawing.Color.Red;
                    Status.Text = "הקוד ארוך מדי";
                    Application.DoEvents();
                }
                
            }
        }
        public static string[] GetStringInBetween(string strBegin,
    string strEnd, string strSource, bool includeBegin, bool includeEnd)
        {
            string[] result = { "", "" };
            int iIndexOfBegin = strSource.IndexOf(strBegin);
            if (iIndexOfBegin != -1)
            {
                // include the Begin string if desired
                if (includeBegin)
                    iIndexOfBegin -= strBegin.Length;
                strSource = strSource.Substring(iIndexOfBegin
                    + strBegin.Length);
                int iEnd = strSource.IndexOf(strEnd);
                if (iEnd != -1)
                {
                    // include the End string if desired
                    if (includeEnd)
                        iEnd += strEnd.Length;
                    result[0] = strSource.Substring(0, iEnd);
                    // advance beyond this segment
                    if (iEnd + strEnd.Length < strSource.Length)
                        result[1] = strSource.Substring(iEnd
                            + strEnd.Length);
                }
            }
            else
                // stay where we are
                result[1] = strSource;
            return result;
        }
        private void Logged_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            this.Hide();
            fm3.ShowDialog();
            this.Close();
            }
        private void tabPage4_Click(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void CheckifAvailable_Click(object sender, EventArgs e)
        {
            string available;
            string checkedname = "http://www.fxp.co.il/member.php?username=" + ifAvailable.Text;
            using (WebClient webClient11 = new WebClient())
            {
                webClient11.Encoding = Encoding.UTF8;
                available = webClient11.DownloadString(checkedname);
            }
            if (available.Contains("משתמש זה לא נרשם ומשום כך אין לו פרופיל אשר ניתן לצפות בו."))
            {
                Status.ForeColor = System.Drawing.Color.Green;
                Status.Text = " השם " + ifAvailable.Text + " פנוי ";
            }
            else
            {
                Status.ForeColor = System.Drawing.Color.Red;
                Status.Text = " השם " + ifAvailable.Text + " תפוס ";

            }
                Application.DoEvents();
        }
        private void ifAvailable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckifAvailable.PerformClick();
            }
        }
        private void editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                make.PerformClick();
            }
        }
        private void Text1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        
        
        }
        private void Text2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        
        }
        private void ProfileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button7.PerformClick();
            }
        }
        private void ProfileID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button7.PerformClick();
            }
        }
        private void Banner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button8.PerformClick();
            }
        }
        private void ForumID1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button6.PerformClick();
            }
        }
        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void MakeTitle_Click(object sender, EventArgs e)
        {
            string fontselect;
            string colorselect;
            string realsize1;
            if (editor0.Text != null)
            {
                if (editor0.Text.IndexOf("[RIGHT]") != -1)
                {
                    editor0.Text = editor0.Text.Replace("[RIGHT]", "");
                    editor0.Text = editor0.Text.Replace("[/RIGHT]", "");
                }
                if (editor0.Text.IndexOf("[CENTER]") != -1)
                {
                    editor0.Text = editor0.Text.Replace("[CENTER]", "");
                    editor0.Text = editor0.Text.Replace("[/CENTER]", "");
                }
                if (editor0.Text.IndexOf("[LEFT]") != -1)
                {
                    editor0.Text = editor0.Text.Replace("[LEFT]", "");
                    editor0.Text = editor0.Text.Replace("[/LEFT]", "");
                }
                if (fontselect1.Text == "")
                {
                    fontselect = "";
                }
                else
                {
                    if (MakeTitle.Enabled == false)
                    {
                        MakeTitle.Enabled = true;
                        fontselect = "font-family:" + fontselect1.Text + ";";
                    }
                    else { fontselect = ""; }
                    if (colorselect1.Text != "")
                    {
                        colorselect = "color:" + colorselect1.Text + ";";
                    }
                    else { colorselect = ""; }

                    if (selectsize1.Text != "")
                    {
                        if (selectsize1.Text == "1") { selectsize1.Text = "8"; }
                        if (selectsize1.Text == "2") { selectsize1.Text = "10"; }
                        if (selectsize1.Text == "3") { selectsize1.Text = "12"; }
                        if (selectsize1.Text == "4") { selectsize1.Text = "14"; }
                        if (selectsize1.Text == "5") { selectsize1.Text = "16"; }
                        if (selectsize1.Text == "6") { selectsize1.Text = "18"; }
                        if (selectsize1.Text == "7") { selectsize1.Text = "20"; }
                        realsize1 = "font-size:" + selectsize1.Text + "pt;";}
                        else { realsize1 = ""; }

                    string You4;
                    if (image1.Text != "")
                    {
                        You4 = "<img src=\"" + image1.Text + " \">";   
                    }
                    else { You4 = ""; }
                    
                    string italic3;
                    string underline;
                    string selectbold3;
                    if (italic1.Enabled == true) { italic3 = "font-style:italic;"; } else { italic3 = ""; }
                    if (underline1.Enabled == true) { underline = "text-decoration:underline;"; } else { underline = ""; }
                    if (selectbold1.Enabled == true) { selectbold3 = "font-weight:bold;"; } else { selectbold3 = ""; }
                    string finaltitlee = "<span style=\"" + fontselect + colorselect + realsize1 + selectbold3 + underline + italic3 + "\">" + editor0.Text + "</span>" + You4;
                    Clipboard.SetText(finaltitlee);
                    selectsize1.Text = "";
                    editor0.Text = "";
                    colorselect1.Text = "";
                    fontselect1.Text = "";
                    italic1.Checked = false;
                    underline1.Checked = false;
                    selectbold1.Checked = false;
                    image1.Text = "";
                    Status.ForeColor = System.Drawing.Color.DarkBlue;
                    Status.Text = "הקוד מוכן, להדביק ולבדוק שהכל בסדר(:";
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   
 
    }
}
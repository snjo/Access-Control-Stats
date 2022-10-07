using Microsoft.VisualBasic;

namespace Access_Control_Stats
{
    public partial class Form1 : Form
    {

        //private List<string> date;
        //private List<string> name;
        private List<DateAndUser> dateAnduserList = new List<DateAndUser>();
        private DateList dateList = new DateList();

        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null)
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            }
            else
            {
                errorLog.Text += "Drag and drop e.Data is null\n";
            }
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                labelFileName.Text = files[0];
                parseCSV(files[0]);
                outputResult();
            }
            else
            {
                errorLog.Text += "Drag and drop e.Data is null\n";
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            string fileName = openFileDialog1.FileName;
            labelFileName.Text = fileName;
            parseCSV(fileName);
            outputResult();            
        }

        private void parseCSV(string fileName)
        {
            if (fileName.Length < 5) return;
            errorLog.Text += "Filename Length: " + fileName.Length + "\n"; 
            string fileExtension = fileName.Substring(fileName.Length-3, 3);
            if (fileExtension.ToLower() != "csv")
                errorLog.Text += "File Extension is not .csv!\n";
            StreamReader reader = new StreamReader(fileName);

            errorLog.Text += "Loading file " + fileName + "\n";            
            var skip = reader.ReadLine(); // skip first line with the headers ---------------------------------
            if (skip != null)
            {
                errorLog.Text += "Skipping first line with header " + skip + "\n";
            }
            

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    string[] values = line.Split(';');

                    string dateText = values[0].Trim('"');
                    try
                    {
                        DateTime newDate = DateTime.ParseExact(dateText, "yyyy-MM-dd HH:mm:ss", null);
                        string shortDate = newDate.Date.ToString();
                        string newName = values[1];
                        dateAnduserList.Add(new DateAndUser(shortDate, newName));
                    }
                    catch
                    {
                        errorLog.Text += "Line not in format \"2022-12-31 23:59:59\"; \"Name\"\n";
                    }
                    
                }
                else
                {
                    errorLog.Text += "StreamReader error!\n";
                }
            }
        }

        private void outputResult()
        {
            int maxLines = 100000;  // TEST, REMOVE LATER!!! <-----------------------------------------------------
            errorLog.Text += "Lines in the CSV: " + dateAnduserList.Count + "\n";

            for (int i = 0; i < dateAnduserList.Count && i < maxLines; i++)
            {
                dateList.AddUser(dateAnduserList[i].date, dateAnduserList[i].name);          
            }
            //textResult.Text += "\n-------------------\n";
            foreach (KeyValuePair<string, UserList> entry in dateList.dates)
            {
                textResult.Text += entry.Key.Substring(0,10) + " : " + entry.Value.names.Count +  "\n";
                if (checkFullList.Checked)
                {
                    foreach (string n in entry.Value.names)
                    {
                        textResult.Text += "   " + n + "\n";
                    }
                }
            }
        }


    }

    public class DateAndUser
    {
        public DateAndUser (string date, string name)
        {
            this.date = date;
            this.name = name;
        }

        public string date;
        public string name;
    }

    public class UserList
    {
        public string date;
        public List<string> names;

        public UserList(string date)
        {
            this.date = date;
            this.names = new List<string>();
        }

        public void Add(string name)
        {
            if (!names.Contains(name))
            {
                names.Add(name);
            }
        }
    }

    public class DateList
    {
        public List<UserList> dateList = new List<UserList> ();
        public Dictionary<string, UserList> dates = new Dictionary<string, UserList> ();

        public void Add(string date)
        {
            if (!dates.ContainsKey(date))
            {
                dates.Add(date, new UserList(date));
            }
        }

        public void AddUser(string date, string name)
        {
            if (!dates.ContainsKey(date))
            {
                Add(date);
            }
            dates[date].Add(name);
        }
    }
}
using Microsoft.VisualBasic;

namespace Access_Control_Stats
{
    public partial class Form1 : Form
    {

        private List<string> date;
        private List<string> name;
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
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            labelFileName.Text = files[0];//Console.WriteLine(file);
            parseCSV(files[0]);
            outputResult();
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
            if (fileName.Length < 1) return;
            StreamReader reader = new StreamReader(fileName);
            //date = new List<string>();
            //name = new List<string>();

            var skip = reader.ReadLine(); // skip first line
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
                        labelFileName.Text = "Not a valid file";
                    }
                    
                }
                else
                {
                    labelFileName.Text = "StreamReader error!";
                }
            }
        }

        private void outputResult()
        {
            int maxLines = 100000;  // TEST, REMOVE LATER!!! <-----------------------------------------------------
            textResult.Text = "Lines in the CSV: " + dateAnduserList.Count + "\n";

            //List<string> namesInDate = new List<string>();

            for (int i = 0; i < dateAnduserList.Count && i < maxLines; i++)
            {
                dateList.AddUser(dateAnduserList[i].date, dateAnduserList[i].name);    
                
                //textResult.Text += dateAnduserList[i].date + " : " + dateAnduserList[i].name + "\n";             
            }
            textResult.Text += "\n-------------------\n";
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
        //private List<string> dates = new List<string>();
        public Dictionary<string, UserList> dates = new Dictionary<string, UserList> ();

        public void Add(string date)
        {
            //if (!dates.ContainsKey)
            if (!dates.ContainsKey(date))
            {
                dates.Add(date, new UserList(date));
                //dateList.Add(new UserList(date));
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
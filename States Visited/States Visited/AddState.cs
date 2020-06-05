using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace StatesVisited
{
    public partial class AddState : Form
    {
        Dictionary<string, int> StateMapper = new Dictionary<string, int>();
        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "States_Visited", "states.visited");

        //Easily Changes line in a file. Source: https://stackoverflow.com/questions/1971008/edit-a-specific-line-of-a-text-file-in-c-sharp
        static void LineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        public AddState()
        {
            InitializeComponent();
        }

        private void AddState_Load(object sender, EventArgs e)
        {
            
            int index = 0;

            //Importing resource data from: https://stackoverflow.com/questions/15722455/read-text-file-from-c-sharp-resources
            string resource_data = Properties.Resources.StateList;
            List<string> statesForList = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string state in statesForList)
            {
                New_State.Items.Add(state);
                StateMapper.Add(state, index);
                index++;
            }

            Year_Selector.Value = Convert.ToInt32(DateTime.Now.Year.ToString());

            New_State.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            New_State.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            //Code When this exits
        }

        private void Visit_Button_Click(object sender, EventArgs e)
        {
            if (StateMapper.ContainsKey(New_State.Text))
            {
                int statenumber = StateMapper[New_State.Text];
                LineChanger(Convert.ToString(Year_Selector.Value), path, statenumber);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Selection", "Error");
            }

        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            if (StateMapper.ContainsKey(New_State.Text))
            {
                int statenumber = StateMapper[New_State.Text];
                LineChanger("0000", path, statenumber);
            }
            else
            {
                MessageBox.Show("Invalid Selection", "Error");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;


namespace StatesVisited
{

    //Note: The icon for this application was derived from: https://upload.wikimedia.org/wikipedia/commons/8/88/United-states_flag_icon_round.svg
    public partial class Form1 : Form
    {
        //Comparator Function from: https://stackoverflow.com/questions/33119930/listview-sort-by-column
        protected class ListViewItemComparer : IComparer
        {

            private int col;
            private SortOrder order;
            public ListViewItemComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }
            public ListViewItemComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }
            public int Compare(object x, object y)
            {
                int returnVal = -1;
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                ((ListViewItem)y).SubItems[col].Text);
                // Determine whether the sort order is descending.
                if (order == SortOrder.Descending)
                    // Invert the value returned by String.Compare.
                    returnVal *= -1;
                return returnVal;
            }


        }

        //Easily Changes line in a file. Source: https://stackoverflow.com/questions/1971008/edit-a-specific-line-of-a-text-file-in-c-sharp
        static void LineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private static Mutex editor = new Mutex();
        private static Mutex addstatewindow = new Mutex();
        string[] g_states = new string[51];
        Dictionary<string, int> StateMapper = new Dictionary<string, int>();
        Dictionary<int, string> StateMapperReverse = new Dictionary<int, string>();

        public Form1()
        {
            InitializeComponent();
        }

        //Mode Algorithm based on https://social.msdn.microsoft.com/Forums/azure/en-US/d9bdc9fa-1cfa-4349-b9af-77436f102045/c-list-to-find-the-mode-and-median?forum=csharpgeneral
        public static int GetMode(string[] input)
        {
            int[] states = new int[51];
            if (input != null) //This should never throw but it makes the program more stable
            {
                for (int i = 0; i < 51; i++)
                {
                    states[i] = Convert.ToInt32(input[i]);
                }
            }

            // Initialize the return value
            int mode = default(int);
            // Test for a null reference and an empty list
            if (states != null && states.Count() > 0)
            {
                // Store the number of occurences for each element
                Dictionary<int, int> counts = new Dictionary<int, int>();
                counts.Add(0, 0);
                // Add one to the count for the occurence of a character
                foreach (int element in states)
                {
                    if (element != 0)
                    {
                        if (counts.ContainsKey(element))
                            counts[element]++;
                        else
                            counts.Add(element, 1);
                    }
                }
                // Loop through the counts of each element and find the 
                // element that occurred most often
                int max = 0;
                foreach (KeyValuePair<int, int> count in counts)
                {
                    if (count.Value > max)
                    {
                        // Update the mode
                        mode = count.Key;
                        max = count.Value;
                    }
                }
            }
            return mode;
        }

        new public void Update()
        {
            //Ensure only one thread of this function can run and the global array isn't being edited
            editor.WaitOne();

            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "States_Visited", "states.visited");
            g_states = File.ReadLines(path).ToArray();
            int states_visited = 0;


            //Set Up List
            string[] arr = new string[4];
            ListViewItem itm;

            listView1.Items.Clear();

            //Count States Visted and include them in the list
            for (int i = 0; i < 51; i++)
            {
                if (g_states[i] != "0000")
                {
                    //count them
                    states_visited++;

                    //Add Them to the list
                    arr[0] = StateMapperReverse[i];
                    arr[1] = g_states[i];
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
            double percentage = 0;
            if (g_states[0] == "0000")
            {
                percentage = (states_visited / 50.0) * 100;
            }
            if (g_states[0] != "0000")
            {
                percentage = ((states_visited - 1)/ 50.0) * 100;
            }
            double percentageDC = (states_visited / 51.0) * 100;
            percentage = Math.Round(percentage, 2);
            percentageDC = Math.Round(percentageDC, 2);
            
            //Update Labels
            if (g_states[0] == "0000")
            {
                State_Counter_DC.Text = "States Visited (Including Washington DC): " + states_visited + " (" + percentageDC + "%)";
                State_Counter.Text = "States Visited: " + states_visited + " (" + percentage + "%)";
            }
            if (g_states[0] != "0000")
            {
                State_Counter_DC.Text = "States Visited (Including Washington DC): " + states_visited + " (" + percentageDC + "%)";
                State_Counter.Text = "States Visited: " + Convert.ToInt32(states_visited - 1) + " (" + percentage + "%)";
            }
            int mode = GetMode(g_states);
            if (mode == 0)
            {
                Best_Year.Text = "Best Year: N/A";
            }
            if (mode != 0)
            {
                Best_Year.Text = "Best Year: " + Convert.ToString(mode);
            }

            
            //Release Function
            editor.ReleaseMutex();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "States_Visited", "states.visited");
            string dir = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "States_Visited");
            //int states_visited = 0;
            string[] states = new string[51];


            if (!Directory.Exists(dir))  // if the directory doesn't exist, create it and add the fire
            {
                Directory.CreateDirectory(dir);
                for (int i = 0; i < 51; i++)
                {
                    states[i] = "0000";
                }
                System.IO.File.WriteAllLines(Path.Combine(dir, "states.visited"), states);

                
            }
            if (!File.Exists(@path)) // if the file doesn't exist but the directory does, create it. This should not happen unless the user deletes the file
            {
                for (int i = 0; i < 51; i++)
                {
                    states[i] = "0000";
                }
                System.IO.File.WriteAllLines(Path.Combine(dir, "states.visited"), states);
            }
            states = File.ReadLines(path).ToArray();

            editor.WaitOne();
            //Update Global Array
            for (int i = 0; i < 51; i++)
            {
                g_states[i] = states[i];
            }
            editor.ReleaseMutex();

            //Build dictionary
            int index = 0;
            string resource_data = Properties.Resources.StateList;
            List<string> statesForList = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string state in statesForList)
            {
                StateMapperReverse.Add(index, state);
                StateMapper.Add(state, index);
                index++;
            }

            //Draw List
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("State / Location", listView1.Width / 2);
            listView1.Columns.Add("First Visited", listView1.Width / 2);

            //Generate List Connector
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);

            Update();

        }

        private void Visit_A_State_Click(object sender, EventArgs e)
        {
            addstatewindow.WaitOne();
            AddState form2 = new AddState();
            //var dialogResult = form2.ShowDialog();
            form2.ShowDialog();
            addstatewindow.ReleaseMutex();
            Update();
        }

        private void AddNewStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addstatewindow.WaitOne();
            AddState form2 = new AddState();
            //var dialogResult = form2.ShowDialog();
            form2.ShowDialog();
            addstatewindow.ReleaseMutex();
            Update();
        }

        private void UpdateAndSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update();
        }


        private void QuitStatesVisitedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private int sortColumn = -1;
        private void listView1_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                listView1.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listView1.Sorting == SortOrder.Ascending)
                    listView1.Sorting = SortOrder.Descending;
                else
                    listView1.Sorting = SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            listView1.Sort();

            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column,listView1.Sorting);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                string thisstate = listView1.SelectedItems[0].SubItems[0].Text;
                //Dialog Function adapted from: https://www.c-sharpcorner.com/article/dialog-boxes-in-c-sharp/
                DialogResult res = MessageBox.Show("Are you sure you want to remove " + thisstate + "?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "States_Visited", "states.visited");
                    int statenumber = StateMapper[thisstate];
                    LineChanger("0000", path, statenumber);
                    Update();
                }
                if (res == DialogResult.Cancel)
                {
                    
                }
               
            }
        }

        private void EditYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                bool valid = false;
                bool canceled = false;
                int convertedyear = 0;
                string thisstate = listView1.SelectedItems[0].SubItems[0].Text;
                string yearraw = Interaction.InputBox("Enter a new year for " + thisstate, "Edit Year", DateTime.Now.Year.ToString());
                do
                {
                    try
                    {
                        convertedyear = Convert.ToInt32(yearraw);
                        if (convertedyear >= 1900 || convertedyear <= 3000)
                        {
                            valid = true;
                        }
                    }
                    catch(FormatException)
                    {
                        //If the user chooses to cancel then the input dialog returns an empty string
                        //IsNullOrEmpty is the same as =="" but much faster
                        if (String.IsNullOrEmpty(yearraw))
                        {
                            valid = true;
                            canceled = true;
                        }
                        else
                        {
                            yearraw = Interaction.InputBox("Your input is invalid \n" + "Enter a new year for " + thisstate, "Edit Year", DateTime.Now.Year.ToString());
                        }
                    }
                } while (valid == false);
                if (canceled == false)
                {
                    string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "States_Visited", "states.visited");
                    int statenumber = StateMapper[thisstate];
                    LineChanger(yearraw, path, statenumber);
                    Update();
                }

            }
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }
    }
}

namespace StatesVisited
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.State_Counter = new System.Windows.Forms.Label();
            this.Best_Year = new System.Windows.Forms.Label();
            this.State_Counter_DC = new System.Windows.Forms.Label();
            this.Visit_A_State = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAndSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statesVisitedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitStatesVisitedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // State_Counter
            // 
            this.State_Counter.AutoSize = true;
            this.State_Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State_Counter.Location = new System.Drawing.Point(12, 93);
            this.State_Counter.Name = "State_Counter";
            this.State_Counter.Size = new System.Drawing.Size(261, 25);
            this.State_Counter.TabIndex = 0;
            this.State_Counter.Text = "States Visited: 0 (00.00%)";
            // 
            // Best_Year
            // 
            this.Best_Year.AutoSize = true;
            this.Best_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Best_Year.Location = new System.Drawing.Point(12, 143);
            this.Best_Year.Name = "Best_Year";
            this.Best_Year.Size = new System.Drawing.Size(131, 25);
            this.Best_Year.TabIndex = 1;
            this.Best_Year.Text = "Best Year: 0";
            // 
            // State_Counter_DC
            // 
            this.State_Counter_DC.AutoSize = true;
            this.State_Counter_DC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State_Counter_DC.Location = new System.Drawing.Point(12, 43);
            this.State_Counter_DC.Name = "State_Counter_DC";
            this.State_Counter_DC.Size = new System.Drawing.Size(535, 25);
            this.State_Counter_DC.TabIndex = 2;
            this.State_Counter_DC.Text = "States Visited (Including Washington DC): 00 (00.00%)";
            // 
            // Visit_A_State
            // 
            this.Visit_A_State.Location = new System.Drawing.Point(345, 93);
            this.Visit_A_State.Name = "Visit_A_State";
            this.Visit_A_State.Size = new System.Drawing.Size(202, 75);
            this.Visit_A_State.TabIndex = 3;
            this.Visit_A_State.Text = "Visit A State";
            this.Visit_A_State.UseVisualStyleBackColor = true;
            this.Visit_A_State.Click += new System.EventHandler(this.Visit_A_State_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statesToolStripMenuItem
            // 
            this.statesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStateToolStripMenuItem,
            this.updateAndSaveToolStripMenuItem,
            this.impToolStripMenuItem,
            this.exportDataToolStripMenuItem,
            this.quitStatesVisitedToolStripMenuItem});
            this.statesToolStripMenuItem.Name = "statesToolStripMenuItem";
            this.statesToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.statesToolStripMenuItem.Text = "File";
            // 
            // addNewStateToolStripMenuItem
            // 
            this.addNewStateToolStripMenuItem.Name = "addNewStateToolStripMenuItem";
            this.addNewStateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewStateToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.addNewStateToolStripMenuItem.Text = "Add Visited State";
            this.addNewStateToolStripMenuItem.Click += new System.EventHandler(this.AddNewStateToolStripMenuItem_Click);
            // 
            // updateAndSaveToolStripMenuItem
            // 
            this.updateAndSaveToolStripMenuItem.Name = "updateAndSaveToolStripMenuItem";
            this.updateAndSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.updateAndSaveToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.updateAndSaveToolStripMenuItem.Text = "Update";
            this.updateAndSaveToolStripMenuItem.Click += new System.EventHandler(this.UpdateAndSaveToolStripMenuItem_Click);
            // 
            // impToolStripMenuItem
            // 
            this.impToolStripMenuItem.Name = "impToolStripMenuItem";
            this.impToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.impToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.impToolStripMenuItem.Text = "Import";
            this.impToolStripMenuItem.Click += new System.EventHandler(this.impToolStripMenuItem_Click);
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statesVisitedFileToolStripMenuItem,
            this.cSVToolStripMenuItem});
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exportDataToolStripMenuItem.Text = "Export As...";
            this.exportDataToolStripMenuItem.Click += new System.EventHandler(this.exportDataToolStripMenuItem_Click);
            // 
            // statesVisitedFileToolStripMenuItem
            // 
            this.statesVisitedFileToolStripMenuItem.Name = "statesVisitedFileToolStripMenuItem";
            this.statesVisitedFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.statesVisitedFileToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.statesVisitedFileToolStripMenuItem.Text = "StatesVisited File";
            this.statesVisitedFileToolStripMenuItem.Click += new System.EventHandler(this.statesVisitedFileToolStripMenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // quitStatesVisitedToolStripMenuItem
            // 
            this.quitStatesVisitedToolStripMenuItem.Name = "quitStatesVisitedToolStripMenuItem";
            this.quitStatesVisitedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitStatesVisitedToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.quitStatesVisitedToolStripMenuItem.Text = "Quit Application";
            this.quitStatesVisitedToolStripMenuItem.Click += new System.EventHandler(this.QuitStatesVisitedToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 186);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 368);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editYearToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // editYearToolStripMenuItem
            // 
            this.editYearToolStripMenuItem.Name = "editYearToolStripMenuItem";
            this.editYearToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.editYearToolStripMenuItem.Text = "Edit Year";
            this.editYearToolStripMenuItem.Click += new System.EventHandler(this.EditYearToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.deleteToolStripMenuItem.Text = "Remove";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "MyStates";
            this.openFileDialog1.Filter = "StatesVisited File (*.SVisit)|*.SVisit";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 566);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Visit_A_State);
            this.Controls.Add(this.State_Counter_DC);
            this.Controls.Add(this.Best_Year);
            this.Controls.Add(this.State_Counter);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "States Visited";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label State_Counter;
        private System.Windows.Forms.Label Best_Year;
        private System.Windows.Forms.Label State_Counter_DC;
        private System.Windows.Forms.Button Visit_A_State;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAndSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitStatesVisitedToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statesVisitedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
    }
}


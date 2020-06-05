namespace StatesVisited
{
    partial class AddState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddState));
            this.New_State = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Year_Selector = new System.Windows.Forms.NumericUpDown();
            this.Visit_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Year_Selector)).BeginInit();
            this.SuspendLayout();
            // 
            // New_State
            // 
            this.New_State.FormattingEnabled = true;
            this.New_State.Location = new System.Drawing.Point(15, 44);
            this.New_State.Name = "New_State";
            this.New_State.Size = new System.Drawing.Size(121, 21);
            this.New_State.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select A State";
            // 
            // Year_Selector
            // 
            this.Year_Selector.Location = new System.Drawing.Point(142, 44);
            this.Year_Selector.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Year_Selector.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.Year_Selector.Name = "Year_Selector";
            this.Year_Selector.Size = new System.Drawing.Size(120, 20);
            this.Year_Selector.TabIndex = 3;
            this.Year_Selector.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // Visit_Button
            // 
            this.Visit_Button.Location = new System.Drawing.Point(268, 44);
            this.Visit_Button.Name = "Visit_Button";
            this.Visit_Button.Size = new System.Drawing.Size(121, 21);
            this.Visit_Button.TabIndex = 4;
            this.Visit_Button.Text = "Visit State";
            this.Visit_Button.UseVisualStyleBackColor = true;
            this.Visit_Button.Click += new System.EventHandler(this.Visit_Button_Click);
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(15, 73);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(121, 21);
            this.Remove_Button.TabIndex = 5;
            this.Remove_Button.Text = "Remove State";
            this.Remove_Button.UseMnemonic = false;
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Visible = false;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "When Did You Visit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save and Close Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 118);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Visit_Button);
            this.Controls.Add(this.Year_Selector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.New_State);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddState";
            this.Text = "Add State";
            this.Load += new System.EventHandler(this.AddState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Year_Selector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox New_State;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Year_Selector;
        private System.Windows.Forms.Button Visit_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
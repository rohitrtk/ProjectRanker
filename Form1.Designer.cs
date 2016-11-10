namespace ProjectRanker
{
    partial class f_mainForm
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
            this.listBox_unselected = new System.Windows.Forms.ListBox();
            this.listBox_selected = new System.Windows.Forms.ListBox();
            this.l_currentVoter = new System.Windows.Forms.Label();
            this.t_currentVoter = new System.Windows.Forms.TextBox();
            this.b_removeVoter = new System.Windows.Forms.Button();
            this.menu_loadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.t_loadFile = new System.Windows.Forms.ToolStripTextBox();
            this.b_loadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.b_saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_createTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.b_createTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.rText_textBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_unselected
            // 
            this.listBox_unselected.FormattingEnabled = true;
            this.listBox_unselected.Location = new System.Drawing.Point(12, 81);
            this.listBox_unselected.Name = "listBox_unselected";
            this.listBox_unselected.Size = new System.Drawing.Size(202, 381);
            this.listBox_unselected.TabIndex = 1;
            this.listBox_unselected.SelectedIndexChanged += new System.EventHandler(this.listBox_unselected_SelectedIndexChanged);
            // 
            // listBox_selected
            // 
            this.listBox_selected.FormattingEnabled = true;
            this.listBox_selected.Location = new System.Drawing.Point(220, 81);
            this.listBox_selected.Name = "listBox_selected";
            this.listBox_selected.Size = new System.Drawing.Size(202, 381);
            this.listBox_selected.TabIndex = 2;
            this.listBox_selected.SelectedIndexChanged += new System.EventHandler(this.listBox_selected_SelectedIndexChanged);
            // 
            // l_currentVoter
            // 
            this.l_currentVoter.AutoSize = true;
            this.l_currentVoter.Location = new System.Drawing.Point(12, 44);
            this.l_currentVoter.Name = "l_currentVoter";
            this.l_currentVoter.Size = new System.Drawing.Size(69, 13);
            this.l_currentVoter.TabIndex = 3;
            this.l_currentVoter.Text = "Current Voter";
            // 
            // t_currentVoter
            // 
            this.t_currentVoter.Location = new System.Drawing.Point(82, 41);
            this.t_currentVoter.Name = "t_currentVoter";
            this.t_currentVoter.Size = new System.Drawing.Size(252, 20);
            this.t_currentVoter.TabIndex = 4;
            // 
            // b_removeVoter
            // 
            this.b_removeVoter.Location = new System.Drawing.Point(335, 41);
            this.b_removeVoter.Name = "b_removeVoter";
            this.b_removeVoter.Size = new System.Drawing.Size(87, 20);
            this.b_removeVoter.TabIndex = 5;
            this.b_removeVoter.Text = "Remove Voter";
            this.b_removeVoter.UseVisualStyleBackColor = true;
            this.b_removeVoter.Click += new System.EventHandler(this.b_removeVoter_Click);
            // 
            // menu_loadFile
            // 
            this.menu_loadFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t_loadFile,
            this.b_loadFile});
            this.menu_loadFile.Name = "menu_loadFile";
            this.menu_loadFile.Size = new System.Drawing.Size(66, 20);
            this.menu_loadFile.Text = "Load File";
            // 
            // t_loadFile
            // 
            this.t_loadFile.Name = "t_loadFile";
            this.t_loadFile.Size = new System.Drawing.Size(100, 23);
            // 
            // b_loadFile
            // 
            this.b_loadFile.Name = "b_loadFile";
            this.b_loadFile.Size = new System.Drawing.Size(164, 22);
            this.b_loadFile.Text = "Click to Load File";
            this.b_loadFile.Click += new System.EventHandler(this.b_loadFile_Click);
            // 
            // menu_saveFile
            // 
            this.menu_saveFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_saveFile});
            this.menu_saveFile.Name = "menu_saveFile";
            this.menu_saveFile.Size = new System.Drawing.Size(64, 20);
            this.menu_saveFile.Text = "Save File";
            // 
            // b_saveFile
            // 
            this.b_saveFile.Name = "b_saveFile";
            this.b_saveFile.Size = new System.Drawing.Size(162, 22);
            this.b_saveFile.Text = "Click to Save File";
            this.b_saveFile.Click += new System.EventHandler(this.b_saveFile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_loadFile,
            this.menu_saveFile,
            this.menu_createTeams});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_createTeams
            // 
            this.menu_createTeams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_createTeams});
            this.menu_createTeams.Name = "menu_createTeams";
            this.menu_createTeams.Size = new System.Drawing.Size(90, 20);
            this.menu_createTeams.Text = "Create Teams";
            // 
            // b_createTeams
            // 
            this.b_createTeams.Name = "b_createTeams";
            this.b_createTeams.Size = new System.Drawing.Size(108, 22);
            this.b_createTeams.Text = "Create";
            this.b_createTeams.Click += new System.EventHandler(this.b_createTeams_Click);
            // 
            // rText_textBox1
            // 
            this.rText_textBox1.Location = new System.Drawing.Point(428, 81);
            this.rText_textBox1.Name = "rText_textBox1";
            this.rText_textBox1.ReadOnly = true;
            this.rText_textBox1.Size = new System.Drawing.Size(316, 381);
            this.rText_textBox1.TabIndex = 6;
            this.rText_textBox1.Text = "Teams";
            // 
            // f_mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 472);
            this.Controls.Add(this.rText_textBox1);
            this.Controls.Add(this.b_removeVoter);
            this.Controls.Add(this.t_currentVoter);
            this.Controls.Add(this.l_currentVoter);
            this.Controls.Add(this.listBox_selected);
            this.Controls.Add(this.listBox_unselected);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f_mainForm";
            this.Text = "God Save Me";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_unselected;
        private System.Windows.Forms.ListBox listBox_selected;
        private System.Windows.Forms.Label l_currentVoter;
        private System.Windows.Forms.TextBox t_currentVoter;
        private System.Windows.Forms.Button b_removeVoter;
        private System.Windows.Forms.ToolStripMenuItem menu_loadFile;
        private System.Windows.Forms.ToolStripTextBox t_loadFile;
        private System.Windows.Forms.ToolStripMenuItem b_loadFile;
        private System.Windows.Forms.ToolStripMenuItem menu_saveFile;
        private System.Windows.Forms.ToolStripMenuItem b_saveFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_createTeams;
        private System.Windows.Forms.ToolStripMenuItem b_createTeams;
        private System.Windows.Forms.RichTextBox rText_textBox1;
    }
}


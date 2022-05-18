namespace WindowsFormsApp1
{
    partial class Team_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Team_Detail));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Years = new System.Windows.Forms.DomainUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Roster = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberonShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.college = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matchup = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchupTupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stastus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lineup = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Roster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Matchup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(58, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "NBA Managmen System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(354, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Team Detail";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(45, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 41);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(98, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Team Name | Division Name of Conference Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(-3, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(810, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "The currenl season is 2016-2017.and the NBA already has a history of 71 years";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(590, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 26);
            this.button2.TabIndex = 22;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(718, 36);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(70, 29);
            this.Back.TabIndex = 23;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Years
            // 
            this.Years.Location = new System.Drawing.Point(485, 118);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(85, 20);
            this.Years.TabIndex = 24;
            this.Years.Text = "2016 - 2017";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Roster);
            this.tabControl1.Controls.Add(this.Matchup);
            this.tabControl1.Controls.Add(this.Lineup);
            this.tabControl1.Location = new System.Drawing.Point(12, 145);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 278);
            this.tabControl1.TabIndex = 25;
            // 
            // Roster
            // 
            this.Roster.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Roster.Controls.Add(this.dataGridView1);
            this.Roster.Location = new System.Drawing.Point(4, 22);
            this.Roster.Name = "Roster";
            this.Roster.Padding = new System.Windows.Forms.Padding(3);
            this.Roster.Size = new System.Drawing.Size(768, 252);
            this.Roster.TabIndex = 0;
            this.Roster.Text = "Roster";
            this.Roster.Click += new System.EventHandler(this.Roster_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberonShort,
            this.playersName,
            this.position,
            this.dateOfBirth,
            this.college,
            this.experience,
            this.slary});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(762, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numberonShort
            // 
            this.numberonShort.HeaderText = "No.";
            this.numberonShort.Name = "numberonShort";
            this.numberonShort.Width = 50;
            // 
            // playersName
            // 
            this.playersName.HeaderText = "Name";
            this.playersName.Name = "playersName";
            this.playersName.Width = 150;
            // 
            // position
            // 
            this.position.HeaderText = "Position";
            this.position.Name = "position";
            this.position.Width = 80;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.HeaderText = "DateOfBirth";
            this.dateOfBirth.Name = "dateOfBirth";
            // 
            // college
            // 
            this.college.HeaderText = "College";
            this.college.Name = "college";
            this.college.Width = 130;
            // 
            // experience
            // 
            this.experience.HeaderText = "Experience";
            this.experience.Name = "experience";
            // 
            // slary
            // 
            this.slary.HeaderText = "Salary";
            this.slary.Name = "slary";
            this.slary.Width = 120;
            // 
            // Matchup
            // 
            this.Matchup.Controls.Add(this.dataGridView2);
            this.Matchup.Location = new System.Drawing.Point(4, 22);
            this.Matchup.Name = "Matchup";
            this.Matchup.Padding = new System.Windows.Forms.Padding(3);
            this.Matchup.Size = new System.Drawing.Size(768, 252);
            this.Matchup.TabIndex = 1;
            this.Matchup.Text = "Matchup";
            this.Matchup.UseVisualStyleBackColor = true;
            this.Matchup.Click += new System.EventHandler(this.Matchup_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.matchupTupe,
            this.opponent,
            this.startTime,
            this.result,
            this.location,
            this.stastus});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(762, 226);
            this.dataGridView2.TabIndex = 1;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 80;
            // 
            // matchupTupe
            // 
            this.matchupTupe.HeaderText = "Matchup Tupe";
            this.matchupTupe.Name = "matchupTupe";
            this.matchupTupe.Width = 130;
            // 
            // opponent
            // 
            this.opponent.HeaderText = "Opponent";
            this.opponent.Name = "opponent";
            this.opponent.Width = 130;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "Start Time";
            this.startTime.Name = "startTime";
            this.startTime.Width = 90;
            // 
            // result
            // 
            this.result.HeaderText = "Result";
            this.result.Name = "result";
            this.result.Width = 90;
            // 
            // location
            // 
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            this.location.Width = 90;
            // 
            // stastus
            // 
            this.stastus.HeaderText = "Status";
            this.stastus.Name = "stastus";
            this.stastus.Width = 90;
            // 
            // Lineup
            // 
            this.Lineup.Location = new System.Drawing.Point(4, 22);
            this.Lineup.Name = "Lineup";
            this.Lineup.Size = new System.Drawing.Size(768, 252);
            this.Lineup.TabIndex = 2;
            this.Lineup.Text = "Lineup";
            this.Lineup.UseVisualStyleBackColor = true;
            this.Lineup.Click += new System.EventHandler(this.Lineup_Click);
            // 
            // Team_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Years);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Team_Detail";
            this.Text = "Team_Detail";
            this.Load += new System.EventHandler(this.Team_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Roster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Matchup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DomainUpDown Years;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Roster;
        private System.Windows.Forms.TabPage Matchup;
        private System.Windows.Forms.TabPage Lineup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberonShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn college;
        private System.Windows.Forms.DataGridViewTextBoxColumn experience;
        private System.Windows.Forms.DataGridViewTextBoxColumn slary;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchupTupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn opponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn stastus;
    }
}
namespace WindowsFormsApp1
{
    partial class Visitor_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visitor_Menu));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Visitor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Matchups = new System.Windows.Forms.Button();
            this.Photos = new System.Windows.Forms.Button();
            this.Players = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(126, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(126, 431);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(677, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "The currenl season is 2016-2017.and the NBA already has a history of 71 years";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(393, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Visitor Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(178, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "NBA Managmen System";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Visitor
            // 
            this.Visitor.BackColor = System.Drawing.SystemColors.Highlight;
            this.Visitor.Cursor = System.Windows.Forms.Cursors.Default;
            this.Visitor.FlatAppearance.BorderSize = 0;
            this.Visitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visitor.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Visitor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Visitor.Location = new System.Drawing.Point(128, 45);
            this.Visitor.Name = "Visitor";
            this.Visitor.Size = new System.Drawing.Size(152, 65);
            this.Visitor.TabIndex = 1;
            this.Visitor.Text = "Teams";
            this.Visitor.UseVisualStyleBackColor = false;
            this.Visitor.Click += new System.EventHandler(this.Visitor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Matchups);
            this.groupBox1.Controls.Add(this.Photos);
            this.groupBox1.Controls.Add(this.Players);
            this.groupBox1.Controls.Add(this.Visitor);
            this.groupBox1.Location = new System.Drawing.Point(151, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 260);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Matchups
            // 
            this.Matchups.BackColor = System.Drawing.SystemColors.Highlight;
            this.Matchups.Cursor = System.Windows.Forms.Cursors.Default;
            this.Matchups.FlatAppearance.BorderSize = 0;
            this.Matchups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Matchups.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Matchups.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Matchups.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Matchups.Location = new System.Drawing.Point(128, 155);
            this.Matchups.Name = "Matchups";
            this.Matchups.Size = new System.Drawing.Size(152, 65);
            this.Matchups.TabIndex = 5;
            this.Matchups.Text = "Matchups";
            this.Matchups.UseVisualStyleBackColor = false;
            this.Matchups.Click += new System.EventHandler(this.Matchups_Click);
            // 
            // Photos
            // 
            this.Photos.BackColor = System.Drawing.SystemColors.Highlight;
            this.Photos.Cursor = System.Windows.Forms.Cursors.Default;
            this.Photos.FlatAppearance.BorderSize = 0;
            this.Photos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Photos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Photos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Photos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Photos.Location = new System.Drawing.Point(359, 155);
            this.Photos.Name = "Photos";
            this.Photos.Size = new System.Drawing.Size(152, 65);
            this.Photos.TabIndex = 4;
            this.Photos.Text = "Photos";
            this.Photos.UseVisualStyleBackColor = false;
            this.Photos.Click += new System.EventHandler(this.Photos_Click);
            // 
            // Players
            // 
            this.Players.BackColor = System.Drawing.SystemColors.Highlight;
            this.Players.Cursor = System.Windows.Forms.Cursors.Default;
            this.Players.FlatAppearance.BorderSize = 0;
            this.Players.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Players.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Players.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Players.Location = new System.Drawing.Point(359, 45);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(152, 65);
            this.Players.TabIndex = 2;
            this.Players.Text = "Players";
            this.Players.UseVisualStyleBackColor = false;
            this.Players.Click += new System.EventHandler(this.Players_Click_1);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(703, 37);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(70, 29);
            this.Back.TabIndex = 15;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Visitor_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitter1);
            this.Name = "Visitor_Menu";
            this.Text = "Visitor_Menu";
            this.Load += new System.EventHandler(this.Visitor_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Visitor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Players;
        private System.Windows.Forms.Button Photos;
        private System.Windows.Forms.Button Matchups;
        private System.Windows.Forms.Button Back;
    }
}
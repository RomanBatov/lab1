using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal partial class TeamsMain : Form
    {
        Team[] teams = new Team[5];
        internal TeamsMain()
        {
            InitializeComponent();
            
            this.teams[0] = new Team();
            this.teams[0].setAll(1, "Miami Heat", "MIA", "1.jpg");
            this.teams[1] = new Team();
            this.teams[1].setAll(2, "Orlando Magic", "ORL", "2.jpg");
            this.teams[2] = new Team();
            this.teams[2].setAll(3, "Atlanta Hawks", "ATL", "3.jpg");
            this.teams[3] = new Team();
            this.teams[3].setAll(4, "Washington Wizards", "WSH", "4.jpg");
            this.teams[4] = new Team();
            this.teams[4].setAll(5, "Charlotte Hornets", "CHA", "5.jpg");
            var label = tn1;
            this.pn1.Controls["tn1"].Text = teams[0].name;




            for (int i = 0; i < 5; i++)
            {

                tabPage1.Controls["panel4"].Controls["pn1"].Controls["tn1"+(1+i)].Text = teams[i].name;
            }
                


        }

        private void TeamsMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {
            Form TeamsMain = new TeamsDetails();
            TeamsMain.Show();
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void label62_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}

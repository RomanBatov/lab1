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
   partial class Teams_Main : Form
    {
       public static Team[] teams = new Team[5];
         public String[] imgList = new String[]
                                          {"1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg", "11.jpg", "12.jpg",
                                          "13.jpg","14.jpg","15.jpg","16.jpg","17.jpg","18.jpg","19.jpg","20.jpg","21.jpg","22.jpg","23.jpg","24.jpg","25.jpg",
                                          "26.jpg","27.jpg","28.jpg","29.jpg","30.jpg"};

       
        
        void PictureFilling()
        {
            List<PictureBox> allTeamsList = new List<PictureBox>();

            allTeamsList.AddRange(new PictureBox[] { logo1, logo2, logo3, logo4, logo5, logo6, logo7, logo8, logo9, logo10, logo11, logo12, logo13, logo14, logo15, logo16, logo17, logo18, logo19, logo20, logo21, logo22, logo23, logo24, logo25, logo26, logo27, logo28, logo29, logo30 });
            for (int i = 0; i < 30; i++)
            {
                allTeamsList[i].Load("../../Teams/" + imgList[i]);
            }
        }
        public Teams_Main()
        {
            teams[0] = new Team();
            teams[0].setAll(1, "Miami Heat", "MIA", "1.jpg");
            teams[1] = new Team();
            teams[1].setAll(2, "Orlando Magic", "ORL", "2.jpg");
            teams[2] = new Team();
            teams[2].setAll(3, "Atlanta Hawks", "ATL", "3.jpg");
            teams[3] = new Team();
            teams[3].setAll(4, "Washington Wizards", "WSH", "4.jpg");
            teams[4] = new Team();
            teams[4].setAll(5, "Charlotte Hornets", "CHA", "5.jpg");


            InitializeComponent();
            PictureFilling();
            for (int i = 0; i < 5; i++)
            {
                Eastern.Controls["mainPanel1"].Controls["panel" + (i + 1)].Controls["tn" + (i + 1)].Text = teams[i].name; 
            }
  

        }
        private void Western_Click(object sender, EventArgs e)
        {

        }

        private void Eastern_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Teams_Main_Load(object sender, EventArgs e)
        {
         
        }

        private void roster1_Click(object sender, EventArgs e)
        {
            Form roster1 = new Team_Detail();
            roster1.Show();
        }
        private void tn1_Click(object sender, EventArgs e)
        {
            Team_Detail td = new Team_Detail();
            td.teamId = 1;
            td.Show();
        }
        private void tn2_Click(object sender, EventArgs e)
        {
            Team_Detail td = new Team_Detail();
            td.teamId = 2;
            td.Show();
        }

        private void tn3_Click(object sender, EventArgs e)
        {
            Team_Detail td = new Team_Detail();
            td.teamId = 3;
            td.Show();
        }

        private void tn4_Click(object sender, EventArgs e)
        {
            Team_Detail td = new Team_Detail();
            td.teamId =4;
            td.Show();
        }

        private void tn5_Click(object sender, EventArgs e)
        {
            Team_Detail td = new Team_Detail();
            td.teamId = 5;
            td.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

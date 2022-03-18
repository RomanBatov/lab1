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
    public partial class MainForm : Form
    { //imgList
        Country[] countries = new Country[5];
        


        String[] imgList = new String[]
                           {"1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg","6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg"};
            int index = 0;
        public MainForm()
        {
            InitializeComponent();
            pictureBox1.Load("../../Img/" + imgList[0]) ;
            pictureBox2.Load("../../Img/" + imgList[1]) ;
            pictureBox3.Load("../../Img/" + imgList[2]) ;


            Country country = new Country();
            country.setCountryCode("ARG");
            country.setCountryName("Argentina");
            countries[0] = country;

           
            country.setCountryCode("AT");
            country.setCountryName("Austria");
            countries[1] = country;

          
            country.setCountryCode("AUS");
            country.setCountryName("Australia");
            countries[2] = country;

            
            country.setCountryCode("BI");
            country.setCountryName("Bosnia");
            countries[3] = country;

            
            country.setCountryCode("BIH");
            country.setCountryName("Bosnia Herxegovina");
            countries[4] = country;

            Player player = new Player();
            player.setAll(1, "Mo", "Williams", "female", 1.85f ,  89.8f, "1", "test@test", "US", 1) ;
            player.setAll(2, "Alonzo", "Edward Gee", "male",1.98f,99f,"2", "test@test", "US", 2);
            player.setAll(3, "Johnny", "O'Bryant", "male", 2.05f, 116.5f, "3", "test@test", "US", 3);
            player.setAll(4, "Danilo", "Gallinari", "female", 2.08f, 102f, "4", "test@test", "US", 4);
            player.setAll(5, "Darrel", "Arthur", "male", 2.06f, 107f, "5", "test@test", "US", 5);
            Team team = new Team();
            team.setAll(1, "Miami Heat", "MIA", "1.jpg");
            team.setAll(2, "Orlando Magic", "ORL", "2.jpg");
            team.setAll(3, "Atlanta Hawks", "ATL", "3.jpg");
            team.setAll(4, "Washington Wizards", "WSH", "4.jpg");
            team.setAll(5, "Charlotte Hornets", "CHA", "5.jpg");

            PositionName positionName = new PositionName();
            positionName.setAll(1, "SmallForward");
            positionName.setAll(2, "PowerForward");
            positionName.setAll(3, "Center");
            positionName.setAll(4, "ShootingGuard");
            positionName.setAll(5, "PointGuard");
            PositionOfPlayer positionOfPlayer = new PositionOfPlayer();
            positionOfPlayer.setAll(1,3);
            positionOfPlayer.setAll(2,4);
            positionOfPlayer.setAll(3,5);
            positionOfPlayer.setAll(4,1);
            positionOfPlayer.setAll(5,2);


        }
    
    

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form adminForm = new VisitorForm();
                adminForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form MainForm = new VisitorForm();
            MainForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            index = index - 1;
            if (index - 3 < 0) index = imgList.Length-3;
            pictureBox1.Load("../../Img/" + imgList[index + 0]);
            pictureBox2.Load("../../Img/" + imgList[index + 1]);
            pictureBox3.Load("../../Img/" + imgList[index + 2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index+3 >imgList.Length) index= 0;
            pictureBox1.Load("../../Img/" + imgList[index + 0]);
            pictureBox2.Load("../../Img/" + imgList[index + 1]);
            pictureBox3.Load("../../Img/" + imgList[index + 2]);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

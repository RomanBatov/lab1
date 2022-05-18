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
    public partial class Form1 : Form
    {
        String[] imgList = new String[]
                                          {"1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg", "11.jpg","12.jpg","13.jpg",
                                           "14.jpg","15.jpg","16.jpg","18.jpg"};
         int index = 0;
        Country[] countries = new Country[5];
       public static Player[] players = new Player[5];
        PositionName[] positionNames = new PositionName[5];
        PositionOfPlayer[] positionOfPlayers = new PositionOfPlayer [5];



        public Form1()
        {
            InitializeComponent();
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
            country.setCountryName("Bosnia Herzegovina");
            countries[4] = country;

            players[0] = new Player();
            players[0].setAll(1,"Williams","Mo","male",1.85f,89.8f,"1","wiliams@gmail.com","Us",1);
            players[1] = new Player();
            players[1].setAll(2,"Edward Gee", "Alonzo", "male", 1.98f, 99f, "2", "edward@gmail.com", "Us", 2);
            players[2] = new Player();
            players[2].setAll(3,"O'Bryant","Johnny","male",2.05f,116f,"3","brayn@gmail.com","Us",3);
            players[3] = new Player();
            players[3].setAll(4, "Gallinari", "Danilo","male",2.08f,102f,"4","gallinari@gmail.com","Us",4);
            players[4] = new Player();
            players[4].setAll(5,"Arthur", "Darrell","male",2.06f,107f,"5","arthur@gmail.com","Us",5);

            PositionName positionName = new PositionName();
            positionName.setAll(1, "SmallForward");
            positionName.setAll(2, "PowerForward");
            positionName.setAll(3, "Center");
            positionName.setAll(4, "ShootingGuard");
            positionName.setAll(5, "PointGuard");

            PositionOfPlayer positionOfPlayer = new PositionOfPlayer();
            positionOfPlayer.setAll(1, 1);
            positionOfPlayer.setAll(2, 2);
            positionOfPlayer.setAll(3, 3);
            positionOfPlayer.setAll(4, 4);
            positionOfPlayer.setAll(5, 5);


            pictureBox1.Load("../../pictures/" + imgList[0]);
            pictureBox2.Load("../../pictures/" + imgList[1]);
            pictureBox3.Load("../../pictures/" + imgList[2]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Adminform = new Visitor_Menu();
            Adminform.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Left_Click(object sender, EventArgs e)
        {
            index = index - 1;
            if (index-3 <0) index = imgList.Length -3;
            pictureBox1.Load("../../pictures/" + imgList[index + 0]);
            pictureBox2.Load("../../pictures/" + imgList[index + 1]);
            pictureBox3.Load("../../pictures/" + imgList[index + 2]);
        }

        private void Right_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index+3 > imgList.Length) index = 0;
            pictureBox1.Load("../../pictures/" + imgList[index + 0]);
            pictureBox2.Load("../../pictures/" + imgList[index + 1]);
            pictureBox3.Load("../../pictures/" + imgList[index + 2]);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

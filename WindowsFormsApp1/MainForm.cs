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
    {
        String[] imgList = new String[]
                           {"1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg","6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg"};
            int index = 0;
        public MainForm()
        {
            InitializeComponent();
            pictureBox1.Load("../../Img/" + imgList[0]) ;
            pictureBox2.Load("../../Img/" + imgList[1]) ;
            pictureBox3.Load("../../Img/" + imgList[2]) ;
            
        
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
            if (index + 3 < imgList.Length) index = 0;
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
    }
}

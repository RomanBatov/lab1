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
    public partial class Team_Detail : Form
    { 
        public int teamId;
        Team tm = new Team();
        public Team_Detail()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Matchup_Click(object sender, EventArgs e)
        {

        }

        private void Lineup_Click(object sender, EventArgs e)
        {

        }

        private void Roster_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Team_Detail_Load(object sender, EventArgs e)
        {
              for (int i = 0; i < Teams_Main.teams.Length; i++)
                if (Teams_Main.teams[i].teamId == this.teamId)
                    this.tm = Teams_Main.teams[i];

            label3.Text = this.tm.name;

            for (int i = 0; i < Form1.players.Length; i++)
                if (Form1.players[i].teamId == this.teamId)
                    dataGridView1.Rows.Add(Form1.players[i].playerId, Form1.players[i].firstName);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

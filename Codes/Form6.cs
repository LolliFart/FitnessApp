using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            kneeToChessStretchLeft sl = new kneeToChessStretchLeft();
            sl.Show();
            panel4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            kneeToChestStretchRight sr = new kneeToChestStretchRight();
            sr.Show();
            panel5.Visible = true;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            donkeyKicksLeft df = new donkeyKicksLeft();
            df.Show();
            panel6.Visible = true;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            donkeyKicksRight dr = new donkeyKicksRight();
            dr.Show();
            panel7.Visible = true;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            leftSquadStretchWall sq = new leftSquadStretchWall();
            sq.Show();
            panel8.Visible = true;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            rightSquadStretchWithWall rq = new rightSquadStretchWithWall();
            rq.Show();
            button1.Visible = true;
        }
    }
}

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
    public partial class Form11 : Form
    {
        public Form11()
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
            donkeyKicksLeft dl = new donkeyKicksLeft();
            dl.Show();
            panel4.Visible = true;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            donkeyKicksRight dr = new donkeyKicksRight();
            dr.Show();
            panel5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            this.Hide();
            f12.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            kneeToChessStretchLeft kl = new kneeToChessStretchLeft();
            kl.Show();
            panel6.Visible = true;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            kneeToChestStretchRight kr = new kneeToChestStretchRight();
            kr.Show();
            panel7.Visible = true;

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            leftSquadStretchWall lw = new leftSquadStretchWall();
            lw.Show();
            panel8.Visible = true;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            rightSquadStretchWithWall rw = new rightSquadStretchWithWall();
            rw.Show();
            button1.Visible = true;
        }
    }
}

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
    public partial class Form14 : Form
    {
        public Form14()
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
            backwardLunge bl = new backwardLunge();
            bl.Show();
            panel4.Visible = true;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            inAndOuts io = new inAndOuts();
            io.Show();
            panel5.Visible = true;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            JumpingJack jj = new JumpingJack();
            jj.Show();
            panel6.Visible = true;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            backwardLunge bl = new backwardLunge();
            bl.Show();
            panel7.Visible = true;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            inAndOuts io = new inAndOuts();
            io.Show();
            panel8.Visible = true;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            JumpingJack jj = new JumpingJack();
            jj.Show();
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }
    }
}

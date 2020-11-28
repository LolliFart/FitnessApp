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
    public partial class Form13 : Form
    {
        public Form13()
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
            TricepsDips td = new TricepsDips();
            td.Show();
            panel4.Visible = true;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Squat s = new Squat();
            s.Show();
            panel5.Visible = true;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            mountainClimber mc = new mountainClimber();
            mc.Show();
            panel6.Visible = true;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            TricepsDips td = new TricepsDips();
            td.Show();
            panel7.Visible = true;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Squat s = new Squat();
            s.Show();
            panel8.Visible = true;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            mountainClimber mc = new mountainClimber();
            mc.Show();
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
        }
    }
}

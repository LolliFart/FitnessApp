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
    public partial class Form17 : Form
    {
        public Form17()
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
            sideLyingLegLiftLeft sl = new sideLyingLegLiftLeft();
            sl.Show();
            panel4.Visible = true;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            sideLyingLegLiftRight sr = new sideLyingLegLiftRight();
            sr.Show();
            panel5.Visible = true;

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Squat s = new Squat();
            s.Show();
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
            russianTwist rt = new russianTwist();
            rt.Show();
            panel8.Visible = true;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            sitUpTwist st = new sitUpTwist();
            st.Show();
            button1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            finish f = new finish();
            f.Show();
            this.Hide();
        }
    }
}

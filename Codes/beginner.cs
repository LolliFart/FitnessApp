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
    public partial class beginner : Form
    {
        public beginner()
        {
            InitializeComponent();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            sideLyingLegLiftLeft sl = new sideLyingLegLiftLeft();
            sl.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            sideLyingLegLiftRight sr = new sideLyingLegLiftRight();
            sr.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Squat s = new Squat();
            s.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            childsPose cp = new childsPose();
            cp.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            russianTwist rt = new russianTwist();
            rt.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            sitUpTwist st = new sitUpTwist();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success!");
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
    }
}

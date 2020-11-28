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
    public partial class Form12 : Form
    {
        public Form12()
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
            sitUpTwist st = new sitUpTwist();
            st.Show();
            panel4.Visible = true;

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            SupinePushUp spu = new SupinePushUp();
            spu.Show();
            panel5.Visible = true;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            sitUpTwist st = new sitUpTwist();
            st.Show();
            panel6.Visible = true;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            inAndOuts iao = new inAndOuts();
            iao.Show();
            panel7.Visible = true;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            sideLyingLegLiftLeft sl = new sideLyingLegLiftLeft();
            sl.Show();
            panel8.Visible = true;

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            sideLyingLegLiftRight sr = new sideLyingLegLiftRight();
            sr.Show();
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }
    }
}

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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            SupinePushUp spu = new SupinePushUp();
            spu.Show();
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
            sideLyingLegLiftLeft sl = new sideLyingLegLiftLeft();
            sl.Show();
            panel6.Visible = true;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            sitUpTwist sut = new sitUpTwist();
            sut.Show();
            panel7.Visible = true;

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            TricepsDips td = new TricepsDips();
            td.Show();
            panel8.Visible = true;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            wideArmPushUp wapu = new wideArmPushUp();
            wapu.Show();
            button1.Visible = true;
            
        }
    }
}

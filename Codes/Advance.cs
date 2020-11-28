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
    public partial class Advance : Form
    {
        public Advance()
        {
            InitializeComponent();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            SupinePushUp spu = new SupinePushUp();
            spu.Show();

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            pushUp pu = new pushUp();
            pu.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            wideArmPushUp wapu = new wideArmPushUp();
            wapu.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            russianTwist rt = new russianTwist();
            rt.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            sitUpTwist sut = new sitUpTwist();
            sut.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            TricepsDips td = new TricepsDips();
            td.Show();
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

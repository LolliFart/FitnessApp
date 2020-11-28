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
    public partial class Intermidiate : Form
    {
        public Intermidiate()
        {
            InitializeComponent();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            JumpingJack jj = new JumpingJack();
            jj.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            plieSquats ps = new plieSquats();
            ps.Show();
        }

        private void panel5_DoubleClick(object sender, EventArgs e)
        {
            Squat s = new Squat();
            s.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            mountainClimber mc = new mountainClimber();
            mc.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            InclinePushUp ipu = new InclinePushUp();
            ipu.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            pushUp pu = new pushUp();
            pu.Show();
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

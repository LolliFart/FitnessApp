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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            beginner b = new beginner();
            this.Hide();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Intermidiate i = new Intermidiate();
            i.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Advance a = new Advance();
            a.Show();
            this.Hide();
        }
    }
}

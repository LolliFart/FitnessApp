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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            lbl2.Visible = false;
            lbl3.Visible = false;  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lbl2.Visible = true;
            lbl3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = true;
        }
    }
}

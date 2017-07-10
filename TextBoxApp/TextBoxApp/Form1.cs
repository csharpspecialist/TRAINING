using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxApp
{
    public partial class DUDE : Form
    {


        string none = "play";
        public DUDE()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show("Hello Party People");
            string words = txtBox1.Text;
            lbl1.Text = words;

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YES!!!!");
            string words = txtBox1.Text;
            lbl2.Text = words;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string four = txtBox4.Text;

            lbl4.Text = four;
        }
    }
}

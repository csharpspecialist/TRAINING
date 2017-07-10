using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormsAppForm2FormTBoxLbl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string words = tBox1.Text;

            lblShow.Text = words;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayForm ds = new DisplayForm();

            ds.Show();
        }
    }
}

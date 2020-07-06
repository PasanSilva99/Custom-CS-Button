using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Round_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked ! ");
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

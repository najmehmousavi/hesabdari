using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesabdari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer i = new customer();
            i.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            product m = new product();
            m.Show();
        }
    }
}

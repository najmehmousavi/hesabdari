﻿using System;
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
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }

        private void product_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string model = textBox1.Text;
            string color = textBox2.Text;
            int memory = int.Parse(textBox3.Text);
            int price = int.Parse(textBox4.Text);
            MessageBox.Show(model,color);

            MessageBox.Show((memory.ToString()), (price.ToString()));
            product_list g = new product_list();
        }
    }
}

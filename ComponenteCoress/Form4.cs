﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponenteCoress
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == "Ciano")
            {
                this.BackColor = Color.Cyan;
            }
            else if (listBox1.SelectedItem == "Verde")
            { 
                this.BackColor = Color.Green;
            }
            else if (listBox1.SelectedItem == "Vermelho")
            {
                this.BackColor = Color.Red;
            }
            else if (listBox1.SelectedItem == "Laranja")
            {
                this.BackColor = Color.Orange;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}

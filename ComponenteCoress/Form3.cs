using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponenteCoress
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
            checkBox1.ForeColor = Color.Red;

            if (checkBox1.Checked == false)
            {
                panel1.BackColor = Color.WhiteSmoke;
                checkBox1.ForeColor = Color.Black;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Red;
            checkBox4.ForeColor = Color.White;

            if (checkBox4.Checked == false)
            {
                panel4.BackColor = Color.WhiteSmoke;
                checkBox4.ForeColor = Color.Black;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Cyan;
            checkBox2.ForeColor = Color.Yellow;

            if (checkBox2.Checked == false)
            {
                panel2.BackColor = Color.WhiteSmoke;
                checkBox2.ForeColor = Color.Black;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Orange;
            checkBox3.ForeColor = Color.Blue;

            if (checkBox3.Checked == false)
            {
                panel3.BackColor = Color.WhiteSmoke;
                checkBox3.ForeColor = Color.Black;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
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

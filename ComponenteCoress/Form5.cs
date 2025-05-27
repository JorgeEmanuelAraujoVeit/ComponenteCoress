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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Ciano")
            {
                this.BackColor = Color.Cyan;
            }
            else if (comboBox1.SelectedItem == "Verde")
            {
                this.BackColor = Color.Green;
            }
            else if (comboBox1.SelectedItem == "Vermelho")
            {
                this.BackColor = Color.Red;
            }
            else if (comboBox1.SelectedItem == "Laranja")
            {
                this.BackColor = Color.Orange;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}

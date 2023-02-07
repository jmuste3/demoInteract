using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoInteractiva
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "JAUME" & textBox2.Text == "PASSWORD") { 
                
                MessageBox.Show ("WELCOME");
                //OBRIR NOU FORMULARI PASSANT DADES
                string value = textBox1.Text;
                Form4 form4 = new Form4(value);
                form4.Show();
                //opcional: per tancar form1:
                this.Hide(); //closes the first form

            }
            else
            {
                MessageBox.Show("WRONG DATA");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

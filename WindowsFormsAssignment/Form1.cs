using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 77;
          int y= int.Parse(textBox1.Text);
          if (y == 77)
            {
                BackColor = Color.GreenYellow;
                textBox1.Hide();
                button1.Hide();
                MessageBox.Show("THIS NUMBER IS CORRECT ");
              
            }
          
          else
            if ((y >85) || (y <60) )
            {
                BackColor = Color.Blue;
                MessageBox.Show("THIS NUMBER IS FAR ");
                textBox1.Clear();
            }

            else
            if (y >61 || y<84)
            {
                BackColor = Color.Red;
                MessageBox.Show("THIS NUMBER IS CLOSE ");
                textBox1.Clear();
            }
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            f1.Location = this.Location;
            f1.Size = this.Size;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

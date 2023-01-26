using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viktorina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class Globals
        {
            public static string name1;
            public static string name2;
            public static string name3;
            public static string name4;
        }
        //static string qwerty1 = " sth else1";
        //static string qwerty2 = " sth else2";
        //static string qwerty3 = " sth else3";
        //static string qwerty4 = " sth else4"; 

        string[] a =
        {
            Globals.name1,
            Globals.name2,
            Globals.name3,
            Globals.name4
        };

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
 
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.name1 = textBox1.Text;
            label1.Text = Globals.name1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.name2 = textBox2.Text;
            label2.Text = Globals.name2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Globals.name3 = textBox3.Text;
            label3.Text = Globals.name3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Globals.name4 = textBox4.Text;
            label4.Text = Globals.name4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
     
            label5.Text = Globals.name1;
            label7.Text = Globals.name2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            label5.Text = Globals.name2;
            label7.Text = Globals.name1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            label6.Text = Globals.name3;
            label8.Text = Globals.name4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            label6.Text = Globals.name4;
            label8.Text = Globals.name3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label9.Text = label7.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label9.Text = label8.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label12.Text = label5.Text;
            label10.Text = label6.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label12.Text = label6.Text;
            label10.Text = label5.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label11.Text = label10.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label11.Text = label9.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label12.Text + " победитель группы А");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label11.Text + " победитель группы А");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //random proverka
            Random rand = new Random(4);
            int kubik = rand.Next(0, 3);

        }
    }
}

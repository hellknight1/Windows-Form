using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                a[i] = Convert.ToInt32(textBox1.Text);
                if (i < 10)
                {
                    MessageBox.Show("Įvedėte " + a[i] + Environment.NewLine + "Įveskite dar " + (10 - i) + " skaičius");
                }
                else
                {
                    MessageBox.Show("Įvedėte " + a[i] + Environment.NewLine + "Įvedėte 10 skaičių, kita kartą paspaudus skaičiuoti bus išvestas rezultatas");
                }
                i++;
            }
            else
            {
                int temp = 0, x=0;
                while(temp<10)
                {
                    x = x + a[temp];
                    temp++;
                }
                MessageBox.Show(Convert.ToString(x));
            }

        }
        public static int[] a = new int[10];
        public static int i = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            int l = 0, temp = 0;
            string egle="";
            l = Convert.ToInt32(textBox2.Text);
            while(temp < l)
            {
                temp++;
                int temp1 = 0;
                while (temp1 < temp)
                {
                    egle = egle + " * ";
                    temp1++;
                }
                egle = egle + Environment.NewLine;
            }
            egle = egle + " *** " + Environment.NewLine + " *** " + Environment.NewLine + " *** " + Environment.NewLine;
            // Creating and setting the 
            // properties of the RichTextBox 
            RichTextBox box = new RichTextBox();
            box.Size = new Size(362, 398);
            box.Location = new Point(28, 251);
            box.BackColor = Color.White;
            box.SelectionAlignment = HorizontalAlignment.Center;
            box.Text = egle;

            // Adding this RichTextBox in the form 
            this.Controls.Add(box);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

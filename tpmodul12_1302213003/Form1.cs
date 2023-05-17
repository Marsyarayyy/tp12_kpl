using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul12_1302213003
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                int input = int.Parse(textBox1.Text);
                String a = Tanda.CariTandaBilangan(input);
                if (input == 0)
                {
                    label1.Text = a;
                }
                else
                {
                    label1.Text = a + " " + Math.Pow(input, input);
                }
            }catch (Exception ex)
            {
                label1.Text = "Input Angka";
            }
           
        }
        
    }
}

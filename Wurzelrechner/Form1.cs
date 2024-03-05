using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wurzelrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double genauigkeit = Convert.ToDouble(textBox2.Text);
            double y = wurzler(x, genauigkeit);
            textBox3.Text = y.ToString();
            textBox4.Text = "Echtes Ergebnis: " + Convert.ToString(Math.Sqrt(x));
        }

        private double wurzler(double x, double genauigkeit)
        {
            double y = 0;
            double delta = x;
            double fehler = 100;

            do
            {
                if (x < y * y)
                {
                    y -= delta;
                }
                else
                {
                    y += delta;
                }

                delta = delta / 2;
                fehler = (x - y * y) * 100;
            }
            while ((fehler > genauigkeit) || (fehler < -genauigkeit));

            return y;
        }


    }
}

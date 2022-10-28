using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_05_01_Exponents_NGM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal decNumVal = numericUpDown1.Value;
            int numVal = Convert.ToInt32(decNumVal);

            int squared = Square(numVal);
            int cubed = Cube(numVal);

            string squaredVal = squared.ToString();
            string cubedVal = cubed.ToString();

            label3.Visible = true;
            label4.Visible = true;

            label3.Text = squaredVal;
            label4.Text = cubedVal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            numericUpDown1.Value = 0;
        }

        public int Square(int num)
        {
            int squareVal = num * num;
            return squareVal;
        }

        public int Cube(int num)
        {
            int cubeVal = num * num * num;
            return cubeVal;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

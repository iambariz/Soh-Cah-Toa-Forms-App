using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soh_Cah_Toa_Forms_App
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputField.Text = "Welcome to my program! \r\nThis program calculates the side of right angle triangle and the Sin Cos and Tan";
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {



        }
        //Some test below
        //           double result = calcHyp(Double.Parse(inputA.Text), Double.Parse(inputB.Text));
        //            inputC.Text = result.ToString();
        //Calculations below

        public double calcHyp(double sideOne, double sideTwo)
        {
            return Math.Round(Math.Sqrt(Math.Pow(sideOne, 2) + Math.Pow(sideTwo, 2)), 2);
        }

        public double calcSide(double side, double hyp)
        {
            return Math.Round(Math.Sqrt(Math.Pow(hyp, 2) - Math.Pow(side, 2)), 2);
        }

        public double calcSine(double opp, double hyp)
        {

            return Math.Round(Math.Sin(opp / hyp), 2);
        }

        public double calcCos(double adj, double hyp)
        {
            return Math.Round(Math.Cos(adj / hyp), 2);
        }
        
        public double calcTan(double opp, double adj)
        {
            return Math.Round(Math.Tan(opp / adj), 2);
        }

        private void inputC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void inputB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void inputA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void xAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void yAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}

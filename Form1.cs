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

        public double calcHyp(double sideA, double sideB)
        {
            return Math.Round(, 2);
        }
    }
}

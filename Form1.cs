﻿using System;
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

        public void calculateBtn_Click(object sender, EventArgs e)
        {
            double yAng = Double.Parse(yAngle.Text);
            double xAng = Double.Parse(xAngle.Text);
            double Aside = Double.Parse(inputA.Text);
            double Bside = Double.Parse(inputB.Text);
            double Cside = Double.Parse(inputC.Text);
            double zAng = 90;
            double[] sides = new double[] { Aside, Bside, Cside };
            double[] legs = new double[] { Aside, Bside };
            bool AsideValid = false;
            bool BsideValid = false;
            bool CsideValid = false;

            bool[] sidesValid = new bool[] { AsideValid, BsideValid, CsideValid };


            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] > 0)
                {
                    sidesValid[i] = true;
                }
            }


            //sidesValid[0] = A, sidesValid[1] B, sidesValid[2] C
            if (sidesValid[0] && sidesValid[1])
            {
                Cside = calcHyp(Aside, Bside);
            }
            if (sidesValid[2] && sidesValid[1] || sidesValid[0])
            {
                if (sidesValid[1] && !sidesValid[0])
                {
                    Aside = calcSide(Bside, Cside);
                }
                if (sidesValid[0] && !sidesValid[1])
                {
                    Bside = calcSide(Bside, Cside);
                }
            }

            //sidesValid[0] = A, sidesValid[1] B, sidesValid[2] C
            if (xAng > 0)
            {
                yAng = zAng - xAng;
                yAngle.Text = yAng.ToString();

                if (sidesValid[1])
                {

                }
            }
            //sidesValid[0] = A, sidesValid[1] B, sidesValid[2] C
            if (yAng > 0)
            {
                xAng = zAng - yAng;
                xAngle.Text = xAng.ToString();
                //If we've got an X angle and C side
                if (sidesValid[2])
                {
                    Aside = Math.Round(Math.Sin(ConvertToRadians(xAng)) * Cside,2);
                    Bside = calcSide(Aside, Cside);
                }
                //If we've got an X angle and B side
                if (sidesValid[1])
                {
                    Aside = Math.Round(Math.Tan(ConvertToRadians(xAng)) * Bside, 2);
                    Cside = calcHyp(Aside, Bside);
                }
                //If we've got an X angle and B side
                if (sidesValid[0])
                {
                    Aside = Math.Round(Math.Cos(ConvertRadiansToDegrees(xAng)) / Aside, 2);
                    Cside = calcHyp(Aside, Bside);
                }

            }
            else
            {
                outputField.Text = "Error: Please give at least 1 angle"
            }



            inputA.Text = Aside.ToString();
            inputB.Text = Bside.ToString();
            inputC.Text = Cside.ToString();




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

        public static double ConvertRadiansToDegrees(double radians)
        {
            return (180 / Math.PI) * radians;
        }

        public double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
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

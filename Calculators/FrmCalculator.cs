using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators
{
    public partial class FrmCalculator : Form
    {
        public static FrmCalculator Intance { get; } = new FrmCalculator();

        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string Imput = "";

        public FrmCalculator()
        {
            InitializeComponent();
        }

        //Buttons assigned to numbers
        #region "Numbers Buttons"

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if (Imput == "")
            {
                LblView.Text = "";
                Imput += "0.";
                LblView.Text += Imput;
            }
            else if (Imput != "" && !Imput.Contains("."))
            {
                LblView.Text = "";
                Imput += ".";
                LblView.Text += Imput;
            }
            else if (Imput.Contains("."))
            {
                LblView.Text = "";
                LblView.Text += Imput;
            }
        }          
        

        private void BtnOne_Click(object sender, EventArgs e)
        {
            LblView.Text = "";
            Imput += "1";
            LblView.Text += Imput;
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            LblView.Text = "";
            Imput += "2";
            LblView.Text += Imput;
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            LblView.Text = "";
            Imput += "3";
            LblView.Text += Imput;
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            LblView.Text = "";
            Imput += "4";
            LblView.Text += Imput;
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            LblView.Text = "";
            Imput += "5";
            LblView.Text += Imput;
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            LblView.Text = "";
            Imput += "6";
            LblView.Text += Imput;
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            LblView.Text = "";
            Imput += "7";
            LblView.Text += Imput;
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            LblView.Text = "";
            Imput += "8";
            LblView.Text += Imput;
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            LblView.Text = "";
            Imput += "9";
            LblView.Text += Imput;
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            LblView.Text = "";
            Imput += "0";
            LblView.Text += Imput;
        }

        #endregion         


        //Buttons assigned to Operations
        #region "Operations Buttons"

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            function = '/';
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            function = '*';
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            function = '+';
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            function = '-';
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {

        }

        #endregion


        //Buttons assigned to role
        #region "Essential Buttons"

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        #endregion        
    }
}

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
        string userImput = "";

        public FrmCalculator()
        {
            InitializeComponent();
        }

        //Buttons assigned to numbers
        #region "Numbers Buttons"

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            LblView.Text += ".";
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            LblView.Text += " ";

            LblView.Text += "1";
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            LblView.Text += "2";
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            LblView.Text += "3";
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            LblView.Text += "4";
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            LblView.Text += "5";
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            LblView.Text += "6";
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            LblView.Text += "7";
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            LblView.Text += "8";
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            LblView.Text += "9";
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            LblView.Text += "0";
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
        #region "Essential Buttons "


        #endregion        
    }
}

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
        int function;
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
            if (first == "")
            {
                function = 1;

                LblView.Text = "0";

                first = Imput;

                Imput = "";
            }
            else if (first != "")
            {
                try
                {
                    LblView.Text = "0";

                    second = Imput;

                    double firstnum, secondNum;

                    firstnum = Convert.ToDouble(first);

                    secondNum = Convert.ToDouble(second);

                    if (secondNum == 0)
                    {
                        LblView.Text = "Error";

                        MessageBox.Show("Cannot divide by 0", "Error");
                    }
                    else
                    {
                        result = firstnum / secondNum;

                        LblView.Text = result.ToString();

                        first = Convert.ToString(result);

                        Imput = "";
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            if (first == "")
            {
                function = 2;

                LblView.Text = "0";

                first = Imput;

                Imput = "";
            }
            else if (first != "")
            {
                try
                {
                    LblView.Text = "0";

                    second = Imput;

                    double firstnum, secondNum;

                    firstnum = Convert.ToDouble(first);

                    secondNum = Convert.ToDouble(second);

                    result = firstnum * secondNum;

                    LblView.Text = result.ToString();

                    first = Convert.ToString(result);

                    Imput = "";
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            if(first == "")
            {
                function = 3;

                LblView.Text = "0";

                first = Imput;

                Imput = "";
            }
            else if (first != "")
            {
                try
                {
                    LblView.Text = "0";

                    second = Imput;

                    double firstnum, secondNum;

                    firstnum = Convert.ToDouble(first);

                    secondNum = Convert.ToDouble(second);

                    result = firstnum + secondNum;

                    LblView.Text = result.ToString();

                    first = Convert.ToString(result);

                    Imput = "";
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            if (first == "")
            {
                function = 4;

                LblView.Text = "0";

                first = Imput;

                Imput = "";
            }
            else if (first != "")
            {
                try
                {
                    LblView.Text = "0";

                    second = Imput;

                    double firstnum, secondNum;

                    firstnum = Convert.ToDouble(first);

                    secondNum = Convert.ToDouble(second);

                    result = firstnum - secondNum;

                    LblView.Text = result.ToString();

                    first = Convert.ToString(result);

                    Imput = "";
                }
                catch (Exception ex)
                {

                }
            }            
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            try
            {
                second = Imput;

                double firstnum, secondNum;

                firstnum = Convert.ToDouble(first);

                secondNum = Convert.ToDouble(second);                

                switch (function)
                {
                    case (int)OperationsEnum.DIVISION:

                        if (secondNum == 0)
                        {
                            LblView.Text = "Error";

                            MessageBox.Show("Cannot divide by 0", "Error");
                        }
                        else
                        {
                            result = firstnum / secondNum;

                            LblView.Text = result.ToString();

                            first = Convert.ToString(result);

                            Imput = "";
                        }
                        break;
                    case (int)OperationsEnum.MULTIPLY:
                        result = firstnum * secondNum;

                        LblView.Text = result.ToString();

                        first = Convert.ToString(result);

                        Imput = "";
                        break;
                    case (int)OperationsEnum.ADDITION:
                        result = firstnum + secondNum;

                        LblView.Text = result.ToString();
                        
                        first = Convert.ToString(result);

                        Imput = "";
                        break;
                    case (int)OperationsEnum.SUBTRACTION:
                        result = firstnum - secondNum;

                        LblView.Text = result.ToString();

                        first = Convert.ToString(result);

                        Imput = "";
                        break;
                }
            }
            catch (Exception ex)
            {

            }

        }

        #endregion


        //Buttons assigned to role
        #region "Essential Buttons"

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LblView.Text = "0";

            first = "";

            second = "";

            function = '0';

            result = 0.0;

            Imput = "";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (Imput.Length > 0)
            {
                Imput = Imput.Remove(Imput.Length - 1);

                LblView.Text = Imput;

                if (Imput.Length == 0)
                {
                    LblView.Text = "0";
                }
            }            
        }

        #endregion        
    }
}

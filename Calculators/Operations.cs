using System;
using System.Collections.Generic;
using System.Text;

namespace Calculators
{
    public class Operations
    {
        public double Number1 { get; set; }

        public double Number2 { get; set; }

        public void Addition()
        {
            double calculate = Number1 + Number2;
        }
        public void Subtract()
        {
            double calculate = Number1 - Number2;            
        }
        public void Multiply()
        {
            double calculate = Number1 * Number2;            
        }
        public void Divide()
        {
            double calculate = Number1 / Number2;            
        }

    }
}

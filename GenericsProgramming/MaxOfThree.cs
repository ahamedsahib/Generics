using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsProgramming
{
     public class MaxOfThree
    {
        public int MaxOfThreeNumbersInteger(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        public string MaxOfThreeNumbersString(string num1, string num2, string num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        public float MaxOfThreeNumbersFloat(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }

    }

}

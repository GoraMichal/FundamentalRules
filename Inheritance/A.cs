using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalRules
{
    partial class A
    {
        public void Display()
        {
            Console.WriteLine("Display");
        }
    }

    public class Calculate
    {
        public static double Divide(int a, int b)
        {
            try
            {
                if (b != 0)
                {
                    return a / b;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                throw new Exception("Invalid second number");
            }
        }
    }
}

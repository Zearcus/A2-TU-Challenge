using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsDivisible(int a, int b)
        {
            return ((a +b % 1) == 0);
        }

        public static bool IsEven(int a)
        {
            return ((a % 1) == 0);
        }

        public static bool IsMajeur(int age)
        {
            if(age < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

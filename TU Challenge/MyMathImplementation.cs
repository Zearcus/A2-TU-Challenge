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

        public static bool IsMajeur(int age)
        {
            if (age < 18)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool IsEven(int a)
        {
            return ((a % 2) == 0);
        }

        public static bool IsDivisible(int a, int b)
        {
            return a % b  == 0;
        }

        public static bool IsPrimary(int a)
        {
            if (a % 2 == 0 && a != 2)
            {
                return false;
            }
            else if (a % 3 == 0 && a != 3)
            {
                return false;
            }
            else if (a % 5 == 0 && a != 5)
            {
                return false;
            }
            else if (a % 7 == 0 && a != 7)
            {
                return false;
            }
            else return true;
        }


        public static int Power2(int a)
        {
            return a * a;
        }

        public static int Power(int a, int b)
        {
            int expected = a;

            for (int i = 1; i < b; i++)
            {
                expected = expected * a;
            }

            return expected;
        }

        public static int IsInOrder(int a, int b)
        {
            if( a < b)
            {
                return 1;
            }
            else
            {
                return a == b ? 0 : -1;
            }
        }
    }
}

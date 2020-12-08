using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS3.Problem_Solutions
{
    class Question_2_Solution
    {
        public static int getTotalX(int[] a, int[] b)
        {
            int lcm_of_a = LCM_of_All(a);
            int gcd_of_b = GCD_of_All(b);
            List<int> betweenList = new List<int>();
            int possibleBetweenListElement = lcm_of_a;
            if (gcd_of_b < lcm_of_a)
            {
                return 0;
            }
            else
            {
                while (possibleBetweenListElement >= lcm_of_a && possibleBetweenListElement <= gcd_of_b)
                {
                    if (gcd_of_b % possibleBetweenListElement == 0)
                    {
                        betweenList.Add(possibleBetweenListElement);
                    }
                    possibleBetweenListElement++;
                }
                return betweenList.Count();
            }


        }

        private static int LCM_of_All(int[] numbers)
        {
            return numbers.Aggregate(LCM_of_Two);
        }

        private static int LCM_of_Two(int x, int y)
        {
            return (x * y) / GCD(x, y);
        }

        private static int GCD_of_All(int[] numbers)
        {
            return numbers.Aggregate(GCD);
        }

        private static int GCD(int m, int n)
        {
            if (n == 0)
            {
                return m;
            }
            else
            {
                return GCD(n, m % n);
            }
        }
    }
}

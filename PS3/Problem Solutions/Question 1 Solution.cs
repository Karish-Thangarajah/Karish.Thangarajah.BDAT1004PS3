using System;
using System.Collections.Generic;
using System.Text;

namespace PS3.Problem_Solutions
{
    class Question_1_Solution
    {
        public static string angryProfessor(int k, int[] a)
        {
            int classSize = a.Length;
            int minAllowedLate = classSize - k;
            int studentsLate = 0;
            foreach (var arrivalTime in a)
            {
                if (arrivalTime > 0)
                {
                    studentsLate++;
                    if (studentsLate > minAllowedLate)
                    {
                        return "NO";
                    }
                }
            }
            return "YES";
        }
    }
}

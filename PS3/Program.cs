using System;
using System.Collections.Generic;
using System.Linq;
using PS3.Problem_Solutions;

namespace PS3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            int k1 = 3;
            int[] a1 = new int[] { -1, -3, 4, 2 };

            int k2 = 2;
            int[] a2 = new int[] { 0, -1, 2, 1 };

            Console.WriteLine(Question_1_Solution.angryProfessor(k1, a1));
            Console.WriteLine(Question_1_Solution.angryProfessor(k2, a2));

            //Question 2

            //List<int> sizes = Console.ReadLine().Split(" ").ToList().Select(int.Parse).ToList();


            //int[] a = new int[sizes[0]];
            //int[] b = new int[sizes[1]];

            int[] a = new int[] { 2, 4 };
            int[] b = new int[] { 16, 32, 96 };

            Console.WriteLine(Question_2_Solution.getTotalX(a, b));


        }



    }
}

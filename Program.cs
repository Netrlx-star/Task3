using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] m = new double[3, 3];
            Console.WriteLine("Enter the elements of a 3x3 matrix row-wise:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double det = 
                 m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])
               - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])
               + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);

            Console.WriteLine($"Determinant = {det}");
        }
    }
}

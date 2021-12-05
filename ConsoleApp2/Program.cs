using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите число элементов массива A1");

                StreamWriter sr = new StreamWriter("test.txt");
                int n = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int[] A = new int[n];
                for (int i = 0; i < n; i++)
                {
                    A[i] = rnd.Next(0, 100);
                    Console.Write("\n{0}", A[i]);
                    sr.Write(A[i] + " ");
                }
                sr.Close();

                Console.ReadKey();
            }
    }
}

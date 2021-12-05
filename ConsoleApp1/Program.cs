using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
             * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.*/
            string path = "File.txt";
            DirectoryInfo directory = new DirectoryInfo(path);

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            //Ввести 10 случайных чисел
            int[] array = new int[10];
            int S = 0;
            Console.WriteLine("Необходимо ввести 10 чисел.");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите число под индексом {i}: ");
                array[i] = int.Parse(Console.ReadLine());
                S += array[i];
            }

            Console.WriteLine();
            Console.WriteLine("Вывод чисел, занесенных в файл: ");
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    //Записать в файл 10 введенных чисел
                    sw.WriteLine(array[i]);
                }

            }

            //Открыть файл

            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }

            //Вывести сумму введенных чисел на консоли
            Console.Write("Сумма введенных чисел: ");
            Console.WriteLine("{0}", S);
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }

}
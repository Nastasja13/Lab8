using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Выберите любую папку на своем компьютере, имеющую вложенные директории. 
             * Выведите на консоль ее содержимое и содержимое всех подкаталогов.*/

            string path = "C:/2_Обучение";

            DirectoryInfo MyFolder = new DirectoryInfo(path);
            DirectoryInfo[] folder = MyFolder.GetDirectories();


            Console.WriteLine("Список папок в папке 2_Обучение:");
            foreach (DirectoryInfo f in folder)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine();
            Console.WriteLine("Список файлов в папке 2_Обучение:");
            string[] files = Directory.GetFiles(path);
            foreach (string s in files)
            {
                Console.WriteLine(s);
                Console.ReadKey();
            }

            /*Дальше надо выполнить:
            Если в папке "2_Обучение" обнаруживается еще одна папка, то нужно отобразить ее содержимое?
            Если да - не могу понять - как. Думала по аналогии с DriveInfo, но так не работает.

            Console.WriteLine("Эксперимент");
            DriveInfo [] drives = DriveInfo.GetDrives();
            foreach (DriveInfo d in drives)
            {
                Console.WriteLine("Название: {0}", d.Name);
                if (d.IsReady)
                {
                    Console.WriteLine(...);
                }
            }    */


            Console.ReadKey();




        }
    }
}

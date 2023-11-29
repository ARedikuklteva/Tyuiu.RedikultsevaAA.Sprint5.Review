using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Tyuiu.RedikultsevaAA.Sprint5.Review.V11.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint5.Review.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 - Review | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Вариант #11                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан файл InPutDataFileTask7V11.txt (файл взять из архива согласно вашему   *");
            Console.WriteLine("* варианту. Создать папку в ручную DataSprint5 и скопировать в неё файл) в   *");
            Console.WriteLine("* котором есть набор символьных данных.Удалить все строчные русские буквы из *");
            Console.WriteLine("* файла.Полученный результат сохранить в файл OutPutDataFileTask7V11.txt.    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V11.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V11.txt";

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Находится в файле:");
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SpirinAA.Sprint3.Task3.V3.Lib;

namespace Tyuiu.SpirinAA.Sprint3.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Спирин А. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Спирин Александр Алексеевич | АСОиУб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв f,        *");
            Console.WriteLine("* находящихся на соседних позициях в строке: cvbmzff orffgtrr dkfvfffdr   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "cvbmzff orffgtrr dkfvfffdr";
            char chr = 'f';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + chr);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write($"Колличество символов = {dataService.GetMinCharCount(value, chr)}");

            Console.ReadKey();
        }
    }
}

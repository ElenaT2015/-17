using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер");
            int numInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму");
            int sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            string name = Console.ReadLine();
            kliyent<int> kliyent1 = new kliyent<int>(numInt, sum, name);
            Console.WriteLine(kliyent1.GetInfo());

            Console.WriteLine("Введите строковый номер");
            string numString = Console.ReadLine();
            Console.WriteLine("Введите ,баланс");
            sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            name = Console.ReadLine();
            kliyent<string> kliyent2 = new kliyent<string>(numString, sum, name);
            Console.WriteLine(kliyent1.GetInfo());

            kliyent<int> kliyents1 = new kliyent<int> (numInt, sum, name);
            kliyents1.Input();
               Console.WriteLine(kliyents1.GetInfo());

            kliyent<string> kliyents2 = new kliyent<string>(numString, sum, name);
            kliyents2.Input();
            Console.WriteLine(kliyents2.GetInfo());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class kliyent<T>
    {
        public T Num { get; set; }
        public int Sum { get; set; }
        public string Name { get; set; }

        public kliyent(T num, int sum, string name)
        {
            Num = num;
            Sum = sum;
            Name = name;
        }

        public string GetInfo()
        {
            return $"{Num} {Sum} {Name}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер");
            string numString = Console.ReadLine();
            Num = (T)Convert.ChangeType(numString, typeof(T));
            Console.WriteLine("Введите сумму");
            Sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
        }
    }
}

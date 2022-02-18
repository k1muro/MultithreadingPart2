using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            Console.WriteLine("Заполни класс:");
            Console.WriteLine("Money=");
            int a = int.Parse(Console.ReadLine());
            b.Money = a;
            Console.WriteLine("BankName=");
            string d = Console.ReadLine();
            b.BankName = d;
            Console.WriteLine("Percent=");
            int c = int.Parse(Console.ReadLine());
            b.Money = c;
            Console.WriteLine("Желаете изменить данные?");
            Console.WriteLine("1)Да  2)Зачем?");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 1)
            {
                b.Edit();
                string writePath = @"C:\Users\RYZEN\source\repos\MultithreadingPart2\MultithreadingPart2\Save.txt";
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(b.BankName);
                    sw.WriteLine(b.Money);
                    sw.WriteLine(b.Percent);
                }
            }

        }


    }

    class Bank
    {
        public int Money { get; set; }
        public string BankName { get; set; }
        public int Percent { get; set; }

        public void Edit()
        {
            Console.WriteLine("Что вы хотите изменит 1)Money  2)BankName  3)Percent");
            int a = int.Parse(Console.ReadLine());
            if (a==1)
            {
                Console.WriteLine("Введите новое значение:");
                int mone = int.Parse(Console.ReadLine());
                Money = mone;
            }
            else if (a == 2)
            {
                Console.WriteLine("Введите новое значение:");
                string banknam = Console.ReadLine();
                BankName = banknam;
            }
            else if (a== 3)
            {
                Console.WriteLine("Введите новое значение:");
                int perc = int.Parse(Console.ReadLine());
                Percent = perc;
            }
            else
            {
                Console.WriteLine("Такого варианта не существует!!!");
                return;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLaba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Console.ReadKey();
        }
        static void Task1()
        {
            Console.WriteLine("Задание номер 1\n");

            BankSchet bankSchet = new BankSchet(1234, 2000000, TypeSchet.tekushiy);
            decimal num;
            int num2;
            Console.WriteLine("Введите свой банковский ID:");
            bool a = int.TryParse(Console.ReadLine(), out num2);
            bankSchet.IDSchet = num2;
            Console.WriteLine("Введите свой баланс:");
            a = decimal.TryParse(Console.ReadLine(), out num);
            bankSchet.Balanceschet = num;
            Console.WriteLine("Введите тип своего счета:\nСберегательный - 1\nТекущий - 2");
            a = int.TryParse(Console.ReadLine(), out num2);

            if (num2 == 1)
            {
                bankSchet.Typeschet = TypeSchet.sberegatelnuy;
            }
            else if (num2 == 2)
            {
                bankSchet.Typeschet = TypeSchet.tekushiy;
            }
            else
            {
                bankSchet.Typeschet = TypeSchet.obshiy;
            }

            bankSchet.PrintBankSchet();

        }
        static void Task2()
        {
            Console.WriteLine("\nЗадание номер 2\n");

            //1 account
            BankSchet2 bankSchet = new BankSchet2(123, TypeSchet.obshiy);
            decimal num;
            int num2;
            Console.WriteLine("Введите свой баланс:");
            bool a = decimal.TryParse(Console.ReadLine(), out num);
            bankSchet.Balanceschet = num;
            Console.WriteLine("Введите тип своего счета:\nСберегательный - 1\nТекущий - 2");
            a = int.TryParse(Console.ReadLine(), out num2);

            if (num2 == 1)
            {
                bankSchet.Typeschet = TypeSchet.sberegatelnuy;
            }
            else if (num2 == 2)
            {
                bankSchet.Typeschet = TypeSchet.tekushiy;
            }
            else
            {
                bankSchet.Typeschet = TypeSchet.obshiy;
            }
            bankSchet.PrintBankSchet2();

            //2 account
            BankSchet2 bankSchet2 = new BankSchet2(123, TypeSchet.obshiy);
            Console.WriteLine("Введите свой баланс:");
            a = decimal.TryParse(Console.ReadLine(), out num);
            bankSchet2.Balanceschet = num;
            Console.WriteLine("Введите тип своего счета:\nСберегательный - 1\nТекущий - 2");
            a = int.TryParse(Console.ReadLine(), out num2);

            if (num2 == 1)
            {
                bankSchet2.Typeschet = TypeSchet.sberegatelnuy;
            }
            else if (num2 == 2)
            {
                bankSchet2.Typeschet = TypeSchet.tekushiy;
            }
            else
            {
                bankSchet2.Typeschet = TypeSchet.obshiy;
            }
            bankSchet2.PrintBankSchet2();
        }
        static void Task3()
        {
            Console.WriteLine("\nЗадание номер 3\n");

            BankSchet3 bankSchet = new BankSchet3(10000, TypeSchet.obshiy);
            bankSchet.PrintBankSchet3();
            int num2;
            Console.WriteLine("Введите тип своего счета:\nСберегательный - 1\nТекущий - 2");
            bool a = int.TryParse(Console.ReadLine(), out num2);

            if (num2 == 1)
            {
                bankSchet.Typeschet = TypeSchet.sberegatelnuy;
            }
            else if (num2 == 2)
            {
                bankSchet.Typeschet = TypeSchet.tekushiy;
            }
            else
            {
                bankSchet.Typeschet = TypeSchet.obshiy;
            }
            Console.WriteLine("Что вы хотите сделать с балансом:");
            Console.WriteLine("Внести деньги - 1\nСнять деньги - 2");
            bool b = int.TryParse(Console.ReadLine(), out int vub);
            if (vub == 1)
            {
                Console.WriteLine("Сколько денег хотите внести?");
                b = int.TryParse(Console.ReadLine(), out vub);
                bankSchet.Popolneniy(vub);
            }
            else if (vub == 2)
            {
                Console.WriteLine("Сколько денег хотите снять?");
                b = int.TryParse(Console.ReadLine(), out vub);
                if (vub <= bankSchet.balanceschet)
                {
                    bankSchet.Snyatie(vub);
                }
                else
                {
                    throw new FormatException("У вас нет столько денег на счету.");
                }
            }
            bankSchet.PrintBankSchet3();
        }
    }
}

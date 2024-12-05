using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLaba
{
    public enum TypeSchet2
    {
        tekushiy,
        sberegatelnuy,
        obshiy
    }
    public class BankSchet2
    {
        private static int idCounter = 1;
        public int id { get; }
        private decimal balanceschet;
        private TypeSchet typeschet;

        public BankSchet2(decimal balanceSchet, TypeSchet typeSchet)
        {
            this.balanceschet = balanceSchet;
            this.typeschet = typeSchet;
            id = idCounter;
            NovuyID();
        }

        private static int NovuyID()
        {
            return idCounter++;
        }
        public int IDSchet
        {
            get { return id; }
        }
        public decimal Balanceschet
        {
            get { return balanceschet; }
            set { balanceschet = value; }
        }
        public TypeSchet Typeschet
        {
            get { return typeschet; }
            set { typeschet = value; }
        }
        public void PrintBankSchet2()
        {
            Console.WriteLine($"\nНомер счета: {idCounter}");
            Console.WriteLine($"Баланс: {balanceschet}");
            Console.WriteLine($"Тип счета: {typeschet}");
        }
    }
}

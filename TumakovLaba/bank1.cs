using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLaba
{
    public enum TypeSchet
    {
        tekushiy,
        sberegatelnuy,
        obshiy
    }
    public class BankSchet
    {
        private int idschet;
        private decimal balanceschet;
        private TypeSchet typeschet;
        public BankSchet(int iDSchet, decimal balanceSchet, TypeSchet typeSchet)
        {
            idschet = iDSchet;
            balanceschet = balanceSchet;
            this.typeschet = typeSchet;
        }
        public int IDSchet
        {
            get { return idschet; }
            set { idschet = value; }
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
        public void PrintBankSchet()
        {
            Console.WriteLine($"\nНомер счета: {idschet}");
            Console.WriteLine($"Баланс: {balanceschet}");
            Console.WriteLine($"Тип счета: {typeschet}");
        }
    }
}

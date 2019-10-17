using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("amount");
            int money = int.Parse(Console.ReadLine());
            int c, d;
            Console.WriteLine("Withdraw");
            int Withdraw = int.Parse(Console.ReadLine());
            c = money - Withdraw;
            Console.WriteLine("Balance " + money + "-" + Withdraw + "=" + c);
            Console.WriteLine("amount " + c);
            Console.WriteLine("Deposit");
            int Deposit = int.Parse(Console.ReadLine());
            d = c + Deposit;
            Console.WriteLine("Balance " + c + "+" + Deposit + "=" + d);
        }
    }
}

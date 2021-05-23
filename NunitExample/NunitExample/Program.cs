using System;

namespace NunitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Banking obj = new Banking();
            obj.DepositAmount(1000);
            Console.WriteLine("Balance: "+obj.Balance);
        }
    }
}

using System;

namespace DesignByContractSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.Deposit(-1);
        }
    }
}

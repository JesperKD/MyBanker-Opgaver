using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_Opgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(Card item in CardList.CreateListofCards())
            {
                Console.WriteLine("Cardtype: " + item.cardtype);
                Console.WriteLine("Name: " + item.name);
                Console.WriteLine("CardNumber: " + item.cardnum);
                Console.WriteLine("AccountNumber:" + item.accountnum);
                Console.WriteLine("Experation Date: " + item.expirydate);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

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
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

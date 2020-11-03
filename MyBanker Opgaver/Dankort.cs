using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_Opgaver
{
    public class Dankort : Card
    {

        public Dankort()
        {
            cardtype = "Visa/Dankort";
            List<int> temp = new List<int>();
            temp.Add(4);

            prefixList = temp;

            cardnum = GenerateCardNum();
            accountnum = GenerateAccountNum();
            expirydate = GenerateDate();
        }

    }
}

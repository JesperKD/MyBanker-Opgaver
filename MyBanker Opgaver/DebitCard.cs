using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_Opgaver
{
    public class DebitCard : Card
    {

        public DebitCard()
        {
            cardtype = "DebitCard";
            List<int> temp = new List<int>();
            temp.Add(2400);
            prefixList = temp;

            cardnum = GenerateCardNum();
            accountnum = GenerateAccountNum();
            expirydate = "Never";
        }

    }
}

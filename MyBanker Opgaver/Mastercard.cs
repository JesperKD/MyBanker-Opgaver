using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_Opgaver
{
    public class Mastercard : Card
    {

        public Mastercard()
        {
            cardtype = "Mastercard";
            List<int> temp = new List<int>();
            temp.Add(51);
            temp.Add(52);
            temp.Add(53);
            temp.Add(54);
            temp.Add(55);

            prefixList = temp;

            cardnum = GenerateCardNum();
            accountnum = GenerateAccountNum();
            expirydate = GenerateDate();
        }

    }
}

using System;
using System.Collections.Generic;

namespace MyBanker_Opgaver
{
    public class Maestro : Card
    {
        public Maestro()
        {
            cardtype = "Maestro";
            mincardnum = 19;

            List<int> temp = new List<int>();
            temp.Add(5018);
            temp.Add(5020);
            temp.Add(5038);
            temp.Add(5893);
            temp.Add(6304);
            temp.Add(6759);
            temp.Add(6761);
            temp.Add(6762);
            temp.Add(6763);

            prefixList = temp;

            cardnum = GenerateCardNum();
            accountnum = GenerateAccountNum();
            expirydate = GenerateDate();
        }

        public override string GenerateDate()
        {
            DateTime today = DateTime.Today;

            DateTime addedMonths = today.AddMonths(8);

            string endDate = addedMonths.AddYears(5).ToString();

            string[] result = endDate.Split(' ');

            return result[0];
        }

    }
}

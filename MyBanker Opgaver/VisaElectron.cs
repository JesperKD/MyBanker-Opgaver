using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_Opgaver
{
    public class VisaElectron : Card
    {

        public VisaElectron()
        {
            cardtype = "Visa Electron";

            List<int> temp = new List<int>();
            temp.Add(4026);
            temp.Add(417500);
            temp.Add(4508);
            temp.Add(4844);
            temp.Add(4913);
            temp.Add(4917);

            prefixList = temp;

            cardnum = GenerateCardNum();
            accountnum = GenerateAccountNum();
            expirydate = GenerateDate();
        }

    }
}

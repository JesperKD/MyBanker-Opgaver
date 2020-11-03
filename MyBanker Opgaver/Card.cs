using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_Opgaver
{
    public abstract class Card
    {
        private string CardType;

        public string cardtype
        {
            get { return CardType; }
            set { CardType = value; }
        }


        private string AccountNum;

        public string accountnum
        {
            get { return AccountNum; }
            set { AccountNum = value; }
        }


        private string CardNum;

        public string cardnum
        {
            get { return CardNum; }
            set { CardNum = value; }
        }

        private int MinCardNum = 16;

        public int mincardnum
        {
            get { return MinCardNum = 16; }
            set { MinCardNum = value; }
        }


        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }


        private List<int> PreFixList;

        public List<int> prefixList
        {
            get { return PreFixList; }
            set { PreFixList = value; }
        }


        private string ExpiryDate;

        public string expirydate
        {
            get { return ExpiryDate; }
            set { ExpiryDate = value; }
        }

        public virtual string GenerateAccountNum()
        {
            Random random = new Random();
            string prefix = "3520";

            string result = prefix;

            while(result.Length < 14)
            {
                int temp = random.Next(9);

                result = result + temp.ToString();
            }

            return result;
        }

        public virtual string GenerateCardNum()
        {
            Random random = new Random();

            int randomPrefix = 0;

            for (int i = 0; i < prefixList.Count(); i++)
            {

                randomPrefix = prefixList[i];

            }

            string result = randomPrefix.ToString();

            while(result.Length < MinCardNum)
            {
                int temp = random.Next(9);

                result = result + temp.ToString();
            }


            return result;
        }

        public virtual string GenerateDate()
        {
            DateTime today = DateTime.Today;

            string endDate = today.AddYears(5).ToString();

            string[] result = endDate.Split(' ');

            return result[0];
        }

    }
    
}

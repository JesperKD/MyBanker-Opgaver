using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_Opgaver
{
    public static class CardList
    {
        /// <summary>
        /// Instansiates cards and return them as a List
        /// </summary>
        /// <returns></returns>
        public static List<Card> CreateListofCards()
        {
            Card debitcard = new DebitCard();
            debitcard.name = "Rasputin Nielsen";

            Card maestrocard = new Maestro();
            maestrocard.name = "Tina Johnnson";

            Card visaelectron = new VisaElectron();
            visaelectron.name = "Ole Wedel";

            Card dankort = new Dankort();
            dankort.name = "Ulla Hedegaard";

            Card mastercard = new Mastercard();
            mastercard.name = "Michael Sommer";

            List<Card> cardList = new List<Card>();
            cardList.Add(debitcard);
            cardList.Add(maestrocard);
            cardList.Add(visaelectron);
            cardList.Add(dankort);
            cardList.Add(mastercard);

            return cardList;
        }
    }
}

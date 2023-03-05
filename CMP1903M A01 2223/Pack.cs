using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public int pack_length

        public Pack()
        {
            //Initialise the card pack here
            //values of card pack

            pack_length = pack.Count;

            while (pack_length < 52)
            {
                Card New_Card = new Card();
                int inx = pack.IndexOf(New_Card);
                if (inx < 0)
                {
                    pack.Add(New_Card);
                    pack_length += 1;
                }
                
            }
           
        }

        public static bool shuffleCardPack(int typeOfShuffle)  // int here is input from user in program
        {
            //Shuffles the pack based on the type of shuffle

        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount) // int here is input from user in program
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}

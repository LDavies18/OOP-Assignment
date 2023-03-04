using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        //For one card to then be stored in a pack.

        //hides card value from being accesed from ouside class

        private int card_value;
        //Random generation?
    
        public int Value
        {
            get { return card_value; }
            set { card_value = value; }
        }
       
       //hides suit from being accessed from outside the class
        private int card_suit;


        public int Suit
        {
            get { return card_suit; }
            set { card_suit = value; }
        }

        static void Main(string[] args)
        {
          
        }
    }
}

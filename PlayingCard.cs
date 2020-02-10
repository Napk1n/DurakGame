using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIII.DurakGame.Classes
{
    class PlayingCard
    {
        // PRIVATE VARIABLES
        private int myRankIndex;
        // an int to represent the rank {1 - 13}

        private int mySuitRank;
        // an int to represent the suit (0 - 3}

        private int myValue;
        // an int to represent the 'value' of the card. 

        // default value for rank
        const int DEFAULT_VALUE_WANTED = -999;

        // PUBLIC VARIABLES

        public int rankIndex { get { return this.myRankIndex; } set { this.myRankIndex = value; }  }
        private int suitRank { set { mySuitRank = value; } get { return mySuitRank; } }
        private int value { set { myValue = value; } get { return myValue; } }

        public IReadOnlyCollection<string> CARD_SUIT = new String[4] { "Spades", "Hearts", "Diamonds", "Clubs" };
        public IReadOnlyCollection<string> CARD_RANK = new string[14] { "Not Used", "Ace", "Two", "Three", "Four", "Five",
                                "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        const int RANKS = 13;
        const int SUITS = 4;
        bool faceUp = false;


        // CONSTRUCTORS

        public PlayingCard(int rankIndex, int suitIndex, int value, bool faceUp)
        {
            try
            {
                this.rankIndex = rankIndex;
                this.suitRank = suitIndex;
                this.value = value;
                this.faceUp = faceUp;
            }catch(Exception e)
            {
                // Will catch any exception thrown from setters, will catch more specialized exceptions later on
                Console.WriteLine(e);
            }
        }

        // Default Constructor
        public PlayingCard()
        {
        }
    }
}

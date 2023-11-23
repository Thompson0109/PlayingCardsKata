using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Cards_kata.Models
{
    public class PlayingCard
    {
        public int CardValue { get; set; }
        public string CardSuite { get; set; }

        public static int JokerCount;
        public static bool isJokerAccepted()
        {
            JokerCount++;

            if (JokerCount >= 3)
                return false;
            else
                return true;
        }

        public static int CardSuiteModifier(PlayingCard card)
        {
            int modifiedCardVal;

            switch (card.CardSuite)
            {
                case "c":
                    modifiedCardVal = card.CardValue * 1;
                    break;
                case "d":
                    modifiedCardVal = card.CardValue * 2;
                    break;
                case "h":
                    modifiedCardVal = card.CardValue * 3;
                    break;
                case "s":
                    modifiedCardVal = card.CardValue * 4;
                    break;
                default:
                    Console.WriteLine($"Invalid Card Suite [{card.CardSuite}]");
                    modifiedCardVal = card.CardValue;
                    break;
            }
            return modifiedCardVal;
        }
    }
}

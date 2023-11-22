using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Cards_kata.Models
{
    public class PlayingCard
    {
        public int CardValue { get; set; }
        public string CardSuite { get; set; }



        private static int JokerCount;
        public static bool isJokerAccepted()
        {
            JokerCount++;

            if (JokerCount >= 3)
                return false;
            else
                return true;
        }

        public static int CardSuiteModifier(string cardSuite, int CardVal)
        {
            int modifiedCardVal;

            switch (cardSuite)
            {
                case "c":
                    modifiedCardVal = CardVal * 1;
                    break;
                case "d":
                    modifiedCardVal = CardVal * 2;
                    break;
                case "h":
                    modifiedCardVal = CardVal * 3;
                    break;
                case "s":
                    modifiedCardVal = CardVal * 4;
                    break;
                default:
                    modifiedCardVal = CardVal;
                    break;
            }
            return modifiedCardVal;
        }
    }
}

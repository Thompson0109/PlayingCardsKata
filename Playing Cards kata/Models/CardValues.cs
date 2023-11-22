using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Cards_kata.Models
{
    public class CardValues
    {
        public static int One = 1;
        public static int Two = 2;  
        public static int Three = 3;
        public static int Four = 4;
        public static int Five = 5;
        public static int Six = 6;
        public static int Seven = 7;
        public static int Eight = 8;   
        public static int Nine = 9;
            
            
        public static int T = 10;
        public static int J = 11;  
        public static int Q = 12;
        public static int K = 13;
        public static int A = 14;

        private static int JokerCount;
        public static bool isJokerAccepted()
        {
            JokerCount ++;

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
                case "clubs":
                    modifiedCardVal = CardVal * 1;
                    break;
                case "diamond":
                    modifiedCardVal = CardVal * 2;
                    break;
                case "heart":
                    modifiedCardVal = CardVal * 3;
                    break;
                case "spade":
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

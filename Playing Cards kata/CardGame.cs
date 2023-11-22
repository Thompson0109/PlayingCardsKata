using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Cards_kata
{
    public class CardGame
    {
       private static  Dictionary<string, int> CardsInHand = new Dictionary<string, int>();

        public static void StartGame(List<string> ListOfCards)
        {

            foreach (var card in ListOfCards)
            {
                ConvertToCardValues(card);
            }
            Console.WriteLine("BreakPOint");
        }

        public static void ConvertToCardValues(string card)
        {
            char[] chars = card.ToCharArray();
            int CardVal;

            try
            {
                CardVal = System.Convert.ToInt32(chars[1]);

            }
            catch (Exception)
            {
                
                switch (chars[1].ToString())
                {
                    case "T":
                        CardVal = 10;
                        break;
                    case "J":
                        CardVal = 11;
                        break;
                    case "Q":
                        CardVal = 12;
                        break;
                    case "K":
                        CardVal = 13;
                        break;
                    case "A":
                        CardVal = 14;
                        break;
                    default:
                        CardVal = 0;
                        break;
                }
                throw;
            }
        
            CardsInHand.Add(chars[0].ToString(), CardVal);
        }

    }
}

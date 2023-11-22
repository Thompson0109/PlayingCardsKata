using Playing_Cards_kata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Cards_kata
{
    public class CardGame
    {
        public static List<PlayingCard> handOfCards = new List<PlayingCard>();
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
            string SuiteChar = chars[1].ToString();
            string CardChar = chars[0].ToString();
            int CardVal;

            try
            {
                CardVal = System.Convert.ToInt32(CardChar);

            }
            catch (Exception e)
            {
          
                switch (CardChar)
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
                Console.WriteLine("Card Value was 10 or over");
            }
            PlayingCard currentCard = new PlayingCard();
            currentCard.CardSuite = SuiteChar;
            currentCard.CardValue = CardVal;

            handOfCards.Add(currentCard);
        }

    }
}

using Playing_Cards_kata.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Cards_kata
{
    public class CardGame
    {
        public static List<PlayingCard> handOfCards = new List<PlayingCard>();
        public static  List<int> ModifiedCardValues = new List<int>();
        public static int FinalGameScore = 0;

        private static bool IsJokerModifierAccepted;


        public static void StartGame(List<string> ListOfCards = null)
        {
            Console.WriteLine("Welcome to the Card Score Calculator");
            Console.WriteLine("Insert a Comma Seperate List of the cards in your hand: ");
            ListOfCards = Console.ReadLine().Split(",").ToList();
           
            Console.WriteLine(ListOfCards);
            int modifiedCardValue;
            char[] charrArr;
            foreach (var card in ListOfCards)
            {
                charrArr = card.ToCharArray();
                //Checks For invalid Card Entries
                if(charrArr.Length > 2) {
                    Console.WriteLine(card.ToString() + " Is not a valid entry");
                }
                else if(card.ToLower() == "jk")
                {
                    bool isJokerAllowed = PlayingCard.isJokerAccepted();
                    if (isJokerAllowed)
                    {
                        IsJokerModifierAccepted = true;
                        Console.WriteLine("You recieved a Joker. This will double your overall score.");
                    }
                    else
                    {
                        IsJokerModifierAccepted = false;
                        Console.WriteLine("A hand cannot contain more than two Jokers");
                    }
                }
                else
                {
                    ConvertToCardValues(card);
                }
                
            }

            foreach (var card in handOfCards)
            {
                Console.WriteLine(card.CardSuite.ToString());
               
                if (card.CardSuite.ToLower() == "k" || card.CardSuite == "d" || card.CardSuite == "c" || card.CardSuite == "s" || card.CardSuite == "h" || card.CardSuite == "jk")
                {
                    ModifiedCardValues.Add(PlayingCard.CardSuiteModifier(card));
                }
                else
                {
                    Console.WriteLine("Invalid Suite Entry: " + card.CardSuite);
                }
            }

            FinalScroreSum();
            Console.WriteLine("Would You like to play again? [Y Or N]: ");
            
           string result = Console.ReadLine();
            if (result.ToLower() == "y")
            {
                EndOfRoundCleanUp();
                StartGame();
            }
        }

        public static void ConvertToCardValues(string card)
        {
            int CardVal;
            char[] chars = card.ToCharArray();
            string SuiteChar = chars[1].ToString().ToLower();
            string CardChar = chars[0].ToString();

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
            }
            PlayingCard currentCard = new PlayingCard();
            currentCard.CardSuite = SuiteChar;
            currentCard.CardValue = CardVal;

            handOfCards.Add(currentCard);
        }

        private static void FinalScroreSum()
        {
           int FinalScore = ModifiedCardValues.Sum();

            if (IsJokerModifierAccepted)
            {
                for (int i = 0; i < PlayingCard.JokerCount; i++)
                {
                    FinalScore = FinalScore * 2;
                }
            }
         
            FinalGameScore = FinalScore;
            Console.WriteLine($"Your Final Score was: {FinalGameScore.ToString()}");
        }

        public static void EndOfRoundCleanUp()
        {
            FinalGameScore = 0;
            ModifiedCardValues.Clear();
            handOfCards.Clear();
        }

        public static void EndOfRoundCleanUpUnitTest()
        {
            FinalGameScore = 0;
            ModifiedCardValues.Clear();
            handOfCards.Clear();
            PlayingCard.JokerCount = 0;
        }

    }
}

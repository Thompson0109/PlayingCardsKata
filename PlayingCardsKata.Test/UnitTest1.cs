using Playing_Cards_kata;
using Playing_Cards_kata.Models;

namespace PlayingCardsKata.Test
{
    [TestClass]
    public class PlayingCardsKataUnitTests
    {
        // Note: Using Red Green Refactor Method

        //GIVEN I have started the card Game application 
        //WHEN I enter a ‘<listOfCards>’ containing one or two jokers
        //THEN the score for the hand should and displayed on the user interface


        [TestMethod]
        public void AcceptsListOfCards()
        {

            List<string> ListOfCardsTest = new List<string>() { "2C", "2D", "2H", "TC", "KC" };
            CardGame.StartGame(ListOfCardsTest);

            Assert.IsNotNull(CardGame.handOfCards);
        }

        [TestMethod]
        public void JokersInCardList()
        {

           //int TestVal =  CardValues.T + CardValues.J;
           // Console.WriteLine(TestVal);
           // Assert.AreEqual(TestVal, 21);
        }

        //Given I have started the Card Game application
        // When I enter a ‘<listOfCards>’
        //Then the correct ‘<score>’ should be displayed on the user interface

        [TestMethod]
        public void CardToScoreConversion()
        {

        }

        //GIVEN I have started the Card Game application
        //WHEN I enter a ‘<listOfCards>’ that’s invalid
        //THEN an ‘<errorMessage>’ should be displayed on the user interface
        [TestMethod]
        public void InvalidCardSelectionException()
        {

        }
    }
}






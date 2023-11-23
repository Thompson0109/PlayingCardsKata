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
        public void AddsSuiteModifier()
        {

            List<string> ListOfCardsTest = new List<string>() { "2C", "2D", "2H", "TC", "KC" };
            CardGame.StartGame(ListOfCardsTest);

            Assert.IsNotNull(CardGame.ModifiedCardValues);

            Assert.AreEqual(CardGame.ModifiedCardValues[1], 4);
            Assert.AreEqual(CardGame.ModifiedCardValues[4], 13);

        }


        [TestMethod]
        public void JokersInCardList()
        {
            List<string> ListOfCardsTestOneJoker = new List<string>() { "JK","2C"};
            List<string> ListOfCardsTestTwoJokers = new List<string>() { "JK", "2C", "Jk", "TC" };
            List<string> ListOfCardsTestThreeJokers = new List<string> () { "Jk", "TD", "JK", "TH", "Jk" };

            Assert.IsNotNull(CardGame.FinalGameScore);


            //Test One Joker Modifiers
            CardGame.StartGame(ListOfCardsTestOneJoker);
            Assert.AreEqual(CardGame.FinalGameScore, 4);
            CardGame.EndOfRoundCleanUpUnitTest();

            //Tests Two Joker Modifiers
            CardGame.StartGame(ListOfCardsTestTwoJokers);
            Assert.AreEqual(CardGame.FinalGameScore, 48);
            CardGame.EndOfRoundCleanUpUnitTest();

            //Tests Three Joker Modifiers
            CardGame.StartGame(ListOfCardsTestThreeJokers);
            Assert.AreEqual(CardGame.FinalGameScore, 50);
            CardGame.EndOfRoundCleanUpUnitTest();
        }

        //Given I have started the Card Game application
        // When I enter a ‘<listOfCards>’
        //Then the correct ‘<score>’ should be displayed on the user interface

        [TestMethod]
        public void CardToScoreConversion()
        {
            List<string> ListOfCardsTest = new List<string>() { "2C", "2D", "2H", "TC", "KC" };
            List<string> ListOfCardsTestTwoHundred = new List<string>() { "TC", "TD", "TH", "TS" };


            CardGame.StartGame(ListOfCardsTest);

            Assert.IsNotNull(CardGame.FinalGameScore);
            Assert.AreEqual(CardGame.FinalGameScore, 35);

            CardGame.StartGame(ListOfCardsTestTwoHundred);

            CardGame.EndOfRoundCleanUpUnitTest();

        }

        //GIVEN I have started the Card Game application
        //WHEN I enter a ‘<listOfCards>’ that’s invalid
        //THEN an ‘<errorMessage>’ should be displayed on the user interface
        [TestMethod]
        public void InvalidCardSelectionException()
        {
            //Numbers with double digits will not work as expected. It will just get the first number that appeats.
            List<string> ListOfCardsTest = new List<string>() { "17C", "2D", "2H", "20C", "KC", "5Q" };
            CardGame.StartGame(ListOfCardsTest);

            //Current behaviour removes invalid items from the hand. In this case only 3 are valid. 
            Assert.IsTrue(CardGame.ModifiedCardValues.Count == 3);

            CardGame.EndOfRoundCleanUpUnitTest();

        }
    }
}






// See https://aka.ms/new-console-template for more information
using Playing_Cards_kata;



//Requirements 


//Summary// Takes a which takes a list of playing cards and returns a score for the cards given.

//Must be TDD//

//Scenarios 

//GIVEN I have started the card Game application 
//WHEN I enter a ‘<listOfCards>’ containing one or two jokers
//THEN the score for the hand should and displayed on the user interface

//GIVEN I have started the card game application 
//WHEN I enter ‘<listOfCards>’ containing one or two jokers 
//THEN the score for the hand should be doubled and displayed on the user interface

//GIVEN I have started the Card Game application
//WHEN I enter a ‘<listOfCards>’ that’s invalid
//THEN an ‘<errorMessage>’ should be displayed on the user interface

//CARD Point System//
//Each card in the deck of cards has a value. These are the rules below 
// Number cards have the worth of thier value
// Jack: 11
// Queen: 12 
// Kind: 13 
// Ace: 14 

// o Club: Multiply by 1
//o Diamond: Multiply by 2
//o Heart: Multiply by 3
//o Spade: Multiply by 4

//JOKER CARD: DOUBLES 
// Joker cannot appear three or more times 


//Code Requierments//

// Back end in c#
// Code to convert score of cards to be done in back end c#
//List of cards must be in csv
// Must contain a UI where the user can input a list of cards


// The score must be displated on the user interface 
// The applciation must convert any valid lists of cards to their score 
// The application must display an error message if the user enters an invalid list of cards


CardGame.StartGame();
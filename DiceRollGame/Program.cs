
using System.Security.Cryptography.X509Certificates;

var newGame = new DiceRollGame(3);
OutcomePrinter.PrintDiceRollGuessOutcome(newGame.PlayAndGetIfIsAWinner());





// enums (like factors) - assigns numbers from 0 assigned to each member of the list. They're ultimately integers under the hood.
enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}


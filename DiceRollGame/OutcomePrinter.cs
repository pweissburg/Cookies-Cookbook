
static class OutcomePrinter
{
    public static void PrintDiceRollGuessOutcome(bool guessIsCorrect)

    {
        if (guessIsCorrect)
        {
            Console.WriteLine("You win! :)");
        }
        else Console.WriteLine("You lose :(");
    }

}








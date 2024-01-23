
class DiceRollGame

{
    private int actualRoll = new Random().Next(1, 7);
    private int attempt = 0;
    private int _maxAttempts;
    private InputValidator guess = new InputValidator();

    public DiceRollGame(int maxAttempts)
    {
        _maxAttempts = maxAttempts;
    }

    public bool PlayAndGetIfIsAWinner()
    {
        do
        {

            if (guess.GetValidInput() == actualRoll)
            {

                return true;
            }
            else
            {
                Console.WriteLine("Wrong number");
                attempt++;
            }
        }
        while (attempt < _maxAttempts);
        return false;
    }
}








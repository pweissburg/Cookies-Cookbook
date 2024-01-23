
class InputValidator
{
    public int GetValidInput()
    {
        string input;
        do
        {
            Console.WriteLine("Enter your dice roll guess:");
            input = Console.ReadLine();
            if (input == null || !ValidateDiceRollGuess(input))
            {
                Console.WriteLine("Invalid input");
            }


        }
        while (input == null || !ValidateDiceRollGuess(input));
        int.TryParse(input, out int value);
        return value;
    }

    private bool ValidateDiceRollGuess(string input)
    {
        if (int.TryParse(input, out int value))
        {
            switch (value)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6: return true;
                default: return false;
            }
        }
        else return false;
    }
}








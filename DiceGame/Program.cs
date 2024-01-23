
//// system generates a random number
//// user inputs a number
//// evaluate input
//// user has 3 tries to guess what the number is
//// if the user gets it in 3 tries, "You win!" is printed to console
////if user doesn't guess in 3 tries, 'you lose'
//// if guess is wrong, 'wrong number'


//var rnd = new Random();
//int actualRoll = rnd.Next(1, 7);
////int validRolls = 0;
////int invalidRolls = 0;

Console.WriteLine("Hello world");


////get input
////validate the input
//// 1. must be an integer
//// 2. must be between 1 and 6


////if it's not valid, get input again until it is valid
//int attempt = 0;


//bool EvaluateUserInputAndGuess()
//{
//    do
//    {
//        var guess = GetValidInput();
//        if (guess == actualRoll)
//        {
//            return true;
//        }
//        else
//        {
//            Console.WriteLine("Wrong number");
//            attempt++;
//        }
//    }
//    while (attempt < 3);
//    return false;
//}

//int GetValidInput()
//{
//    string input;
//    do
//    {
//        Console.WriteLine("Enter your dice roll guess:");
//        input = Console.ReadLine();


//    }
//    while (input == null || !ValidateDiceRollGuess(input));
//    int.TryParse(input, out int value);
//    return value;
//}

//void PrintDiceRollGuessOutcome(bool guessIsCorrect)

//{
//    if (guessIsCorrect)
//    {
//        Console.WriteLine("You win! :)");
//    }
//    else Console.WriteLine("You lose :(");
//}

//bool ValidateDiceRollGuess(string input)
//{
//    if (int.TryParse(input, out int value))
//    {
//        switch (value)
//        {
//            case 1:
//            case 2:
//            case 3:
//            case 4:
//            case 5:
//            case 6: return true;
//            default: return false;
//        }
//    }
//    else return false;
//}








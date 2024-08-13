Console.Clear();

bool exitGame = false;
List<string> gameHistory = new List<string>();

DisplayGameTitle();

Console.WriteLine("\nWelcome to the Math Game!\n");

// Display menu
while (!exitGame)
{
    if (!(gameHistory.Count == 0))
    {
        Console.Clear();

        DisplayGameTitle();
    }

    Console.WriteLine("\t1. Addition");
    Console.WriteLine("\t2. Subtraction");
    Console.WriteLine("\t3. Multiplication");
    Console.WriteLine("\t4. Division");
    Console.WriteLine("\t5. Display previous games");
    Console.WriteLine("\t6. Exit");

    Console.WriteLine("\nWhat game do you want to play today?");

    var userInput = Console.ReadLine();

    if (userInput != null)
    {
        userInput = userInput.ToString();

        switch (userInput)
        {
            case "1":
                AdditionGame();
                break;

            case "2":
                SubtractionGame();
                break;

            case "3":
                MultiplicationGame();
                break;

            case "4":
                DivisionGame();                
                break;

            case "5":
                DisplayGameHistory();
                break;

            case "6":
                exitGame = true;
                break;

            default:
                Console.WriteLine("Invalid entry.");
                break;
        }
    }

}


// Add
void AdditionGame()
{
    Console.Clear();

    bool exitGame = false;
    string? userInput;
    gameHistory.Add($"{DateTime.Now} - Addition game");

    while (!exitGame)
    {
        // Generate random numbers.
        Random randomInt = new Random();
        var num1 = randomInt.Next(1, 10);
        var num2 = randomInt.Next(1, 10);

        // Display the formula on screen.
        Console.WriteLine($"{num1} + {num2} = ?");

        // Ask user to input answer.
        var userAnswer = Console.ReadLine();
        var actualAnswer = num1 + num2;
        int userAnswerToInt;

        // Validate user input
        while (!(Int32.TryParse(userAnswer, out userAnswerToInt)))
        {

            Console.WriteLine("Enter a number!");
            userAnswer = Console.ReadLine();

        }

        // Check answer
        if (userAnswerToInt == actualAnswer)
        {
            Console.WriteLine("That's right!  Press any key to try another problem.  Press Q to return to main menu.");
            userInput = Console.ReadLine();

            if (userInput != null)
            {
                switch (userInput.ToLower())
                {
                    case "q":
                        exitGame = true;
                        break;

                    default:
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Woops!  Not quite!  The right answer is {0}", actualAnswer);
            Console.WriteLine("Press any key to try another problem.  Press Q to return to main menu.");

            userInput = Console.ReadLine();

            if (userInput != null)
            {
                switch (userInput.ToLower())
                {
                    case "q":
                        exitGame = true;
                        break;

                    default:
                        break;
                }
            }
        }



    }
}

// Subtract
void SubtractionGame()
{
    Console.Clear();

    bool exitGame = false;
    string? userInput;
    gameHistory.Add($"{DateTime.Now} - Subtraction game");

    while (!exitGame)
    {
        // Generate random numbers.
        Random randomInt = new Random();
        var num1 = randomInt.Next(1, 10);
        var num2 = randomInt.Next(1, 10);

        // Display the formula on screen.
        Console.WriteLine($"{num1} - {num2} = ?");

        // Ask user to input answer.
        var userAnswer = Console.ReadLine();
        var actualAnswer = num1 - num2;
        int userAnswerToInt;

        // Validate user input
        while (!(Int32.TryParse(userAnswer, out userAnswerToInt)))
        {

            Console.WriteLine("Enter a number!");
            userAnswer = Console.ReadLine();

        }

        // Check answer
        if (userAnswerToInt == actualAnswer)
        {
            Console.WriteLine("That's right!  Press any key to try another problem.  Press Q to return to main menu.");
            userInput = Console.ReadLine();

            if (userInput != null)
            {
                switch (userInput.ToLower())
                {
                    case "q":
                        exitGame = true;
                        break;

                    default:
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Woops!  Not quite!  The right answer is {0}", actualAnswer);
            Console.WriteLine("Press any key to try another problem.  Press Q to return to main menu.");

            userInput = Console.ReadLine();

            if (userInput != null)
            {
                switch (userInput.ToLower())
                {
                    case "q":
                        exitGame = true;
                        break;

                    default:
                        break;
                }
            }
        }



    }
}
// Multiply
void MultiplicationGame()
{
    Console.Clear();

    bool exitGame = false;
    string? userInput;
    gameHistory.Add($"{DateTime.Now} - Multiplication game");

    while (!exitGame)
    {
        // Generate random numbers.
        Random randomInt = new Random();
        var num1 = randomInt.Next(1, 10);
        var num2 = randomInt.Next(1, 10);

        // Display the formula on screen.
        Console.WriteLine($"{num1} x {num2} = ?");

        // Ask user to input answer.
        var userAnswer = Console.ReadLine();
        var actualAnswer = num1 * num2;
        int userAnswerToInt;

        // Validate user input
        while (!(Int32.TryParse(userAnswer, out userAnswerToInt)))
        {

            Console.WriteLine("Enter a number!");
            userAnswer = Console.ReadLine();

        }

        // Check answer
        if (userAnswerToInt == actualAnswer)
        {
            Console.WriteLine("That's right!  Press any key to try another problem.  Press Q to return to main menu.");
            userInput = Console.ReadLine();

            if (userInput != null)
            {
                switch (userInput.ToLower())
                {
                    case "q":
                        exitGame = true;
                        break;

                    default:
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Woops!  Not quite!  The right answer is {0}", actualAnswer);
            Console.WriteLine("Press any key to try another problem.  Press Q to return to main menu.");

            userInput = Console.ReadLine();

            if (userInput != null)
            {
                switch (userInput.ToLower())
                {
                    case "q":
                        exitGame = true;
                        break;

                    default:
                        break;
                }
            }
        }



    }
}
// Divide
void DivisionGame()
{
    Console.Clear();

    bool exitGame = false;
    string? userInput;
    gameHistory.Add($"{DateTime.Now} - Division game");

    while (!exitGame)
    {
        int dividend;
        int divisor;
        Random randomInt = new Random();

        // Quotient must be whole number.
        do {

        // Generate random dividend and divisor.        
        dividend = randomInt.Next(0, 101);

        // Divisor must be smaller than dividend.
        divisor = randomInt.Next(1, dividend + 1);

        } while (dividend % divisor != 0 || dividend == divisor || divisor == 1);  // Check that remainder of division is zero, dividend and divisor are different numbers, and divisor is not 1 (too easy)



        // Display the formula on screen.
        Console.WriteLine($"{dividend} / {divisor} = ?");

        // Ask user to input answer.
        var userAnswer = Console.ReadLine();
        var actualAnswer = dividend / divisor;
        int userAnswerToInt;

        // Validate user input
        while (!(Int32.TryParse(userAnswer, out userAnswerToInt)))
        {

            Console.WriteLine("Enter a number!");
            userAnswer = Console.ReadLine();

        }

        // Check answer
        if (userAnswerToInt == actualAnswer)
        {
            Console.WriteLine("That's right!  Press any key to try another problem.  Press Q to return to main menu.");
            userInput = Console.ReadLine();

            if (userInput != null)
            {
                switch (userInput.ToLower())
                {
                    case "q":
                        exitGame = true;
                        break;

                    default:
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Woops!  Not quite!  The right answer is {0}", actualAnswer);
            Console.WriteLine("Press any key to try another problem.  Press Q to return to main menu.");

            userInput = Console.ReadLine();

            if (userInput != null)
            {
                switch (userInput.ToLower())
                {
                    case "q":
                        exitGame = true;
                        break;

                    default:
                        break;
                }
            }
        }



    }
}

// Display previous games
void DisplayGameHistory()
{
    Console.Clear();

    foreach (var game in gameHistory)
    {
        Console.WriteLine(game);
    }

    Console.WriteLine("\nPress Enter to return to menu.");
    Console.ReadLine();
}

// Display Game Title
void DisplayGameTitle()
{
    // Verbatim string literal https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/verbatim
    // ASCII Art Generator https://patorjk.com/software/taag/#p=display&f=Bubble&t=The%20Math%20Game
    Console.WriteLine(@"   _   _   _     _   _   _   _     _   _   _   _  
  / \ / \ / \   / \ / \ / \ / \   / \ / \ / \ / \ 
 ( T | h | e ) ( M | a | t | h ) ( G | a | m | e )
  \_/ \_/ \_/   \_/ \_/ \_/ \_/   \_/ \_/ \_/ \_/ ");

    Console.WriteLine();
}
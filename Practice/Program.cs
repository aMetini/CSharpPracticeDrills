// See https://aka.ms/new-console-template for more information

// Problem 1

//Console.WriteLine("What is your name?");

//var input = Console.ReadLine();
//if (input == null)
//{
//    Console.WriteLine("Please input an answer.");
//}
//else if(input == "David")
//{
//    Console.WriteLine("Hey David");
//}
//else
//{
//    Console.WriteLine("Hey and welcome!");
//}
//Console.Read();

// Problem 2
//Console.WriteLine("Please guess the secret password.");
//var passcode = Console.ReadLine();
//var secretPasscode = "CAGirl1981";

//if (passcode == secretPasscode)
//{
//    Console.WriteLine("Congratulations! You have guessed the correct password!");
//}
//else
//{
//    Console.WriteLine("Sorry, you did not guess the correct secret password. Try again!");
//}

//Console.Read();

// Problem 3
//Console.WriteLine("Please enter a number.");
//var input = Convert.ToInt32(Console.ReadLine());

//if (input < 100 || input > 100)
//{
//    Console.WriteLine($"Your number was {input}");
//}
//else
//{
//    if (input == 100)
//    {
//        Console.WriteLine($"Your number was {input}");
//    }
//}
//Console.Read();

//// Problem 4
//Console.WriteLine("Please enter your name.");
//var nameInput = Console.ReadLine();
//Console.WriteLine("Please indicate a number");
//var numberInput = Convert.ToInt32(Console.ReadLine());
//// Use for loop which will indicate the CW Greeting the number of times of numberInput(limit)
//for (int i = 0; i < numberInput; i++)
//{
//    Console.WriteLine($"Hej {nameInput}");
//}

//// Problem 5
//int sum = 0;
//// Keep count of the number of entries made in order to find the average later
//var counter = 0;
//// This is a while loop
//bool loop = false;

//Console.WriteLine("Please enter a number.  If you want to stop the program and see the result, please press Enter");
//while (!loop)
//{
//    // TryParse will convert a string representation of a number to its int value
//    var input = Console.ReadLine();
//    try
//    {
//        if (int.TryParse(input, out var number))
//        {
//            sum += number;
//            counter++;
//            Console.WriteLine($"The sum is {sum}");
//        }
//        else
//        {
//            if (input == "")
//            {
//                Console.WriteLine($"The average number of all sums is: {sum / counter}");
//            }
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Exception: You have chosen to exit this program", ex);
//    }
//}

// Problem 6
//Console.WriteLine("Please enter a number.");
//var numberInput1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please enter a mathmatical operation: +, -, *");
//var operationInput = Console.ReadLine();

//Console.WriteLine("Please enter a number.");
//var numberInput2 = Convert.ToInt32(Console.ReadLine());

//if (operationInput == "+")
//{
//    Console.WriteLine($"The sum of both numbers is: {numberInput1 + numberInput2}");
//}
//else if (operationInput == "-")
//{
//    Console.WriteLine($"The difference of both numbers is: {numberInput1 - numberInput2}");
//}
//else if (operationInput == "*")
//{
//    Console.WriteLine($"The product of both numbers is: {numberInput1 * numberInput2}");
//}
//Console.ReadKey();

// Problem 7
//Console.WriteLine("Please enter a month");
//var monthInput = Console.ReadLine();
//switch (monthInput)
//{
//    case "January":
//        Console.WriteLine("You entered January-month 1");
//        break;
//    case "February":
//        Console.WriteLine("You entered February-month 2");
//        break;
//    case "March":
//        Console.WriteLine("You entered March-month 3");
//        break;
//    case "April":
//        Console.WriteLine("You entered April-month 4");
//        break;
//    case "May":
//        Console.WriteLine("You entered May-month 5");
//        break;
//    case "June":
//        Console.WriteLine("You entered June-month 6");
//        break;
//    case "July":
//        Console.WriteLine("You entered July-month 7");
//        break;
//    case "August":
//        Console.WriteLine("You entered August-month 8");
//        break;
//    case "September":
//        Console.WriteLine("You entered September-month 9");
//        break;
//    case "October":
//        Console.WriteLine("You entered October-month 10");
//        break;
//    case "November":
//        Console.WriteLine("You entered November-month 11");
//        break;
//    case "December":
//        Console.WriteLine("You entered December-month 12");
//        break;
//    default:
//        Console.WriteLine("You did not indicate a month.");
//        break;

//        Console.Read();
//}

//try
//{
//    string[] monthsArray = new string[] { "Invalid month", "January", "February", "March", "April", "May",
//                                    "June", "July", "August", "September", "October", "November", "December"};

//    Console.WriteLine("Please enter a month as a number");
//    var inputMonth = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine(monthsArray[inputMonth]);
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Invalid month entered. Please try again.", ex.Message);
//}

//// Problem 8
//var number = 1;

//for (var i = 0; i < 16; i++)
//{
//    number = i * i;
//    Console.WriteLine(number);
//}

// Problem 9
//Random random = new Random();
//var secretNo = random.Next(1, 100);

//Console.WriteLine("Enter a number between 1-100.");
//var inputNo = Convert.ToInt32(Console.ReadLine());

//while (inputNo != secretNo)
//{
//    if (inputNo > secretNo)
//    {
//        Console.WriteLine("You have guessed too high.  Please try again.");
//        inputNo = Convert.ToInt32(Console.ReadLine());
//    }
//    else
//    {
//        if (inputNo < secretNo)
//        {
//            Console.WriteLine("You have guessed too low.  Please try again.");
//            inputNo = Convert.ToInt32(Console.ReadLine());
//        } 
//    }
//}
//Console.WriteLine("Congratulations!  You have successfully guessed the secret number!");
//Console.Read();

//var gameRoundLoop = true;
//var playersPoints = 0;
//var computersPoints = 0;

//while (gameRoundLoop)
//{
//    Console.WriteLine("Choose: \n1 Rock \n2 Paper \n3 Scissors.");
//    //string[] moves = new string[] { "Rock", "Paper", "Scissors" };

//    var playersMove = Console.ReadLine();

//    Random random = new Random();
//    var computersMove = random.Next(1, 3);

//    switch (computersMove)
//    {
//        case 1:
//            computersMove = 1;
//            Console.WriteLine("Computer chose Rock");
//            if (playersMove == "1")
//            {
//                Console.WriteLine("Both chose Rock.  It is a tie.");
//            }
//            else if (playersMove == "3")
//            {
//                Console.WriteLine("You chose Scissors while Computer chose Rock. You lose.");
//                computersPoints++;
//            }
//            else if (playersMove == "2")
//            {
//                Console.WriteLine("You chose Paper while Computer chose Rock. You win!");
//                playersPoints++;
//            }
//            break;

//        case 2:
//            computersMove = 2;
//            Console.WriteLine("Computer chose Paper");
//            if (playersMove == "2")
//            {
//                Console.WriteLine("Both chose Paper.  It is a tie.");
//            }
//            else if (playersMove == "1")
//            {
//                Console.WriteLine("You chose Rock while Computer chose Paper. You lose");
//                computersPoints++;
//            }
//            else if (playersMove == "3")
//            {
//                Console.WriteLine("You chose Scissors while Computer chose Paper. You win!");
//                playersPoints++;
//            }
//            break;

//        case 3:
//            computersMove = 3;
//            Console.WriteLine("Computer chose Scissors");
//            if (playersMove == "3")
//            {
//                Console.WriteLine("Both chose Paper.  It is a tie.");
//            }
//            else if (playersMove == "1")
//            {
//                Console.WriteLine("You chose Paper while Computer chose Scissors. You lose");
//                computersPoints++;
//            }
//            else if (playersMove == "2")
//            {
//                Console.WriteLine("You chose Rock while Computer chose Scissors. You win!");
//                playersPoints++;
//            }
//            break;

//        //default:
//        //    {
//        //        Console.WriteLine("Invalid entry. Please try again.");
//        //        break;
//        //    }
//    }
//    Console.WriteLine("Would you like to play again?");
//    Console.WriteLine("Please enter Y or N");
//    var playerResp = Console.ReadLine();

//    if (playerResp == "N" || playerResp == "n")
//    {
//        gameRoundLoop = false;
//        Console.WriteLine($"Player has {playersPoints} points - Computer has {computersPoints} points.");
//    }
//}

// Problem 10
//var greeting = "Hej";

//for (var i = 0; i < greeting.Length; i++)
//{
//    Console.WriteLine(greeting[i]);
//}
//Console.WriteLine("Please enter a word to see what happens!");
//var wordInput = Console.ReadLine(); 

//for (int i = 0; i < wordInput.Length; i++)
//{
//    Console.WriteLine(wordInput[i]);
//}

// Problem 11
//string[] numbers = new string[] { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

//Console.WriteLine("Please enter a number between 1-9 to see it in Swedish.");
//var inputNo = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(numbers[inputNo]);



// Problem 12

// Problem 13
//Console.WriteLine("Please enter your text");
//var textInput = Console.ReadLine();

//// Use a Linq query and the new string function to make a new string from final text that will be reversed. 
//var finalText = string.Join(" ", textInput.Split(' ').Select(s => new string(s.Reverse().ToArray())));
//Console.WriteLine($"Your text in reverse: {finalText}");

// Problem 14
//Console.WriteLine("Please enter your text");
//var textInput = Console.ReadLine();
//// HashSet is an unordered collection of unique elements.
//// It supports the implementation of sets and uses the hash table for storage.
//// This collection is of the generic type collection and it is defined under System.
//var letters = new HashSet<char>(textInput);
//// Use the ExceptWith command to remove vowels in string
//letters.ExceptWith("AaEeIiOoUu");
//Console.WriteLine($"Your text without vowels is: ");
//foreach (var letter in letters)
//{
//    Console.WriteLine(letter);
//}

// Using RegEx
//using System.Text.RegularExpressions;

//Console.WriteLine("Please enter your text");
//var textInput = Console.ReadLine();

//textInput = Regex.Replace(textInput, "[aeiou]", "", RegexOptions.IgnoreCase);

//Console.WriteLine($"Your text without vowels is: ");
//Console.WriteLine(textInput);

// Using only Linq in a new string
//var vowels = "AaEeIiOoUu";

//Console.WriteLine("Please enter your text");
//var textInput = Console.ReadLine();

//textInput = new string(textInput.Where(c => !vowels.Contains(c)).ToArray());
//Console.WriteLine($"Your text without vowels is: ");
//Console.WriteLine(textInput);

// Problem 15
string revInput;
bool IsPalindrome;

Console.WriteLine("Please enter a word");
var inputText = Console.ReadLine();
char[] chLetters = inputText.ToCharArray();
Array.Reverse(chLetters);
revInput = new string(chLetters);
IsPalindrome = inputText.Equals(revInput, StringComparison.OrdinalIgnoreCase);

if (IsPalindrome == true)
{
    Console.WriteLine($"This text input {inputText} is a Palindrome.");
}
else
{
    Console.WriteLine($"This text input {inputText} is NOT a Palindrome.");
}
Console.ReadKey();






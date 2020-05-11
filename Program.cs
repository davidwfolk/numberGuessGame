using System;
using System.Collections.Generic;

namespace numberguessgame
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      //   short number = 22222;
      //   int secondNumber = 222222222; //most commonly used
      //   long thirdNumber = 9223372036854775807;
      //   ulong anotherNumber = 22222222222222222;
      //   float floatNumber = 2.5f; //most commonly used decimal
      //   double decimalNumber = 2.5;
      //   decimal money = 2.5m; //more precise
      //   bool valid = true;
      //   string name = "Darryl";
      //   char firstLetter = 'd';
      //   var letter = 'd';
      //   string singleLetterString = "s";
      //   Car redCar = new Car();
      //   Car[] cars = new Car[4];
      //   cars[0] = redCar;
      //   int[] integers = new int[] { 0, 1, 2, 3 };
      //   integers[1] = 10;

      //   List<Car> myCars = new List<Car>();
      //   myCars.Add(redCar);
      //   myCars.Remove(redCar);
      //   myCars.RemoveAt(0);

      System.Console.WriteLine("Would you like to play a number guessing game? Y/N");
      string userInput = Console.ReadLine();
      bool playing = userInput.ToLower() == "y";
      Random random = new Random();
      int numberToGuess = random.Next(1, 10);
      int numberOfGuesses = 3;
      while (playing)
      {
        if (numberOfGuesses < 1)
        {
          System.Console.WriteLine("You Lost! Do you want to play again? Y/N");
          string choice = Console.ReadLine();
          if (choice.ToLower() == "y")
          {
            numberOfGuesses = 3;
            numberToGuess = random.Next(1, 10);
          }
          else
          {
            playing = false;
          }
          continue;
        }
        numberOfGuesses--;
        System.Console.WriteLine("Guess a number between 1 and 10");
        string guess = Console.ReadLine();
        int guessedNumber;
        if (!int.TryParse(guess, out guessedNumber) || guessedNumber > 10 || guessedNumber < 1)
        {
          System.Console.WriteLine("Not a valid number");
          continue;
        }
        if (guessedNumber == numberToGuess)
        {
          System.Console.WriteLine("You won! Do you want to play again? Y/N");
          string continueGame = Console.ReadLine();
          if (continueGame.ToLower() == "y")
          {
            numberToGuess = random.Next(1, 10);
          }
          else
          {
            playing = false;
          }
          continue;
        }
        else if (guessedNumber > numberToGuess)
        {
          System.Console.WriteLine("Your guess was too high");
        }
        else if (guessedNumber < numberToGuess)
        {
          System.Console.WriteLine("You guessed too low");
        }
      }
      System.Console.WriteLine("Thanks for playing!");
    }
  }

  public class Car
  {
    public string Color { get; set; }
  }
}
using System;
using Bakery.Models;

namespace CounterProgram
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Hello! Welcome to Pierre's Bakery.");
      Console.WriteLine("Today's menu prices are:");
      Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Bread  - $5.00 per loaf");
      Console.WriteLine("Pastry - $2.00 each");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("We are currently running these specials:");
      Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Bread: Buy 2 loaves, get 1 free!");
      Console.WriteLine("Pastries: 3 for $5!");
      OrderType();
    }

    public static void OrderType()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine();
      Console.WriteLine("What would you like to order? [Bread/Pastry]");
      Console.ForegroundColor = ConsoleColor.Blue;
      string userOrderChoice = Console.ReadLine().ToLower();
      if (userOrderChoice == "bread")
      {
        OrderBread();
      }
      else if (userOrderChoice == "pastry")
      {
        OrderPastry();
      }
      else
      {
        Console.WriteLine("Please enter a valid response");
        Console.WriteLine();
        OrderType();
      }
    }

    public static void OrderBread()
    {
      try
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine("How many loaves of bread would you like?");
        Console.ForegroundColor = ConsoleColor.Blue;
        string loavesOrderedString = Console.ReadLine();
        int loavesOrdered = int.Parse(loavesOrderedString);
        Bread userBread = new Bread(loavesOrdered);
      }
      catch (Exception)
      {
        Console.WriteLine("Please enter a valid number");
        OrderBread();
      }
      DoNextQuestion();
    }
    public static void DoNextQuestion()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine();
      Console.WriteLine("Would you like to add to your order? [Yes/No]");
      Console.ForegroundColor = ConsoleColor.Blue;
      string userAddToOrderAnswer = Console.ReadLine().ToLower();
      if (userAddToOrderAnswer == "yes")
      {
        OrderType();
      }
      else if (userAddToOrderAnswer == "no")
      {
        // CalculateTotal();
      }
      else
      {
        Console.WriteLine("Please enter a valid response");
        DoNextQuestion();
      }
    }
    public static void OrderPastry()
    {
      try
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine("How many pastries would you like?");
        Console.ForegroundColor = ConsoleColor.Blue;
        string pastriesOrderedString = Console.ReadLine();
        int pastriesOrdered = int.Parse(pastriesOrderedString);
        Pastry userPastry = new Pastry(pastriesOrdered);
      }
      catch (Exception)
      {
        Console.WriteLine("Please enter a valid number");
        OrderPastry();
      }
      DoNextQuestion();
    }

    public static void CalculateTotal()
    {

    }
  }
}




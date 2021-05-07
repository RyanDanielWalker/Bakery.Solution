using System;
using Bakery.Models;

namespace CounterProgram
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Hello! Welcome to Pierre's Bakery.");
      Console.WriteLine("Today's menu prices are:");
      Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Bread  - $5.00 per loaf");
      Console.WriteLine("Pastry - $2.00 each");
      Console.WriteLine("                                ");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("We are currently running these specials:");
      Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Bread: Buy 2 loaves, get 1 free!");
      Console.WriteLine("Pastries: 3 for $5!");






    }
  }
}

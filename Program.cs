using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lexicon_Ovning_2;

internal class Program
{
  private static void Main(string[] args)
  {
    bool exit = false;

    while (!exit)
    {
      Console.WriteLine("\n***  MAIN MENU  ***");
      Console.WriteLine("Navigate by entering the number corresponding to the desired option.");
      Console.WriteLine("");
      Console.WriteLine("1. Cinema menu");
      Console.WriteLine("2. Repeat text ten times");
      Console.WriteLine("3. Find the third word");
      Console.WriteLine("0. Exit");
      Console.WriteLine("");
      Console.Write("Please enter your choice: ");

      string? choice = Console.ReadLine();
      Console.Clear();

      switch (choice)
      {
        case "0":
          Console.WriteLine("***  Goodbye!  ***");
          exit = true;
          break;
        case "1":
          Cinema.CinemaMenu();
          break;
        case "2":
          RepeatText.RepeatTextTenTimes();
          break;
        case "3":
          FindWord.FindThirdWord();
          break;
        default:
          Console.WriteLine("Invalid choice. Please try again.");
          break;
      }
    }
  }
}

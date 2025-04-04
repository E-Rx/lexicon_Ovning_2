using System;
using System.Diagnostics;

namespace lexicon_Ovning_2;
public class Cinema
{
  // Const for the different ticket prices.
  private const int ChildSeniorTicketPrice= 0;
  private const int YouthTicketPrice = 80;
  private const int AdultTicketPrice = 120;
  private const int SeniorTicketPrice = 90;

  // Method for the Cinema menu.
  public static void CinemaMenu()
  {
    bool exitCinemaMenu = false;

    while (!exitCinemaMenu)
    {
      Console.WriteLine("\n***  CINEMA MENU  ***");
      Console.WriteLine("");
      Console.WriteLine("1: See ticket prices");
      Console.WriteLine("2: Calculate group price");
      Console.WriteLine("0: Return to main menu");
      Console.WriteLine("");
      Console.Write("Please enter your choice: ");

      string? choice = Console.ReadLine();
      Console.Clear();


      switch (choice)
      {
        case "0":
          Console.WriteLine("***  Returning to main menu  ***");
          exitCinemaMenu = true;
          break;
        case "1":
          ShowTicketPrices();
          break;
        case "2":
          CalculateGroupPrice();
          break;
          default:
          Console.WriteLine("Invalid input! Please try again.");
          Console.WriteLine("Press any key to continue...");
          Console.ReadKey();
          break;
      }
    }
  }

  // Method to show ticket prices.
  private static void ShowTicketPrices()
  {
    Console.Write("Enter the person's age: ");
      if (int.TryParse(Console.ReadLine(), out int age))
      {
        Console.WriteLine($"Ticket price: {GetTicketPrice(age)}kr");
      }
      else
      {
        Console.WriteLine("Invalid input! Please enter a valid age.");
      }
  }

  // Method to get the ticket price based on age.
  public static int GetTicketPrice(int age)
  {
    if (age < 5 || age > 100)
      return ChildSeniorTicketPrice;
    else if (age < 20)
      return YouthTicketPrice;
    else if (age > 64)
      return SeniorTicketPrice;
    else
      return AdultTicketPrice;
  }


  // Method to calculate the group price based on the number of people.
  public static void CalculateGroupPrice()
  {
    Console.Write("Enter number of people in the group: ");
    if (int.TryParse(Console.ReadLine(), out int numberOfPeople) && numberOfPeople > 0)
    {
      ProcessGroupMembers(numberOfPeople);
    }
    else
    {
      Console.WriteLine("Invalid input! Please enter a valid number.");
    }
  }

  // Method to process group members and calculate total price.
  private static void ProcessGroupMembers(int numberOfPeople)
  {
    int totalPrice = 0;

      for (int i = 0; i < numberOfPeople; i++)
      {
        int age;
        while (true)
        {
          Console.Write($"Enter age of person {i + 1}: ");
          if (int.TryParse(Console.ReadLine(), out age))
          {
            break;
          }
          Console.WriteLine("Invalid age! Please enter a valid number.");
        }

        int price = GetTicketPrice(age);
        Console.WriteLine($"Person {i + 1} (Age {age}): {price}kr");
        totalPrice += price;
      }

        Console.WriteLine($"\nTotal group cost: {totalPrice}kr for {numberOfPeople} people.");
  }
}

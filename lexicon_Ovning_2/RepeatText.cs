using System;

namespace lexicon_Ovning_2;

public class RepeatText
{

  public static void RepeatTextTenTimes()
  {
    /// Method to repeat a text ten times
    Console.WriteLine("*** REPEAT TEXT TEN TIMES ***");

    Console.Write("Please enter text to repeat: ");
    string? text = Console.ReadLine();

    Console.WriteLine("\nHere is your text repeated ten times:");

    // loop to repeat the text ten times
    for (int i = 1; i <= 10; i++)
    {
        //Console.Write($"{i}. {text}, ");
        Console.Write($"{text} ");
    }
    Console.WriteLine(" ");
  }
}

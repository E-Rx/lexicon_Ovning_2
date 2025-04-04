using System;

namespace lexicon_Ovning_2;

public class FindWord
{

    // Method to find the third word in that sentence.
    public static void FindThirdWord()
  {
    Console.WriteLine("*** FIND THE THIRD WORD ***");
    Console.WriteLine("");
    Console.Write("Please enter a sentence with at least three words: ");
    string? sentence = Console.ReadLine();

    if (string.IsNullOrEmpty(sentence))
    {
        Console.WriteLine("Invalid input. Please enter a valid sentence.");
    }

    string[] words = sentence?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

    if (words.Length >= 3)
    {
      Console.WriteLine($"The third word is: \"{words[2]}\"");
    }
    else
    {
      Console.WriteLine("The sentence does not contain three words. Please try again.");

    }
  }
}

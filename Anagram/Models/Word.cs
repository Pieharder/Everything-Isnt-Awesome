using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class Word
  {
    public bool IsAWord(string userInput)
    {
      if (userInput == "Test")
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    // public string[] arrWords = { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

    List<string> pleaseBeGoodlist = new List<string>(new string[] { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" });

    public bool IsAnArray(List.pleaseBeGoodlist)
    {
      if ()
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
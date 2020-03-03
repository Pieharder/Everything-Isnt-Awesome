using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class WordTests
  {

    [TestMethod]
    public void IsAWord_UserInputIsAWord_True()
    {
      Word newWord = new Word();
      Assert.AreEqual(true, newWord.IsAWord("Test"));
    }

    [TestMethod]
    public void IsAList_UserWordsAreAList_True()
    {
      Word newWords = new Word();
      Assert.AreEqual(true, newWords.IsAnArray());
    }
  }
}
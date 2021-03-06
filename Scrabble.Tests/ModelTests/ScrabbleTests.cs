using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.TestTools
{
  [TestClass]
  public class WordTests
  {
    // [TestMethod]
    // public void Word_TurnToCharArray_WordCharArray()
    // {
    //   char[] expected = new char[] { 'c','a','t' };
    //   Word newWord = new Word("cat");
    //   char[] result = newWord.BreakToArray();
    //   CollectionAssert.AreEqual(expected, result);
    // }
    [TestMethod]
    public void Word_ReturnValueOfWord_Number()
    {
      Word newWord = new Word("net");
      int result = newWord.ReturnValue();
      CollectionAssert.AreEqual(3, result);
    }
  } 
}
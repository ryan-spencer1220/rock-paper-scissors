using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RockPaperScissorsTests
  {
    [TestMethod]
    public void GameConstructor_CreateInstanceOfGame_String()
    {
      Game newGame = new Game("Rock", "Scissors");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }
    [TestMethod]
    public void DetermineWinner_CheckIfRockBeatsScissors_String()
    {
      Game winner = new Game("Rock", "Scissors");
      Assert.AreEqual("Player One Wins!", winner.DetermineWinner());
    }

    [TestMethod]
    public void DetermineWinner_CheckIfPaperBeatsRock_String()
    {
      Game winner = new Game("Rock", "Paper");
      Assert.AreEqual("Player Two Wins!", winner.DetermineWinner());
    } 

    [TestMethod]
    public void DetermineWinner_CheckIfScissorsBeatsPaper_String()
    {
      Game winner = new Game("Paper", "Scissors");
      Assert.AreEqual("Player Two Wins!", winner.DetermineWinner());
    }

    [TestMethod]
    public void DetermineWinner_CheckForTie_String()
    {
      Game winner = new Game("Paper", "Paper");
      Assert.AreEqual("It's A Draw!", winner.DetermineWinner());
    }
  }
}
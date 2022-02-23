using System;
using RockPaperScissors.Models;

namespace RockPaperScissorsInterface {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello! Would you like to play a game?");
      Console.WriteLine("Player One, please select from the following options: Rock, Paper, Scissors!");
      string playerOneSelection = Console.ReadLine();
      Console.WriteLine("Player Two, please select from the following options: Rock, Paper, Scissors!");
      string playerTwoSelection = Console.ReadLine();

      Game currentGame = new Game(playerOneSelection, playerTwoSelection);

      Console.WriteLine(currentGame.DetermineWinner(playerOneSelection, playerTwoSelection));
      Main();
    }
  }
}
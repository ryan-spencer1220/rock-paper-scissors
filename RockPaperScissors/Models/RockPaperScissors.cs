using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class Game
  {
    private string _playerOne;
    private string _playerTwo;

    public Game(string playerOne, string playerTwo)
    {
      _playerOne = playerOne;
      _playerTwo = playerTwo;
    }

    public string DetermineWinner(string playerOneSelection, string playerTwoSelection)
    {
      if(_playerOne == "Rock" && _playerTwo == "Scissors")
      {
        return "Player One Wins!";
      }
      else if(_playerOne == "Scissors" && _playerTwo == "Rock")
      {
        return "Player Two Wins!";
      }
      else if(_playerOne == "Rock" && _playerTwo == "Paper")
      {
        return "Player Two Wins!";
      }
      else if(_playerOne == "Paper" && _playerTwo == "Rock")
      {
        return "Player One Wins!";
      }
      else if(_playerOne == "Paper" && _playerTwo == "Scissors")
      {
        return "Player Two Wins!";
      }
      else if(_playerOne == "Scissors" && _playerTwo == "Paper")
      {
        return "Player One Wins!";
      }
      else if(_playerOne == _playerTwo)
      {
        return "It's A Draw!";
      }
      else
      {
        return "Please enter either Rock, Paper, or Scissors!";
      }
    }
  }
}
using System;
using TicTacToe.Data;
using TicTacToe.Model;

namespace TicTacToe
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(Marker marker) : base(marker)
        {
        }

        protected override Position GetPosition(GameBoard gameBoard)
        {
            var availablePositions = gameBoard.GetAvailableSlotPositions();
            var index = new Random().Next(0, availablePositions.Count);
            return availablePositions[index];
        }
    }
}
using System;
using TicTacToe.Model;

namespace TicTacToe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var game = new Game(new ConsolePlayer(Marker.O), new ComputerPlayer(Marker.X));
            try
            {
                game.PlayInfinite();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}
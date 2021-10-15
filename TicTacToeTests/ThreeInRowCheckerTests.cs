using TicTacToe;
using TicTacToe.Data;
using TicTacToe.Model;
using Xunit;

namespace TicTacToeTests
{
    public class ThreeInRowCheckerTests
    {
        [Fact]
        public void VerticalLeftTest()
        {
            var gameBoard = new GameBoard();
            const Marker marker = Marker.O;
            const bool expected = true;
            var threeInRowChecker = ThreeInRowChecker.Create();
            gameBoard.PlaceMarker(Position.Top, Position.Left, marker);
            gameBoard.PlaceMarker(Position.Center, Position.Left, marker);
            gameBoard.PlaceMarker(Position.Bottom, Position.Left, marker);

            var actual = threeInRowChecker.Check(gameBoard, marker);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void VerticalCenterTest()
        {
            var gameBoard = new GameBoard();

            const Marker marker = Marker.O;
            const bool expected = true;
            var threeInRowChecker = ThreeInRowChecker.Create();
            gameBoard.PlaceMarker(Position.Top, Position.Center, marker);
            gameBoard.PlaceMarker(Position.Center, Position.Center, marker);
            gameBoard.PlaceMarker(Position.Bottom, Position.Center, marker);


            var actual = threeInRowChecker.Check(gameBoard, marker);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void VerticalRightTest()
        {
            var gameBoard = new GameBoard();

            const Marker marker = Marker.O;
            const bool expected = true;
            var threeInRowChecker = ThreeInRowChecker.Create();
            gameBoard.PlaceMarker(Position.Top, Position.Right, marker);
            gameBoard.PlaceMarker(Position.Center, Position.Right, marker);
            gameBoard.PlaceMarker(Position.Bottom, Position.Right, marker);


            var actual = threeInRowChecker.Check(gameBoard, marker);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HorizontalTopTest()
        {
            var gameBoard = new GameBoard();
            const Marker marker = Marker.O;
            const bool expected = true;
            var threeInRowChecker = ThreeInRowChecker.Create();
            gameBoard.PlaceMarker(Position.Top, Position.Left, marker);
            gameBoard.PlaceMarker(Position.Top, Position.Center, marker);
            gameBoard.PlaceMarker(Position.Top, Position.Right, marker);


            var actual = threeInRowChecker.Check(gameBoard, marker);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HorizontalCenterTest()
        {
            var gameBoard = new GameBoard();
            const Marker marker = Marker.O;
            const bool expected = true;
            var threeInRowChecker = ThreeInRowChecker.Create();
            gameBoard.PlaceMarker(Position.Center, Position.Left, marker);
            gameBoard.PlaceMarker(Position.Center, Position.Center, marker);
            gameBoard.PlaceMarker(Position.Center, Position.Right, marker);


            var actual = threeInRowChecker.Check(gameBoard, marker);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HorizontalBottomTest()
        {
            var gameBoard = new GameBoard();
            const Marker marker = Marker.O;
            const bool expected = true;
            var threeInRowChecker = ThreeInRowChecker.Create();
            gameBoard.PlaceMarker(Position.Bottom, Position.Left, marker);
            gameBoard.PlaceMarker(Position.Bottom, Position.Center, marker);
            gameBoard.PlaceMarker(Position.Bottom, Position.Right, marker);


            var actual = threeInRowChecker.Check(gameBoard, marker);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DiagonalTopLeftToBottomRightTest()
        {
            var gameBoard = new GameBoard();

            const Marker marker = Marker.O;
            const bool expected = true;
            var threeInRowChecker = ThreeInRowChecker.Create();
            gameBoard.PlaceMarker(Position.Top, Position.Left, marker);
            gameBoard.PlaceMarker(Position.Center, Position.Center, marker);
            gameBoard.PlaceMarker(Position.Bottom, Position.Right, marker);


            var actual = threeInRowChecker.Check(gameBoard, marker);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DiagonalBottomLeftToTopRightTest()
        {
            var gameBoard = new GameBoard();

            const Marker marker = Marker.O;
            const bool expected = true;
            var threeInRowChecker = ThreeInRowChecker.Create();
            gameBoard.PlaceMarker(Position.Bottom, Position.Left, marker);
            gameBoard.PlaceMarker(Position.Center, Position.Center, marker);
            gameBoard.PlaceMarker(Position.Top, Position.Right, marker);


            var actual = threeInRowChecker.Check(gameBoard, marker);
            Assert.Equal(expected, actual);
        }
    }
}
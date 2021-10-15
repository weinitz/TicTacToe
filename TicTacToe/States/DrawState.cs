using System;

namespace TicTacToe.States
{
    public class DrawState : GameState
    {
        public override void Play(Game game)
        {
            game.SetState(game.GameOverState);
            Console.ReadKey();
        }

        public override string Render(Game game)
        {
            return
                @"
    ___                    
   /   \_ __ __ ___      __
  / /\ / '__/ _` \ \ /\ / /
 / /_//| | | (_| |\ V  V / 
/___,' |_|  \__,_| \_/\_/  
                           
";
        }
    }
}
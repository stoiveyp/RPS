using System;

namespace RPS.Net
{
    public class Turn<TShape> where TShape:IShape
    {
        public Turn(){}

        public Turn(TShape player1, TShape player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public TShape Player1 { get; set; }
        public TShape Player2 { get; set; }

        public Winner Result()
        {
            if (Player1.CompareTo(Player2) == 0)
            {
                return Winner.Draw;
            }

            return Player1.CompareTo(Player2) > 0 ? Winner.Player1 : Winner.Player2;
        }
    }
}

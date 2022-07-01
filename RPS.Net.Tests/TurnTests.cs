using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPS.Net.Shapes;

namespace RPS.Net.Tests
{
    public class TurnTests
    {
        [Fact]
        public void NoResultIfUnplayedTurn()
        {
            var turn = new Turn<Standard>(Standard.Rock(), null);
            Assert.Null(turn.Result());
        }

        [Fact]
        public void DrawResult()
        {
            var turn = new Turn<Standard>(Standard.Rock(),Standard.Rock());
            Assert.Equal(Winner.Draw,turn.Result());
        }

        [Fact]
        public void Player1Wins()
        {
            var turn = new Turn<Standard>(Standard.Rock(), Standard.Scissors());
            Assert.Equal(Winner.Player1, turn.Result());
        }

        [Fact]
        public void Player2Wins()
        {
            var turn = new Turn<Standard>(Standard.Rock(), Standard.Paper());
            Assert.Equal(Winner.Player2, turn.Result());
        }
    }
}

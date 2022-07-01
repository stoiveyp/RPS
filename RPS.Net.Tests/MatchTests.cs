using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPS.Net.Shapes;

namespace RPS.Net.Tests
{
    public class MatchTests
    {
        [Fact]
        public void NoResultIfNoTurns()
        {
            var match = new Match<Standard>();
            Assert.Null(match.Result());
        }

        [Fact]
        public void DrawResult()
        {
            var match = new Match<Standard>(
                new Turn<Standard>(Standard.Rock(), Standard.Paper()),
                new Turn<Standard>(Standard.Rock(), Standard.Scissors()),
                new Turn<Standard>(Standard.Rock(), Standard.Rock())
                );
            Assert.Equal(Winner.Draw, match.Result());
        }

        [Fact]
        public void Player2Wins()
        {
            var match = new Match<Standard>(
                new Turn<Standard>(Standard.Rock(), Standard.Paper()),
                new Turn<Standard>(Standard.Paper(), Standard.Scissors()),
                new Turn<Standard>(Standard.Rock(), Standard.Rock())
            );
            Assert.Equal(Winner.Player2, match.Result());
        }

        [Fact]
        public void Player1Wins()
        {
            var match = new Match<Standard>(
                new Turn<Standard>(Standard.Rock(), Standard.Scissors()),
                new Turn<Standard>(Standard.Rock(), Standard.Scissors()),
                new Turn<Standard>(Standard.Rock(), Standard.Rock())
            );
            Assert.Equal(Winner.Player1, match.Result());
        }
    }
}

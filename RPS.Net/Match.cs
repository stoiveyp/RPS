using System.Collections.Generic;
using System.Linq;

namespace RPS.Net
{
    public class Match<TShape> where TShape:class, IShape
    {
        public string? Player1 { get; set; }
        public string? Player2 { get; set; }
        private IList<Turn<TShape>> Turns { get; set; } = new List<Turn<TShape>>();

        public Match(){}

        public Match(params Turn<TShape>[] turns)
        {
            Turns = turns.ToList();
        }

        public Match(string player1, string player2, params Turn<TShape>[] turns):this(turns)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public Winner? Result()
        {
            if (!Turns?.Any() ?? false)
            {
                return null;
            }

            if (Turns.Any(t => t.Result() == null))
            {
                return null;
            }

            var results = Turns.Select(t => t.Result());
            var p1 = results.Count(w => w == Winner.Player1);
            var p2 = results.Count(w => w == Winner.Player2);
            if (p1 > p2)
            {
                return Winner.Player1;
            }

            if (p2 > p1)
            {
                return Winner.Player2;
            }

            return Winner.Draw;
        }
    }
}

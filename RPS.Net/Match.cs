using System;
using System.Collections.Generic;
using System.Text;

namespace RPS.Net
{
    public class Match<TShape> where TShape:IShape
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        private IList<Turn<TShape>> Turns { get; set; } = new List<Turn<TShape>>();
    }
}

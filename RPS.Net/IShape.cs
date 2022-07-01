using System;
using System.Collections.Generic;
using System.Text;

namespace RPS.Net
{
    public interface IShape
    {
        int CompareTo(IShape shape);
    }
}

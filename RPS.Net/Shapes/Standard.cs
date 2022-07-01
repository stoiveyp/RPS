using System;
using System.Collections.Generic;
using System.Text;

namespace RPS.Net.Shapes
{
    public class Standard:IShape,IComparable<Standard>
    {
        protected bool Equals(Standard other)
        {
            return Shape == other.Shape;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Standard)obj);
        }

        public override int GetHashCode()
        {
            return (int)Shape;
        }

        public int CompareTo(IShape shape)
        {
            if (!(shape is Standard stand))
            {
                throw new InvalidOperationException("Unable to compare non standard type");
            }

            return CompareTo(stand);
        }

        public static Standard Rock() => new Standard(StandardShape.Rock);
        public static Standard Paper() => new Standard(StandardShape.Paper);
        public static Standard Scissors() => new Standard(StandardShape.Scissors);

        public Standard(StandardShape shape)
        {
            Shape = shape;
        }

        public StandardShape Shape { get; set; }

        public int CompareTo(Standard other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (other is null) return 1;

            //Handle the loop
            if (Shape == StandardShape.Scissors && other.Shape == StandardShape.Rock)
            {
                return -1;
            }

            if (Shape == StandardShape.Rock && other.Shape == StandardShape.Scissors)
            {
                return 1;
            }

            return Shape.CompareTo(other.Shape);
        }

        public static bool operator ==(Standard operand1, Standard operand2)
        {
            return operand1.CompareTo(operand2) == 0;
        }

        public static bool operator !=(Standard operand1, Standard operand2)
        {
            return operand1.CompareTo(operand2) != 0;
        }

        // Define the is greater than operator.
        public static bool operator >(Standard operand1, Standard operand2)
        {
            return operand1.CompareTo(operand2) > 0;
        }

        // Define the is less than operator.
        public static bool operator <(Standard operand1, Standard operand2)
        {
            return operand1.CompareTo(operand2) < 0;
        }

        // Define the is greater than or equal to operator.
        public static bool operator >=(Standard operand1, Standard operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        // Define the is less than or equal to operator.
        public static bool operator <=(Standard operand1, Standard operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }
    }

    public enum StandardShape
    {
        Rock,
        Paper,
        Scissors
    }
}

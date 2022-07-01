using RPS.Net.Shapes;

namespace RPS.Net.Tests
{
    public class StandardShapeTests
    {
        [Fact]
        public void WinningWorks()
        {
            Assert.True(Standard.Rock() > Standard.Scissors());
            Assert.True(Standard.Paper() > Standard.Rock());
            Assert.True(Standard.Scissors() > Standard.Paper());
        }

        [Fact]
        public void LosingWorks()
        {
            Assert.True(Standard.Rock() < Standard.Paper());
            Assert.True(Standard.Paper() < Standard.Scissors());
            Assert.True(Standard.Scissors() < Standard.Rock());
        }

        [Fact]
        public void DrawWorks()
        {
            Assert.Equal(Standard.Rock(), Standard.Rock());
            Assert.Equal(Standard.Paper(),Standard.Paper());
            Assert.Equal(Standard.Scissors() ,Standard.Scissors());
        }
    }
}
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Positive_X_Positive_is_Positive()
        {
            int result = Multiply(1, 2);
            Assert.Equal(2, result);

        }
        [Fact]
        public void Positive_X_Negative_is_Negative()
        {
            int result = Multiply(-1, 2);
            Assert.Equal(-2, result);
        }
        [Fact]
        public void Negative_X_Negative_is_Positive()
        {
            int result = Multiply(-1, -2);
            Assert.Equal(2, result);
        }

        private int Multiply(int a,  int b)
        {
            return a*b;
        }
    }
}

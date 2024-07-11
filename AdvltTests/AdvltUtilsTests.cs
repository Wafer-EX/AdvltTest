using AdvltTest;

namespace AdvltTests
{
    public class AdvltUtilsTests
    {
        [Theory]
        [InlineData(12, 1, 5, 9, 10, 5)]
        [InlineData(1, 1, 2, 3)]
        [InlineData(1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2)]
        [InlineData(8, 6, 2, 4, 10, 3)]
        public void CalcStepsToEquilibriumTest(int exceptedOutput, params int[] chips)
        {
            int output = AdvltUtils.CalcStepsToEquilibrium(chips);
            Assert.Equal(exceptedOutput, output);
        }
    }
}
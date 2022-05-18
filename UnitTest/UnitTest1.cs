using LeetCode;

namespace UnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 5, 7 }, 6, 3)]
        [InlineData(new int[] { 1, 3, 5, 7 }, 0, 0)]
        [InlineData(new int[] { 1, 3, 5, 7 }, 8, 4)]


        public void SearchInsertPositionTest(int[] nums, int target, int expected)
        {
            var actual = SearchInsertPosition.SearchPosition(nums, target);

            Assert.Equal(expected, actual);
        }
    }
}
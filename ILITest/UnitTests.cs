using IntervalListIntersections;
using System.Collections.Generic;
using Xunit;

namespace ILITests
{
    public class UnitTests
    {
        [Fact]
        public void Test1()
        {
            List<int[]> listA1 = new List<int[]>
            {
                new int[] { 0, 2 },
                new int[] { 5, 10 },
                new int[] { 13, 23 },
                new int[] { 24, 25 },
            };

            List<int[]> listA2 = new List<int[]>
            {
                new int[] { 1, 5 },
                new int[] { 8, 12 },
                new int[] { 15, 24 },
                new int[] { 25, 26 },
            };

            List<int[]> solution = new List<int[]>
            {
                new int[] { 1, 2 },
                new int[] { 5, 5 },
                new int[] { 8, 10 },
                new int[] { 15, 23 },
                new int[] { 24, 24 },
                new int[] { 25, 25 }
            };

            Assert.Equal(Methods.GetIntersection(listA1, listA2), solution);
        }

        [Fact]
        public void Test2()
        {
            List<int[]> listA1 = new List<int[]>
            {
                new int[] { 1, 3 },
                new int[] { 5, 9 },
            };

            List<int[]> listA2 = new List<int[]>();

            List<int[]> solution = new List<int[]>();

            Assert.Equal(Methods.GetIntersection(listA1, listA2), solution);
        }

        [Fact]
        public void Test3()
        {
            List<int[]> listA1 = new List<int[]>
            {
                new int[] { 1, 7 },
            };

            List<int[]> listA2 = new List<int[]>
            {
                new int[] { 3, 10 },
            };

            List<int[]> solution = new List<int[]>
            {
                new int[] { 3, 7 },
            };

            Assert.Equal(Methods.GetIntersection(listA1, listA2), solution);
        }
    }
}
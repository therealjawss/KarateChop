using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace KarateChop.Tests
{
    public class KarateChopTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void TestChop(int expectedResult, int numberToSearchFor, int[] array_of_int)
        {
            int result = KarateChop.Chop(numberToSearchFor, array_of_int);
            result.Should().Be(expectedResult);

        }

        public static IEnumerable<object[]> Data => new List<object[]> {
                new object[] {-1, 3, new int[] { } },
                new object[] { -1, 3, new int[] { 1 } },
                new object[] { 0, 1, new int[] { 1 } },
                new object[] { 0, 1, new int[] { 1, 3, 5 } },
                new object[] { 1, 3, new int[] { 1, 3, 5 } },
                new object[] {2, 5, new int[] { 1, 3, 5} },
                new object[] { -1, 0, new int[] { 1, 3, 5 } },
                new object[] { -1, 2, new int[] { 1, 3, 5 } },
                new object[] { -1, 4, new int[] { 1, 3, 5 } },
                new object[] { -1, 6, new int[] { 1, 3, 5 } },
                new object[] { 0, 1, new int[] { 1, 3, 5,7 } },
                new object[] { 1, 3, new int[] { 1, 3, 5,7 } },
                new object[] { 2, 5, new int[] { 1, 3, 5,7 } },
                new object[] { 3, 7, new int[] { 1, 3, 5,7 } },
                new object[] { -1, 0, new int[] { 1, 3, 5,7 } },
                new object[] { -1, 2, new int[] { 1, 3, 5,7 } },
                new object[] { -1, 4, new int[] { 1, 3, 5,7 } },
                new object[] { -1, 6, new int[] { 1, 3, 5,7 } },
                new object[] { -1, 8, new int[] { 1, 3, 5,7 } },

      
                
            
                //Original tests from http://codekata.com/kata/kata02-karate-chop/
 
        };
    }
}

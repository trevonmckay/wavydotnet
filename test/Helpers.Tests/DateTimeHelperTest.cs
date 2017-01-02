using System;
using Xunit;

namespace Wavy.Helpers.Tests
{
    public class DateTimeHelperTest
    {
        [Fact]
        public void InputZeroShouldReturnUnixEpoch()
        {
            //Given
            var expected = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        
            //When
            var result = DateTimeHelper.CreateDateTimeFromUnixSeconds(0);
        
            //Then
            Assert.Equal(expected, result);
        }
    }
}
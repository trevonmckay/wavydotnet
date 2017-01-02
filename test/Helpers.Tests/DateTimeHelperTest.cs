using System;
using Xunit;

namespace Wavy.Helpers.Tests
{
    public class DateTimeHelperTest
    {
        [Fact]
        public void CreateDateTimeFromUnixSecondsZeroShouldReturnUnixEpoch()
        {
            //Given
            var expected = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        
            //When
            var result = DateTimeHelper.CreateDateTimeFromUnixSeconds(0);
        
            //Then
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CreateDateTimeFromUnixMillisecondsZeroShouldReturnUnixEpoch()
        {
            //Given
            var expected = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        
            //When
            var result = DateTimeHelper.CreateDateTimeFromUnixMilliseconds(0);
        
            //Then
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CreateDateTimeFromUnixSecondsShouldReturnFeb142005()
        {
            //Given
            var expected = new DateTime(2005, 2, 14, 0, 0, 0, DateTimeKind.Utc);

            //When
            var result = DateTimeHelper.CreateDateTimeFromUnixSeconds(1108339200);
        
            //Then
            Assert.Equal(expected, result);
        }
    }
}
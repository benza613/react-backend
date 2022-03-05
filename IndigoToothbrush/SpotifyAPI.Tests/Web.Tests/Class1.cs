using Xunit;
using SpotifyAPI;

namespace SpotifyAPI.Tests
{
    public class Class1
    {
        [Fact]
        public void AmplifyValue()
        {
            int actual = SpotifyAPI.StringLibrary.AmplifyValue(10);

            Assert.Equal<int>(1200, actual);
        }
    }
}
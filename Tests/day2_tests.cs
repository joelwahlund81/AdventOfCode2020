using day2;
using System;
using Xunit;

namespace Tests
{
    public class day2_tests
    {
        [Fact]
        public void part2()
        {
            var lines = new string[] 
            { 
                "1-3 a: abcde", // valid
                "1-3 b: cdefg", // invalid
                "2-9 c: ccccccccc"
            };

            var pps = Passwords.ConvertPasswords(lines);

            var result = Passwords.ValidPasswordsPolicy(pps);

            Assert.Equal(1, result);
        }
    }
}

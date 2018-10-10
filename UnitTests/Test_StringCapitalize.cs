using System;
using Xunit;
using FluentAssertions;
using StringCapitalize;
using FakeItEasy;

namespace UnitTests
{
    public class Test_StringCapitalize
    {
        private readonly string _answer = "HEllO_woRld";  

        [Fact]
        public void Test_ValidString()
        {
            string testString = "Hello_world";
            char[] delim = new char[] { '_', 'l' };
            StringCapitalizeHelper sch = A.Fake<StringCapitalizeHelper>();
            string returnString = sch.ConvertCaps(testString, delim);
            
            returnString.Should().Be(_answer);
        }

        [Fact]
        public void Test_EmptyString()
        {
            string testString = "";
            char[] delim = new char[] { '_', 'l' };
            StringCapitalizeHelper sch = A.Fake<StringCapitalizeHelper>();
            
            Action action = () => sch.ConvertCaps(testString, delim);

            action.Should().Throw<ArgumentException>();


        }
    }
}

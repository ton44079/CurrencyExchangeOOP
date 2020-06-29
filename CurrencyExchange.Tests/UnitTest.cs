using System;
using System.IO;
using System.Text;
using Xunit;
using CurrencyExchange.Services.Models;

namespace CurrencyExchange.Tests
{
    public class UnitTest
    {
        [Theory]
        [InlineData(0, "0", "0")]
        [InlineData(10, "50", "100")]
        [InlineData(20, "100", "200")]
        public void DollarInputInt(int input, string appleExpect, string bananaExpect)
        {
            var dollar = new Dollar(input);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                dollar.getApple();
                Assert.Equal(appleExpect, sw.ToString().Trim());
            }
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                dollar.getBanana();
                Assert.Equal(bananaExpect, sw.ToString().Trim());
            }

        }

        [Theory]
        [InlineData("Hello", "0", "0")]
        [InlineData("10", "50", "100")]
        [InlineData("20", "100", "200")]
        public void DollarInputString(string input, string appleExpect, string bananaExpect)
        {
            var dollar = new Dollar(input);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                dollar.getApple();
                Assert.Equal(appleExpect, sw.ToString().Trim());
            }
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                dollar.getBanana();
                Assert.Equal(bananaExpect, sw.ToString().Trim());
            }

        }

        [Theory]
        [InlineData(0, "0", "0")]
        [InlineData(10, "2", "20")]
        [InlineData(20, "4", "40")]
        public void AppleInputInt(int input, string dollarExpect, string bananaExpect)
        {
            var apple = new Apple(input);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                apple.getDollar();
                Assert.Equal(dollarExpect, sw.ToString().Trim());
            }
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                apple.getBanana();
                Assert.Equal(bananaExpect, sw.ToString().Trim());
            }

        }

        [Theory]
        [InlineData("Hiiiii", "0", "0")]
        [InlineData("10", "2", "20")]
        [InlineData("20", "4", "40")]
        public void AppleInputString(string input, string dollarExpect, string bananaExpect)
        {
            var apple = new Apple(input);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                apple.getDollar();
                Assert.Equal(dollarExpect, sw.ToString().Trim());
            }
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                apple.getBanana();
                Assert.Equal(bananaExpect, sw.ToString().Trim());
            }

        }

        [Theory]
        [InlineData(0, "0", "0")]
        [InlineData(10, "1", "5")]
        [InlineData(20, "2", "10")]
        public void BananaInputInt(int input, string dollarExpect, string appleExpect)
        {
            var apple = new Banana(input);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                apple.getDollar();
                Assert.Equal(dollarExpect, sw.ToString().Trim());
            }
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                apple.getApple();
                Assert.Equal(appleExpect, sw.ToString().Trim());
            }

        }

        [Theory]
        [InlineData("Hiiiii", "0", "0")]
        [InlineData("10", "1", "5")]
        [InlineData("20", "2", "10")]
        public void BananaInputString(string input, string dollarExpect, string appleExpect)
        {
            var apple = new Banana(input);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                apple.getDollar();
                Assert.Equal(dollarExpect, sw.ToString().Trim());
            }
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                apple.getApple();
                Assert.Equal(appleExpect, sw.ToString().Trim());
            }

        }
    }
}

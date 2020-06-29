namespace CurrencyExchange.Services.Models
{
    public class Apple : Exchange
    {
        public Apple() : base(TokenType.Apple, 0) { }

        public Apple(int value) : base(TokenType.Apple, value)
        {
        }

        public Apple(string value) : base(TokenType.Apple, value)
        {
        }

        public Apple(decimal value) : base(TokenType.Apple, value)
        {
        }
    }
}
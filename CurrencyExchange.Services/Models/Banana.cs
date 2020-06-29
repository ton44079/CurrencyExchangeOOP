namespace CurrencyExchange.Services.Models
{
    public class Banana : Exchange
    {
        public Banana() : base(TokenType.Banana, 0) { }

        public Banana(int value) : base(TokenType.Banana, value)
        {
        }

        public Banana(string value) : base(TokenType.Banana, value)
        {
        }

        public Banana(decimal value) : base(TokenType.Banana, value)
        {
        }
    }
}
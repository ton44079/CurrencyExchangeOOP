namespace CurrencyExchange.Services.Models
{
    public class Dollar : Exchange
    {
        public Dollar() : base(TokenType.Dollar, 0) { }

        public Dollar(int value) : base(TokenType.Dollar, value)
        {
        }

        public Dollar(string value) : base(TokenType.Dollar, value)
        {
        }

        public Dollar(decimal value) : base(TokenType.Dollar, value)
        {
        }
    }
}
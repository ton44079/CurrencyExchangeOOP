using System;

namespace CurrencyExchange.Services.Models
{
    public enum TokenType
    {
        Dollar = 0,
        Apple = 1,
        Banana = 2,

    }

    public abstract class Exchange
    {
        private decimal _dollar;
        private decimal _apple;
        private decimal _banana;

        public Exchange(TokenType type, string value)
        {
            if (decimal.TryParse(value, out decimal newVal))
            {
                setToken(type, newVal);
            }
            else
            {
                setToken(type, 0);
            }
        }

        public Exchange(TokenType type, int value)
        {
            setToken(type, Convert.ToDecimal(value));
        }
        public Exchange(TokenType type, decimal value)
        {
            setToken(type, value);
        }

        private void setToken(TokenType type, decimal value)
        {
            value = value > 0 ? value : 0;

            switch (type)
            {
                case TokenType.Dollar:
                    _dollar = value;
                    _apple = value * 5;
                    _banana = value * 10;
                    break;
                case TokenType.Apple:
                    _dollar = value / 5;
                    _apple = value;
                    _banana = value * 2;
                    break;
                case TokenType.Banana:
                    _dollar = value / 10;
                    _apple = value / 2;
                    _banana = value;
                    break;
                default:
                    _dollar = 0;
                    _apple = 0;
                    _banana = 0;
                    break;
            }
        }

        public void getDollar()
        {
            Console.WriteLine("{0}", _dollar);
        }

        public void getApple()
        {
            Console.WriteLine("{0}", _apple);
        }

        public void getBanana()
        {
            Console.WriteLine("{0}", _banana);
        }
    }
}
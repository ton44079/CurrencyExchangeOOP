using System;
using CurrencyExchange.Services.Models;

namespace CurrencyExchange
{
    class Program
    {
        static void Main(string[] args)
        {

            var dollar = new Dollar(20);
            dollar.getApple(); // output on screen: 100
            dollar.getBanana();// output on screen: 200

            var apple = new Apple(5);
            apple.getDollar(); // output on screen: 1
            apple.getBanana(); // output on screen: 10

            var banana = new Banana(5);
            banana.getDollar(); // output on screen: 0.50
            banana.getApple(); // output on screen: 2.50

            dollar = new Dollar(0);
            dollar.getApple();

            apple = new Apple(-5);
            apple.getBanana();

            banana = new Banana("Hello");
            banana.getApple();
        }
    }
}

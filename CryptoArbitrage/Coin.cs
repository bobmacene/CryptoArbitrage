namespace CryptoArbitrage
{
    public enum Currency { BTC, ETH }

    public class Coin
    {
        public Currency Currency;
        public double Number;

        public Coin(Currency currency, double number)
        {
            Currency = currency;
            Number = number;
        }

    }
}

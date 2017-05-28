namespace CryptoArbitrage
{
    interface iArbitrage
    {
        double Price { get; }
        double ComparisonPrice { get; }
        Execute Decision { get; }
    }

    public enum Execute { Trade, DontTrade }

    class ArbitrageEngine : iArbitrage
    {
        private const double PriceDiffToTrade = 0.5;
        public double Price { get; set; }
        public double ComparisonPrice { get; set; }
        public Execute Decision { get; set; }

        //public ArbitrageEngine()
        //{
        //    Decision = GetDecision(Price, ComparisonPrice);
        //}

        public Execute GetDecision(double price, double comparisonPrice)
        {
            return (price - comparisonPrice) > PriceDiffToTrade
                ? Execute.Trade : Execute.DontTrade;
        }

        public double ExecuteTrade(Coin toTrd, double price, Coin newBal)
        {
            return newBal.Number + (toTrd.Number * price);
        }

        public Coin UpdateBalances(Coin first, Coin second  )
        {

        }
        //public double UpdateBalance(double currentBal, double price)
        //{

        //} 
    }
}

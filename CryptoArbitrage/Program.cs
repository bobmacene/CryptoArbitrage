using System.Net;

namespace CryptoArbitrage
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //const string lastPxUrl = "https://cex.io/api/last_price/ETH/BTC";

            //string jsonCex = new ExchangeCurrencyPairPrice().GetJsonPrice(lastPxUrl);

            //const string pattern = "lprice\":\"(.*)\",\"curr1";

            //var cexBtcEth = new RegexMatch(pattern, jsonCex); 


            var krcknBal = new Coin(Currency.BTC, 1);
            var cexBal = new Coin(Currency.BTC, 1);

            var krcknPx = 1;
            var cexPx = 2;

            var arbEngine = new ArbitrageEngine();
            var execute = arbEngine.GetDecision(krcknPx, cexPx);

            if(execute == Execute.Trade)
            {
                var trdResult = arbEngine.ExecuteTrade(krcknBal, krcknPx);
            }

           
        }
    }
}

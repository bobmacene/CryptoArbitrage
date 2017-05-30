using System.Net;

namespace CryptoArbitrage
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var api = new ApiCall();

            logger.AddServerTimeToLog(api);
             
            //const string lastPxUrl = "https://cex.io/api/last_price/ETH/BTC";

            //string jsonCex = new ExchangeCurrencyPairPrice().GetJsonPrice(lastPxUrl);

            //const string pattern = "lprice\":\"(.*)\",\"curr1";

            //var cexBtcEth = new RegexMatch(pattern, jsonCex); 


            var tickerUrl = "https://api.kraken.com/0/public/AssetPairs?pair=XXBTZEUR";
            var tradableAssetPairsUrl = "https://api.kraken.com/0/public/AssetPairs";
            var assetsUrl = "https://api.kraken.com/0/public/Assets";
            var btcEurOrderBookUrl = "https://api.kraken.com/0/public/Depth?pair=XBTEUR";

            //var tradableAssetPairsData = api.CallApi(tradableAssetPairsUrl);
            //logger.AddLogEvent("TradableAssetPairs", tradableAssetPairsData);

            //var assetsData = api.CallApi(assetsUrl);
            //logger.AddLogEvent("AssetsData", tradableAssetPairsData);


            var ethBtcTickerData = api.CallApi(tickerUrl);
            logger.AddLogEvent("TickerData", ethBtcTickerData);

            var btcEurOrderBook = api.KrackenOrderBook(btcEurOrderBookUrl);
            //logger.AddLogEvent("BTCEUROrderBook", btcEurOrderBook);

            var krcknBal = new Coin(Currency.BTC, 1);
            var cexBal = new Coin(Currency.BTC, 1);

            var krcknPx = 1;
            var cexPx = 2;

            var arbEngine = new ArbitrageEngine();
            var execute = arbEngine.GetDecision(krcknPx, cexPx);

            if(execute == Execute.Trade)
            {
               // var trdResult = arbEngine.ExecuteTrade(krcknBal, krcknPx);
            }

           
            logger.PersistLog();
        }
    }
}

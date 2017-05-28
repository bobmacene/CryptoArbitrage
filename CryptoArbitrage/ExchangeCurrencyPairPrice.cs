using System.Net;

namespace CryptoArbitrage
{
    public interface iExchangeCurrencyPairPrice
    {
        string GetJsonPrice(string url);
    }
    class ExchangeCurrencyPairPrice : iExchangeCurrencyPairPrice
    {
        public string GetJsonPrice(string url)
        {
            return new WebClient().DownloadString(url);
        }

    }
}

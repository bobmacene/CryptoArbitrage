using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoArbitrage
{
    class ExchangeBalances
    {
        public IEnumerable<Coin> Balances { get; set; }
        public string ExchangeName;

        public ExchangeBalances(string exchangeName)
        {
            ExchangeName = exchangeName;
            Balances = new List<Coin>();
        }
            
    }
}

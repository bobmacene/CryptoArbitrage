using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoArbitrage
{
    class TestStrategy
    {
        private double _min;
        private double _max;
        public TestStrategy(double min, double max)
        {
            var price = new Random();
        }

        private Execute 
        private double GetRandomDouble(double min, double max)
        {
            var random = new Random();
            return random.NextDouble() * (min - max) + max;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoArbitrage
{
    class Logger
    {
        public string LogLines;

        private const string LogFilePath = @"C:\Users\bob\Documents\Visual Studio 2015\Projects\CryptoArbitrage\Log\CryptoArbLog.txt";
        private const string ServerTimeUrl = @"https://api.kraken.com/0/public/Time";

        public Logger()
        {
            LogLines = DateTime.Now + ":    CRYTOARB STARTED.\n";
        }

        public void AddServerTimeToLog(ApiCall api)
        {
            var serverTime = api.CallApi(ServerTimeUrl);
            LogLines = $"{LogLines}SERVERTIME:\t\t{serverTime}";    
        }

        public void AddLogEvent(string label)
        {
            LogLines = $"{LogLines}\n{DateTime.Now}:    {label}";
        }

        public void AddLogEvent(string label, string dataToLog)
        {
            LogLines = $"{LogLines}\n{DateTime.Now}:    {label}" + "{" + dataToLog + "}";
        }

        public void PersistLog()
        {
            using (var writer = new StreamWriter(LogFilePath))
            {
                 writer.Write(LogLines, true);
            }
        }

    }
}

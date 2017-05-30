using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace CryptoArbitrage
{
	public interface IApiCall
	{
		string CallApi(string url);
	}
	
    public class ApiCall : IApiCall
	{
		public string CallApi(string url)
		{
			return new WebClient().DownloadString(url);
		}

        public List<Dictionary<string, Tuple<string, string, string>>> KrackenOrderBook(string url)
        {
            var calldata =  new WebClient().DownloadString(url);
            return JsonConvert.DeserializeObject<List<Dictionary<string, Tuple<string, string, string>>>>(calldata);
        }
    }
}
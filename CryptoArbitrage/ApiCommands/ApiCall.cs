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

	}
}
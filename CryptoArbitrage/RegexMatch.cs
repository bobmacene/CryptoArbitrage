using System.Text.RegularExpressions;

namespace CryptoArbitrage
{
    interface iPattern
    {
        string GetPattern(string pattern, string searchString);
    }
    class RegexMatch : iPattern
    {
        public string Result;
       
        public RegexMatch(string pattern, string searchstring)
        {
             Result = GetPattern(pattern, searchstring);
        }     

        public string GetPattern(string pattern, string searchString)
        {
            var regex = new Regex(pattern);
            var match = regex.Match(searchString);
            return match.Groups[1].Value;
        }
    }
}

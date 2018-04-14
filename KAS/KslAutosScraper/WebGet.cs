using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KAS.KslAutosScraper
{
    public static class WebGet
    {
        readonly static string SearchUrl = @"https://www.ksl.com/auto/search/index?p=";
        
        public async static Task<List<string>> GetMakes()
        {
            List<string> retVar = new List<string>();
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36";
                var site = await client.DownloadStringTaskAsync(SearchUrl);

            }

            return retVar;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataFilm_HDPHim
{
    class Utils
    {
        #region HttpClient
        public static HttpClient GetHttpClient(CookieContainer cookieContainer)
        {

            HttpClient httpClient = new HttpClient(new HttpClientHandler
            {
                AllowAutoRedirect = false,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                CookieContainer = cookieContainer
            });
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.99 Safari/537.36");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate, sdch");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "vi-VN,vi;q=0.8,fr-FR;q=0.6,fr;q=0.4,en-US;q=0.2,en;q=0.2");
            //  httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "vi-VN,vi;q=0.8,en-US;q=0.5,en;q=0.3");
            return httpClient;
        }

        public static async Task<string> HttpClientRequert(string url, Dictionary<string, string> headers = null, string method = "get", Dictionary<string,string> dicData = null)
        {
            var cookieContainer = new CookieContainer();
            HttpClient httpClient = Utils.GetHttpClient(cookieContainer);
            if (headers != null)
            {
                foreach (var item in headers)
                {
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation(item.Key, item.Value);
                }
            }

            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            switch (method.ToLower())
            {
                case "get":
                    httpResponseMessage = await httpClient.GetAsync(url);
                    break;
                case "post":
                    FormUrlEncodedContent formContent = new FormUrlEncodedContent(dicData);
                    
                    httpResponseMessage = await httpClient.PostAsync(new Uri(url), formContent);
                    break;
                case "delete":
                    break;
                default:
                    break;
            }
            var result = await httpResponseMessage.Content.ReadAsStringAsync();
            return result;
        }
        #endregion
    }
}

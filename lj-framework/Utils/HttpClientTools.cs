using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace lj_framework.Utils
{
    public static class HttpClientTools
    {
        public static async Task<HttpStatusCode> GetHttpStatusCode(Uri uri)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);
            return response.StatusCode;
        }
    }
}

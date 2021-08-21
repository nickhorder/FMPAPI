using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FMPAPIConfig
/* Initialises HttpClient with parameters 
 */
{
    public static class APIHelper
    {
        public static HttpClient APIClient { get; set; }

        public static void InitialiseClient()
        {
            APIClient = new HttpClient();
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}

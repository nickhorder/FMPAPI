using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace FMPAPIConfig
/* Builds URL and calls API
*/
{
    public static class APICaller
    {
        public static async Task<CompanyKeyStatsModel> CompanyKeyStats(string symbol = "AAPL?", string apikey = "apikey=numbers")
        {
            string url = $"https://financialmodelingprep.com/api/v3/profile/{symbol}{apikey}";

            using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))     
               if (response.IsSuccessStatusCode) 
                {
                   CompanyKeyStatsModel CompanyKeyStats = await response.Content.ReadAsAsync<CompanyKeyStatsModel>();
                   return CompanyKeyStats;            
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }         
        } 
    } 
}




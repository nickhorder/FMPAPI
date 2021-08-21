using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FMPAPICall
{
    public class Temp
    {
        public async Task CompanyKeyStats(
            string symbol = "AAPL?", 
            string apikey = "=39464dcbe9e6ca8ea538e7bba66e4773")
        {
            string url = $"https://financialmodelingprep.com/api/v3/profile/ {symbol} {apikey}";
        }
    }
}


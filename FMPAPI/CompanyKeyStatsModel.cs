using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FMPAPIConfig
/* Model for Company Profile values within Financial Modeling Prep API 
 * https://financialmodelingprep.com/developer/docs#Company-Profile
 */
{
    public class CompanyKeyStatsModel
    {
        public string companyName { get; set; }
        public string exchangeShortName { get; set; }
    }
}
 
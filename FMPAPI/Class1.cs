using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Tracing;

namespace FMPAPIConfig
{
    class Program
    {
        static void Main(string[] args)
        {
// Call InitialiseClient method within class APIHelper  
            APIHelper.InitialiseClient();
// call CompanyKeyStats method within class APICaller 
            APICaller.CompanyKeyStats();
/* Nothing currently coming back. I think the call is going out to the API as Norton is giving me a 
 * firewall warning which I accepted
*/
    //       Console.WriteLine(APICaller.CompanyKeyStats);
        }
    }
}

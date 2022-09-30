using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP.NET_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// the total hosting cost
        /// </summary>
        /// <param name="fortnights">14 days for web hosting and maintenance</param>
        /// <param name="tax">the tax number</param>
        /// <param name="numberOfDays">the number of days it took to complete the process</param>
        /// <returns>output of 3 strings of the total hosting cost</returns>
        public string Get(int fortnights, int tax, int numberOfDays, string invoice) {
            IEnumerable<String> Invoice = new String[] {
                "Number of fortnights is " + fortnights.ToString(),
                "The tax is " + tax.ToString(),
                "The Number Of Days is " + numberOfDays.ToString() };
            return invoice;
        }
    }
}

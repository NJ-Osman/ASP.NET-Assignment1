using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP.NET_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// returns a number that adds by 5 multiplys by 3 subtracts by 6 and divides by 4
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>the input number adds by 5 multiplys by 3 subtracts by 6 and divides by 4</returns>
        public int Get(int id)
        {
            return (id + 5) * 3 - 6 / 4;
        }
    }
}

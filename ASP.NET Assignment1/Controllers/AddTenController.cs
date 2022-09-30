using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP.NET_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        ///id+(10) outputs a number plus 10
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>the input number added by 10</returns>
        public int Get(int id)
        {

            return id + 10;
        }
    }
}

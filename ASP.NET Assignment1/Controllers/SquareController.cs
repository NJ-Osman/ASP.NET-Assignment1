using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP.NET_Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// returns a number squared by the user
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns> the user input number squared</returns>
        public int Get(int id)
        {
            return id * id;
                
        }
    }
}

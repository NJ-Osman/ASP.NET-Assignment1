using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP.NET_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// returns a message on POST
        /// </summary>
        /// <example>
        /// POST /api/Greeting
        /// curl -d "" "http://localhost:51022/api/greeting"
        /// "how to access and display the post method"
        /// </example>
        /// <returns>"hello world"</returns>
        public string Post()
        {
            return "Hello World";
        }

        /// <summary>
        /// returns a message with the user id number
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>"Greetings to " + input number "people!" </returns>
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}

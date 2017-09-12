using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OnlineGanvadeba.Controllers
{
    public class AppController : ApiController
    {


        [HttpGet]
        [Route("api/app/t")]
        public string t()
        {
            return "kaxa";
        }
    }
}

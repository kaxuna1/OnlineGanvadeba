using Dapper;
using OnlineGanvadeba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            return "kaxaaaa";
        }



        [HttpGet]
        [Route("api/app/d")]
        public HttpResponseMessage syncdata()
        {
            try
            {
                using (var db = BaseRepo.OpenConnection())
                {


                    var data = db.Query<Region>("GetRegions").OrderBy(o => o.Id);


                    return Request.CreateResponse(new { data, success = true });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(new { success = false, errorMessage = ex.Message });
            }
        }
    }
}

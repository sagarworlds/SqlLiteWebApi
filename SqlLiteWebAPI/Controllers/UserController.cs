using SqliteORM;
using SqlLiteWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SqlLiteWebAPI.Controllers
{
    public class UserController : ApiController
    {
        //DataAccess<auth_user> da;
        public UserController()
        {
            // da = new DataAccess<auth_user>();
        }

        [System.Web.Http.HttpGet]
        public HttpResponseMessage Get()
        {
            using (DbConnection conn = new DbConnection())
            {
                var user = auth_user.Read();

                if (user == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, true);
                }
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }

            //return new ObjectResult(product);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using task5_sol.DAL;
using task5_sol.Models;

namespace task5_sol.Controllers
{
    public class Enrollment
    {


        [Route("api/enrollments")]
        [ApiController]
        public class EnrollmentController : ControllerBase
        {
            String sqlConnection = @"Data Source = db - mssql; Initial Catalog = s19740; Integrated Security = True";

            

            public IActionResult EnrollStudent(ERequest req)
            {
                ERequest helpme = IDbService.EnrollStudent(req);
                if (helpme == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(helpme);
                }


            }

            /* [HttpPost(Name = "promote")]
             [Route("promote")]
             public IActionResult Promote(STReqs request)
             {
             }
             */
        }
    }
}
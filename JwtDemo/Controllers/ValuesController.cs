using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtDemo.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public DummeDto Dummy()
        {
            return new DummeDto
            {
                IntVal = 1,
                StringVal = "Test"
            };
        }
        [AllowAnonymous]
        [HttpGet]
        public DummeDto DummyUnchecked()
        {
            return new DummeDto
            {
                IntVal = 1,
                StringVal = "Unchecked"
            };
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sample.dal.Db;
using sample.dal.Models;

namespace sample.app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            CustomerHandler dal = new CustomerHandler();
            await dal.Save(new Customer()
            {
                Name = "Chetan",
                Email = "chetan@gmail.com"
            });

            return Ok();
        }
    }
}
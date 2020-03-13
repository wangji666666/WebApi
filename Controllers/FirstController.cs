using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    /// <summary>
    /// 严格遵循Restfull风格
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]//First当成一个资源 对它进行增删改查
    public class FirstController : ControllerBase
    {

        [Route("Get")]
        [HttpGet()]
        public string Get()
        {
            return "wffff";
        }

        [Route("Info")]
        [HttpGet()]
        public string Info()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                Id = 123,
                Name = "fdsa"
            });
        }

        [Route("GetInfo")]
        [HttpGet()]
        public string GetInfo()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                Id = 123,
                Name = "fdsa"
            });
        }
    }
}
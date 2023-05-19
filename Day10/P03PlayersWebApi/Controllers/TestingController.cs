﻿using Microsoft.AspNetCore.Mvc;

namespace P03PlayersWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestingController : Controller
    {
        [HttpGet(Name = "GetTestingData")]
        public string MyTestingName()
        {
            return "hello";
        }
    }
}

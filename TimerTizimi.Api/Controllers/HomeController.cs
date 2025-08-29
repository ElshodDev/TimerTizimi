//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: TimerTizimi.Api
//===================================================
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace TimerTizimi.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() => Ok("Hi: Guys");
    }
}

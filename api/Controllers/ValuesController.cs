﻿using Microsoft.AspNetCore.Mvc;

namespace api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public string[] Get()
        {
            return new string [] { "SAMPLE 1", "SAMPLE 2" };
        }
    }
}

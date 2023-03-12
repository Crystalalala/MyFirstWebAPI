using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class DataStructureController : ControllerBase
    {
        private readonly ILogger<DataStructureController> _logger;

        public DataStructureController(ILogger<DataStructureController> logger)
        {
            _logger = logger;
        }

    }
}

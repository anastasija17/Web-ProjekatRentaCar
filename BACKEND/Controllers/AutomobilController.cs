using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Models;
namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        public RentaCarContext Context;

        public WeatherForecastController(RentaCarContext context)
        {
            Context = context;
        }
        
    }
}

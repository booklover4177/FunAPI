using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FunAPI.Controllers{
    [ApiController]
    [Route("api/fun")]
    public class FunController : ControllerBase
    {
        [HttpGet("cmToIn/{cm}")]
        public double convertToInches(int cm){

            return (double)cm/2.54;
        }
        
    }
}

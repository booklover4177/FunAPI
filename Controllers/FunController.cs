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

        [HttpGet("FtoC/{F}")]

        public double convertFToC(double F){

            return (F-32)*1.8;
        }

        [HttpGet("modifyNames/{name}/{num}")]

        public string[] modifyName(string name, int num){
            var names=new string[num];

            for(var modnum=0; modnum<num; modnum++){
                names[modnum]=name+(modnum+1);
            }

            return names;
        }
        
    }
}

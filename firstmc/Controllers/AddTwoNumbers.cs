using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstmc.Service;
using Microsoft.AspNetCore.Mvc;

namespace firstmc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbers
    {
        
        public readonly AddTwoService _service;

        public  AddTwoNumbers(AddTwoService service)
        {
            _service = service;
        }

        [HttpGet]
        public string Add(int num1, int num2)
        {
            return _service.Add(num1, num2);
        }
    }
}
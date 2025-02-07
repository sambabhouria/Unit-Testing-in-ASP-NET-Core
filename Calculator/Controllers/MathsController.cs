﻿using Calculator.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathsController : ControllerBase
    {
        private IMathsService _mathService = null;

        /*
         * MathsService is added in the Startup file
         * Then it's registred in the dependency injection container 
         * so we can inject this service into controller using the 
         * constructor of the controller
         */
        public MathsController(IMathsService mathService)
        {
            _mathService = mathService;
        }
        [HttpPost]
        [Route("Add")]
        public double Add(double x1, double x2)
        {
            return _mathService.Add(x1, x2);
        }
        [HttpPost]
        [Route("Divide")]
        public double Divide(double x1, double x2)
        {
            return _mathService.Divide(x1, x2);
        }
        [HttpPost]
        [Route("Multiply")]
        public double Multiply(double x1, double x2)
        {
            return _mathService.Multiply(x1, x2);
        }
        [HttpPost]
        [Route("Subtract")]
        public double Subtract(double x1, double x2)
        {
            return _mathService.Subtract(x1, x2);
        }
    }
}

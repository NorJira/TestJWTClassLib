﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTClassLib.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestJWTClassLib.Controllers
{
    [Controller]
    public abstract class JWTBaseController : ControllerBase
    {
        // returns the current authenticated account (null if not logged in)
        public Account Account => (Account)HttpContext.Items["Account"];
    }
}

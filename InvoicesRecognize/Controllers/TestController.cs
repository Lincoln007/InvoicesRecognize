﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InvoicesRecognize.Controllers
{
    public class TestController : ApiController
    {
        public string show()
        {
            return "some test string";
        }

        public string tangchao()
        {
            return "tang hao";
        }

    }
}

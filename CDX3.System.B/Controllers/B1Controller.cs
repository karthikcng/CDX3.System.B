﻿using CDX3.System.B.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CDX3.System.B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class B1Controller : ControllerBase
    {
        [HttpPost]
        [Route("Feature1")]
        public JsonResult Feature1(Cl_feature_IP ip)
        {
            Cl_feature_OP op = new Cl_feature_OP();

            op.ConcatenateInputData(ip);
            return new JsonResult(op);
        }

        [HttpPost]
        [Route("Feature2")]
        public JsonResult Feature2(Cl_feature_IP ip)
        {
            Cl_feature_OP op = new Cl_feature_OP();

            op.ConcatenateInputData(ip);
            return new JsonResult(op);
        }
    }
}
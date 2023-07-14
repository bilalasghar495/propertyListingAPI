using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;
using propertyListing.Configuration;
using propertyListing.Entities;
using propertyListing.Services;

namespace propertyListing.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyListController : Controller
    {

        private readonly IOptions<conStr> _dbCon;
        private string cmd;
        
        
        public PropertyListController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

        [HttpGet("getPropertyList")]
        public IActionResult getPropertyList()
        {
            try
            {   
                cmd = @"select * from tbl_property";    
                var appMenu = dapperQuery.Qry<propertyList>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch (Exception e)
            {
                return Ok(e);
            }
        }
       
        
    }
}
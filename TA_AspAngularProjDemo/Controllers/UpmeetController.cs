using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TA_AspAngularProjDemo.Models;

namespace TA_AspAngularProjDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpmeetController : ControllerBase
    {
        #region Logger
        // What is this logger? Is it neccessary? 
        private readonly ILogger<UpmeetController> _logger;
        public UpmeetController(ILogger<UpmeetController> logger)
        {
            _logger = logger;
        }
        #endregion

        // API VERBS (Let's just start with a GET)
        
        [HttpGet]
        public List<Event> GetEvents()
        {
            using (var db = new TA_UpmeetContext())
            {
                return db.Events.ToList();
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCompanyNotification.Models;

namespace WebApiCompanyNotification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly DemoDBContext _db;
        public CompanyController(DemoDBContext Db)
        {
            _db = Db;
        }
        [HttpPost]
        public async Task<IActionResult> Index(Company Comp)
        {
            try
            {
                _db.Add(Comp);
                await _db.SaveChangesAsync();
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest();
            }
          
        }

        [HttpGet]
        public async Task<IActionResult> Index(int companyID)
        {
            try
            {
                
                var result = _db.Notification.Where(s => s.CompanyID == companyID).Select(s => s.SendDate);
              
                
                IDictionary<string, string> Notifications = new Dictionary<string, string>();
                Notifications.Add("companyID", companyID.ToString());
                Notifications.Add("Notifications", result.ToString());

                return Ok(Notifications);
            }
            catch (Exception e)
            {
                return BadRequest();
            }

        }
    }
}

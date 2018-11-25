using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly MyContext _dbcontext;

        public EmployeeController(MyContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        public List<EMPLOYEE> Get()
        {
            return _dbcontext.Employee.ToList();
        }

        [HttpGet("{id}")]
        public EMPLOYEE Get(int id)
        {
            if (id > 0)
            {
                return _dbcontext.Employee.Find(id);
            }
            
            return null;
        }

        [HttpPost]
        public IActionResult Post([FromBody]EMPLOYEE employee)
        {
            _dbcontext.Employee.Add(employee);
            _dbcontext.SaveChanges();
            return new ObjectResult("Salvo com sucesso!");
        }

    }
}
using BlogAPIDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        #region EmplyeeList
        [HttpGet]
        public IActionResult EmplyeeList()
        {
            using var c = new Context2();
            var values = c.Employees.ToList();
            return Ok(values);
        }
        #endregion

        #region EmplyeeAdd
        [HttpPost]
        public IActionResult EmplyeeAdd(Employee employee)
        {
            using var c = new Context2();
            c.Add(employee);
            c.SaveChanges();
            return Ok();
        }
        #endregion

        #region EmplyeeGet
        [HttpGet("{id}")]
        public IActionResult EmplyeeGet(int id)
        {
            using var c = new Context2();
            var employee = c.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employee);
            }

        }
        #endregion

        #region EmplyeeDelete

        [HttpDelete("{id}")]
        public IActionResult EmplyeeDelete(int id)
        {
            using var c = new Context2();
            var employee = c.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(employee);
                c.SaveChanges();
                return Ok();
            }

        }
        #endregion

        #region EmplyeeDelete

        [HttpPut]
        public IActionResult EmplyeeUpdate(Employee employee)
        {
            using var c = new Context2();
            var employee2 = c.Employees.Find(employee.ID);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                employee2.Name = employee.Name;
                c.Update(employee2);
                c.SaveChanges();
                return Ok();
            }
           

        }
        #endregion
    }
}

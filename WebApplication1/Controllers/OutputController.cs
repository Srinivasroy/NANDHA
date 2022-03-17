#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutputEmpController : ControllerBase
    {
        private readonly WebApplication1Context _context;

        public OutputEmpController(WebApplication1Context context)
        {
            _context = context;
        }

        // Post: api/OutputEmp
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee(Employee employee)
        {

            string StoredProc = "exec GetdetByID " +
            "@e_ID = '" + employee.Emp_ID + "'," +
            "@Emp_Name = '" + employee.Emp_Name + "'," +
            "@Designation= '" + employee.Designation + "'," +
            "@Location= '" + employee.Location + "'," +
            "@DOJ= '" + employee.Doj + "'," +
            "@LWD= '" + employee.Lwd + "'," +
            "@Vertical_L2= '" + employee.Vertical_L2 + "'," +
            "@Email_ID= '" + employee.Email_ID + "'," +
            "@RM_Emp_ID= '" + employee.Rm_Emp_ID + "'," +
            "@Band= '" + employee.Band + "'," +
            "@Level= '" + employee.Level + "'," +
            "@Role_ID= '" + employee.Role_ID + "'"
             ;


            return await _context.Employee.FromSqlRaw(StoredProc).ToListAsync();
            //return await _context.Employee.ToListAsync();
        }


    }
}

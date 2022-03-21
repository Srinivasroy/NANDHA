#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Net;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class OutputEmpController : ControllerBase
    {
        private readonly WebApplication1Context _context;
        private readonly WebApplication1ContextProcedures _procedures;
        public OutputEmpController(WebApplication1Context context)
        {
            _context = context;
        }


    // GET: api/OutputEmp
    [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee(string id)
        {
            string StoredProc = "exec GetdetByID " +
            "@e_ID = '" + id + "'" 
            //+
            //"," +
            //"@Emp_Name = '" + employee.Emp_Name + "'," +
            //"@Designation= '" + employee.Designation + "'," +
            //"@Location= '" + employee.Location + "'," +
            //"@DOJ= '" + employee.Doj + "'," +
            //"@LWD= '" + employee.Lwd + "'," +
            //"@Vertical_L2= '" + employee.Vertical_L2 + "'," +
            //"@Email_ID= '" + employee.Email_ID + "'," +
            //"@RM_Emp_ID= '" + employee.Rm_Emp_ID + "'," +
            //"@Band= '" + employee.Band + "'," +
            //"@Level= '" + employee.Level + "'," +
            //"@Role_ID= '" + employee.Role_ID + "'"
            ;


            return await _context.Employee.FromSqlRaw(StoredProc).ToListAsync();

        }

        // POST: api/Stored
        //[HttpPost]

        //public HttpResponseMessage Post(Employee employee)
        //{
        //    try
        //    {
        //        _procedures.POSTAsync(employee.Emp_ID, employee.Emp_Name, employee.Designation, employee.Location, employee.Doj, employee.Lwd, employee.Vertical_L2, employee.Email_ID,  employee.Rm_Emp_ID, employee.Band, employee.Level, employee.Role_ID, null);
        //        return new HttpResponseMessage(HttpStatusCode.OK);
        //    }
        //    catch (Exception)
        //    {
        //        return new HttpResponseMessage(HttpStatusCode.BadRequest);
        //    }
        //}




        //public HttpResponseMessage Post(std_dtl value)
        //{
        //    try
        //    {
        //        ob.API_CALL_STDDTL1(value.MODE, null, value.Address, value.City, value.District, value.Country, value.Student_Name, value.Student_Age, value.Student_Gender, value.Student_Religion, null);
        //        return new HttpResponseMessage(HttpStatusCode.OK);
        //    }
        //    catch (Exception)
        //    {
        //        return new HttpResponseMessage(HttpStatusCode.BadRequest);
        //    }
        //}
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Employee>>> PostEmployee(Employee employee)
        {

            string StoredProc = "exec POST " +
           "@Emp_ID = '" + employee.Emp_ID + "'," +
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

            // return null;
            return await _context.Employee.FromSqlRaw(StoredProc).ToListAsync();
        }

            //        //SqlCommand objCommand = new SqlCommand("POST", Conn);
            //        //objCommand.CommandType = CommandType.StoredProcedure;
            //        //objCommand.Parameters.AddWithValue("@Emp_ID", employee.Emp_ID);
            //        //objCommand.Parameters.AddWithValue("@Emp_Name", employee.Emp_Name);
            //        //objCommand.Parameters.AddWithValue("@Designation", employee.Designation);
            //        //objCommand.Parameters.AddWithValue("@Location", employee.Location);
            //        //objCommand.Parameters.AddWithValue("@Doj", employee.Doj);
            //        //objCommand.Parameters.AddWithValue("@Lwd", employee.Lwd);
            //        //objCommand.Parameters.AddWithValue("@VerticalL2", employee.Vertical_L2);
            //        //objCommand.Parameters.AddWithValue("@Email_ID", employee.Email_ID);
            //        //objCommand.Parameters.AddWithValue("@Rm_Emp_ID", employee.Rm_Emp_ID);
            //        //objCommand.Parameters.AddWithValue("@Band", employee.Band);
            //        //objCommand.Parameters.AddWithValue("@Level", employee.Level);
            //        //objCommand.Parameters.AddWithValue("@Role_ID", employee.Role_ID);


            //        //result = Convert.ToInt32(StoredProc.ExecuteScalar());

            //        //if (result > 0)
            //        //{
            //        //    return result;
            //        //}
            //        //else
            //        //{
            //        //    return 0;
            //        //}
            //    //}
            //    //catch
            //    //{
            //    //    throw;
            //    //}
            //    //finally
            //    //{
            //    //    if (Conn != null)
            //    //    {
            //    //        if (Conn.State == ConnectionState.Open)
            //    //        {
            //    //            Conn.Close();
            //    //            Conn.Dispose();
            //    //        }
            //    //    }
            //    //}
            //}
        }



    }

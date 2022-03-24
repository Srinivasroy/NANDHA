using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        DB dbop = new DB();
        string msg = string.Empty;


        // GET: api/<EmpController>
        [HttpGet]
        public List<Employee> Get()
        {
            Employee em = new Employee();
            em.type = "get";
            DataSet dS = dbop.EmployeeGet(em);
            List<Employee> list = new List<Employee>();


            foreach (DataRow dr in dS.Tables[0].Rows)
            {
                list.Add(new Employee
                {
                    Emp_ID = ((string)dr["Emp_ID"]),
                    Emp_Name = dr["Emp_Name"].ToString(),
                    Designation = dr["Designation"].ToString(),
                    Location = dr["Location"].ToString(),
                    Doj = (DateTime)dr["Doj"],
                    Lwd = (DateTime)dr["Lwd"],
                    Vertical_L2 = dr["Vertical_L2"].ToString(),
                    Email_ID = dr["Email_ID"].ToString(),
                    Rm_Emp_ID = dr["Rm_Emp_ID"].ToString(),
                    Band = dr["Band"].ToString(),
                    Level = dr["Level"].ToString(),
                    Role_ID = dr["Role_ID"].ToString(),

                });
            }
            return list;

        }





        // GET api/<EmpController>/5
        [HttpGet("{id}")]
        public List<Employee> Get(string id)
        {

            Employee em = new Employee();
            em.Emp_ID = id;
            em.type = "getid";
            DataSet dS = dbop.EmployeeGet(em);
            List<Employee> list = new List<Employee>();

            foreach (DataRow dr in dS.Tables[0].Rows)
            {
                list.Add(new Employee
                {
                    Emp_ID = ((string)dr["Emp_ID"]),
                    Emp_Name = dr["Emp_Name"].ToString(),
                    Designation = dr["Designation"].ToString(),
                    Location = dr["Location"].ToString(),
                    Doj = (DateTime)dr["Doj"],
                    Lwd = (DateTime)dr["Lwd"],
                    Vertical_L2 = dr["Vertical_L2"].ToString(),
                    Email_ID = dr["Email_ID"].ToString(),
                    Rm_Emp_ID = dr["Rm_Emp_ID"].ToString(),
                    Band = dr["Band"].ToString(),
                    Level = dr["Level"].ToString(),
                    Role_ID = dr["Role_ID"].ToString(),

                });
            }
            return list;

        }

        // POST api/<EmpController>
        [HttpPost]
        public string Post([FromBody] Employee em)
        {
            string msg = string.Empty;
            em.type = "insert";
            try
            {
                msg = dbop.EmployeeOpt(em);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        [HttpPut("{id}")]
        public string Put(string id, [FromBody] Employee em)
        {
            string msg = string.Empty;
            em.type = "update";
            try
            {
                em.Emp_ID = id;
                msg = dbop.EmployeeOpt(em);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        // DELETE api/<EmpController>/5
        [HttpDelete("{id}")]
        public string Delete(string id, [FromBody] Employee em)
        {
            string msg = string.Empty;
            em.type = "delete";
            try
            {
                em.Emp_ID = id;
                msg = dbop.EmployeeOpt(em);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;

        }
    }
}

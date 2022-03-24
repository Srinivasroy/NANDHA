using Microsoft.Data.SqlClient;
using System.Data;

namespace WebApplication1.Models
{
    public class DB
    {
        SqlConnection db = new SqlConnection("Data Source=DESKTOP-GQHCKII\\SQLEXPRESS;Initial Catalog=TRIMMS;Integrated Security=True;");



        public string EmployeeOpt(Employee emp)
        {
            string msg = string.Empty;
            try
            {
                SqlCommand com = new SqlCommand("Sp_Employee", db);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Emp_ID", emp.Emp_ID);
                com.Parameters.AddWithValue("@Emp_Name", emp.Emp_Name);
                com.Parameters.AddWithValue("@Designation", emp.Designation);
                com.Parameters.AddWithValue("@Location", emp.Location);
                com.Parameters.AddWithValue("@DOJ", emp.Doj);
                com.Parameters.AddWithValue("@LWD", emp.Lwd);
                com.Parameters.AddWithValue("@Vertical_L2", emp.Vertical_L2);
                com.Parameters.AddWithValue("@Email_ID", emp.Email_ID);
                com.Parameters.AddWithValue("@RM_Emp_ID", emp.Rm_Emp_ID);
                com.Parameters.AddWithValue("@Band", emp.Band);
                com.Parameters.AddWithValue("@Level", emp.Level);
                com.Parameters.AddWithValue("@Role_ID", emp.Role_ID);
                com.Parameters.AddWithValue("@type", emp.type);
                db.Open();
                com.ExecuteNonQuery();
                db.Close();
                msg = "Success";
            }
            catch (Exception ex)
            {
                msg = ex.Message;

            }
            finally
            {
                if (db.State == ConnectionState.Open)
                {
                    db.Close();
                }


            }
            return msg;
        }

        //GET
        public DataSet EmployeeGet(Employee emp)
        {
           string msg = string.Empty;
            DataSet ds = new DataSet();
            try
            {
                SqlCommand com = new SqlCommand("Sp_Employee", db);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@Emp_ID", emp.Emp_ID);
                com.Parameters.AddWithValue("@Emp_Name", emp.Emp_Name);
                com.Parameters.AddWithValue("@Designation", emp.Designation);
                com.Parameters.AddWithValue("@Location", emp.Location);
                com.Parameters.AddWithValue("@DOJ", emp.Doj);
                com.Parameters.AddWithValue("@LWD", emp.Lwd);
                com.Parameters.AddWithValue("@Vertical_L2", emp.Vertical_L2);
                com.Parameters.AddWithValue("@Email_ID", emp.Email_ID);
                com.Parameters.AddWithValue("@RM_Emp_ID", emp.Rm_Emp_ID);
                com.Parameters.AddWithValue("@Band", emp.Band);
                com.Parameters.AddWithValue("@Level", emp.Level);
                com.Parameters.AddWithValue("@Role_ID", emp.Role_ID);
                com.Parameters.AddWithValue("@type", emp.type);

                //db.Open();
                //com.ExecuteNonQuery();
                
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);

                msg = "Success";
            }
            catch (Exception ex)
            {
                msg = ex.Message;

            }

            return ds;
        }



    

    //public DataSet EmployeeGetAllEmp()
    //{
    //   String msg = string.Empty;
    //    DataSet ds = new DataSet();
    //    try
    //    {
    //        SqlCommand com = new SqlCommand("Sp_Employee", db);
    //        com.CommandType = CommandType.StoredProcedure;
      
           


    //        SqlDataAdapter da = new SqlDataAdapter(com);
    //        da.Fill(ds);

    //        msg = "Success";
    //    }
    //    catch (Exception ex)
    //    {
    //        msg = ex.Message;

    //    }

    //    return ds;
    //}
}

}
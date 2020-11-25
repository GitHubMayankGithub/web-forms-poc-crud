using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace web_forms_poc.MODEL
{
    public class EmployeeBL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString;


        public void Add(Employee e)
        {

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
               
                SqlCommand cmd = new SqlCommand("insert into EmployeeNew1 values('Emp123','Software Engineer123')", sqlConnection);
                cmd.CommandType = CommandType.Text;
               // cmd.Parameters.Add("@EmpId",SqlDbType.VarChar, 50)=e.EmpId;
               // cmd.Parameters.Add("Designation",SqlDbType.VarChar, 50)=e.Designation;

                sqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class EmployeeDetail_DAL
    {


        public string GetConnString()
        {
            return @"data source=DESKTOP-K2EJV83; initial catalog=EmployeeDetails; integrated security=true";
        }


        public int SaveEmployeeDetail(EmployeeDetail_Model model)
        {
            int result = 0;
            string StrCon = GetConnString();
            SqlConnection conn = new SqlConnection(StrCon);
            SqlCommand cmd = new SqlCommand("InsertEmployeeDetail", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
            cmd.Parameters.AddWithValue("@LastName", model.LastName);
            cmd.Parameters.AddWithValue("@DOB", model.DOB);
            cmd.Parameters.AddWithValue("@Gender", model.Gender);
            cmd.Parameters.AddWithValue("@MaritalStatus", model.MaritalStatus);
            cmd.Parameters.AddWithValue("@Country", model.Country);
            cmd.Parameters.AddWithValue("@State", model.State);
            cmd.Parameters.AddWithValue("@Address", model.Address);
            cmd.Parameters.AddWithValue("@Hobbies", model.Hobbies);

            SqlParameter EmpId = new SqlParameter();
            EmpId.ParameterName = "@EmpId";
            EmpId.SqlDbType = SqlDbType.Int;
            EmpId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(EmpId);

            cmd.ExecuteNonQuery();

            int getEmpId = Convert.ToInt32(EmpId.Value.ToString());

            return result = getEmpId;

        }

        public DataTable FillFirstName()
        {
            string strconn = GetConnString();
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand("FillFirstName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public DataTable SearchEmployeeDetail(int EmpId)
        {
            string strconn = GetConnString();
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand("SearchEmployeeDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", DbType.Int32).Value = EmpId;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;


        }

        public int UpdateEmployeeDetail(EmployeeDetail_Model model)
        {
            int result = 0;
            string StrCon = GetConnString();
            SqlConnection conn = new SqlConnection(StrCon);
            SqlCommand cmd = new SqlCommand("UpdateEmployeeDetails", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmpId", model.EmpId);
            cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
            cmd.Parameters.AddWithValue("@LastName", model.LastName);
            cmd.Parameters.AddWithValue("@DOB", model.DOB);
            cmd.Parameters.AddWithValue("@Gender", model.Gender);
            cmd.Parameters.AddWithValue("@MaritalStatus", model.MaritalStatus);
            cmd.Parameters.AddWithValue("@Country", model.Country);
            cmd.Parameters.AddWithValue("@State", model.State);
            cmd.Parameters.AddWithValue("@Address", model.Address);
            cmd.Parameters.AddWithValue("@Hobbies", model.Hobbies);

            
            cmd.ExecuteNonQuery();
            result = 1;


            return result;

        }


        public int DeleteEmployeeDetail(EmployeeDetail_Model model)
        {
            int result = 0;
            string StrCon = GetConnString();
            SqlConnection conn = new SqlConnection(StrCon);
            SqlCommand cmd = new SqlCommand("DeleteEmployeeDetail", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmpId", model.EmpId);
            cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
            cmd.Parameters.AddWithValue("@LastName", model.LastName);
            cmd.Parameters.AddWithValue("@DOB", model.DOB);
            cmd.Parameters.AddWithValue("@Gender", model.Gender);
            cmd.Parameters.AddWithValue("@MaritalStatus", model.MaritalStatus);
            cmd.Parameters.AddWithValue("@Country", model.Country);
            cmd.Parameters.AddWithValue("@State", model.State);
            cmd.Parameters.AddWithValue("@Address", model.Address);
            cmd.Parameters.AddWithValue("@Hobbies", model.Hobbies);


            cmd.ExecuteNonQuery();
            result = 1;


            return result;

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseLayer
{
    public class clsDataLayer
    {
        private string conn = ConfigurationManager.ConnectionStrings["FishLandDBEntities"].ToString();

        public void InsertUpdateDeleteSQLString(string sqlstring)
        {

            try
            {
                SqlConnection objsqlconn = new SqlConnection(conn);
                objsqlconn.Open();
                SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
                objcmd.ExecuteNonQuery();
            }
            catch (ArgumentException e)
            {
               
            }
        }

        public object ExecuteSqlString(string sqlstring)
        {

            SqlConnection objsqlconn = new SqlConnection(conn);
            objsqlconn.Open();
            DataSet ds = new DataSet();
            SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
            SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
            objAdp.Fill(ds);
            return ds;
        }

        public void AddUserDB(string user_name, string user_surname, string user_DOB, string user_cell, string user_email, string user_address)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into user (name, surname, dateOfBirth, cellphone, email, address) VALUES ('" + user_name + "','" + user_surname + "','" + user_DOB + "','" + user_cell + "','" + user_email + "','" + user_address + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateUserDB(int user_id, string user_name, string user_surname, string user_DOB, string user_cell, string user_email, string user_address)
        {
            DataSet ds = new DataSet();
            string sql = "Update user set name='" + user_name + "',surname='" + user_surname + "',dateOfBirth='" + user_DOB + "'cellphone='" + user_cell + "',email='" + user_email + "',address='" + user_address + "' Where userID='" + user_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteUserDB(int user_id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from User Where userID='" + user_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public object RetrieveUserDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from user order by userID";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }

    }
}

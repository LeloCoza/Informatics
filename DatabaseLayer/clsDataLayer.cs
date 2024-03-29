﻿using System;
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
            try { 

                SqlConnection objsqlconn = new SqlConnection(conn);
                objsqlconn.Open();
                SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
                objcmd.ExecuteNonQuery();
            } catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
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

        public void AddActorDB(int actor_id, string actor_name, string actor_surname, string actor_DOB, string actor_cell, string actor_email, string actor_address)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Actor (Name, Surname, DateOfBirth, Cellphone, Email, Address) VALUES ('" + actor_name + "','" + actor_surname + "','" + actor_DOB + "','" + actor_cell + "','" + actor_email + "','" + actor_address + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateActorDB(int actor_id, string actor_name, string actor_surname, string actor_DOB, string actor_cell, string actor_email, string actor_address)
        {
            DataSet ds = new DataSet();
            string sql = "Update Actor set Name='" + actor_name + "',Surname='" + actor_surname + "',DateOfBirth='" + actor_DOB + "'Cellphone='" + actor_cell + "',Email='" + actor_email + "',Address='" + actor_address + "' Where ActorID='" + actor_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteActorDB(int actor_id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Actor Where ActorID='" + actor_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public object RetrieveActorDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Actor order by ActorID";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }

    }
}

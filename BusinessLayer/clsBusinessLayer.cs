using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;

namespace BusinessLayer
{
    public class clsBusinessLayer
    {
        public clsDataLayer objDataLayer = new clsDataLayer();

        public void AddUser(string user_name, string user_surname, string user_DOB, string user_cell, string user_email, string user_address)
        {
            objDataLayer.AddUserDB(user_name, user_surname, user_DOB, user_cell, user_email, user_address);
        }

        public void UpdateUser(int user_id, string user_name, string user_surname, string user_DOB, string user_cell, string user_email, string user_address)
        {
            objDataLayer.UpdateUserDB(user_id, user_name, user_surname, user_DOB, user_cell, user_email, user_address); 
        }

        public void DeleteUser(int user_id)
        {
            objDataLayer.DeleteUserDB(user_id);
        }

        public object RetrieveUser()
        {
            return objDataLayer.RetrieveUserDB();
        }
    }
}

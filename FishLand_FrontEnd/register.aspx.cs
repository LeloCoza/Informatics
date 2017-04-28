using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;  //to access clsBusinessLayer

namespace FishLand_FrontEnd
{
    public partial class register : System.Web.UI.Page
    {
        clsBusinessLayer objLogic;

        protected void Page_Load(object sender, EventArgs e)
        {
            objLogic = new clsBusinessLayer();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            objLogic = new clsBusinessLayer();

            objLogic.AddUser(txtName.Text, txtSurname.Text, txtDOB.Text, txtCellphone.Text, txtEmail.Text, txtAddress.Text);
            
        }
    }
}
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
    }
}

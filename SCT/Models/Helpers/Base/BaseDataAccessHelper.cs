using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SCT.Models.Helpers
{
    public class BaseDataAccessHelper : IBaseDataAccessHelper
    {
        string connectionString;

        public void SetConnectionString()
        {
            connectionString = "server=127.0.0.1;uid=sa;password=ThsdhqmCGSY!!;database=NABAKEM";
        }

        
    }
}
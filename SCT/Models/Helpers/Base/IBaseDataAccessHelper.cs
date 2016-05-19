using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCT.Models.Helpers
{
    public interface IBaseDataAccessHelper
    {
        string GetConnectionString();
        
        void SetConnectionString();
    }
}
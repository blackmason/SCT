using SCT.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCT.Models.Helpers
{
    public interface IMenuHelper
    {
        IBaseDataAccessHelper GetBaseDA();

        void SetBaseDA(IBaseDataAccessHelper baseDA);

        List<Menu> GetAllMenus();

        void AddMenu(string code, string parentCode, string name, string url);

        void UpdateMenu(string code);

        void DeleteMenu(string code);
    }
}
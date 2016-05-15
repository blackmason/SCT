using SCT.Models.Domains;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SCT.Models.Helpers
{
    public class MenuHelper : IMenuHelper
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        
        private IBaseDataAccessHelper baseDA;
        public MenuHelper(BaseDataAccessHelper baseDA)
        {
            this.baseDA = baseDA;
        }

        public MenuHelper() { }

        /* 전체메뉴 가져오기 */
        public List<Menu> GetAllMenus()
        {
            string sql = "SELECT CODE, P_CODE, NAME, ROLE FROM MENUS";

            Menu menus;
            List<Menu> menuList = new List<Menu>();
            baseDA.SetConnectionString();

            using(connection = new SqlConnection())
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    menus = new Menu();
                    menus.Code = reader[0].ToString();
                    menus.ParentCode = reader[1].ToString();
                    menus.Name = reader[2].ToString();
                    menus.Role = reader[3].ToString();
                    menuList.Add(menus);
                }
                connection.Close();
            }
            return menuList;
        }

        public void AddMenu(string code, string parentCode, string name, string url)
        {
            throw new NotImplementedException();
        }

        public void UpdateMenu(string code)
        {
            throw new NotImplementedException();
        }

        public void DeleteMenu(string code)
        {
            throw new NotImplementedException();
        }
    }
}
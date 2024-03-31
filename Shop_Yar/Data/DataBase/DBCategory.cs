using MySql.Data.MySqlClient;
using Shop_Yar.Data.Common;
using Shop_Yar.Data.Interfaces;
using Shop_Yar.Data.Models;
using System.Collections.Generic;

namespace Shop_Yar.Data.DataBase
{
    public class DBCategory : ICategorys
    {
        public IEnumerable<Categorys> AllCategorys
        {
            get
            {
                List<Categorys> categorys = new List<Categorys>();
                MySqlConnection mySqlConnection = Connection.MySqlOpen();
                MySqlDataReader CategorysData = Connection.MySqlQuery("SELECT * FROM Shop.Categorys ORDER NY `Name`;", MySqlConnection);
                while (CategorysData.Read())
                {
                    categorys.Add(new Categorys()
                    {
                        Id = CategorysData.IsDBNull(0) ? -1 : CategorysData.GetInt32(0),
                        Name = CategorysData.IsDBNull(1) ? null : CategorysData.GetString(1),
                        Description = CategorysData.IsDBNull(2) ? null : CategorysData.GetString(2)
                    });
                }
                return categorys;
            }
        }
    }
}

using System;
using MySql.Data.EntityFramework;

namespace ListaShop.Model.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MysqlContextEntity
    {
        public MysqlContextEntity()
        {
        }
    }
}

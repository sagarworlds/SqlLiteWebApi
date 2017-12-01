using SqliteORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqlLiteWebAPI.Models
{
    [Table]
    public class auth_user_user_permissions : TableBase<auth_user_user_permissions>
    {
        [PrimaryKey]
        public int id { get; set; }
        [Field]
        public int user_id { get; set; }
        [Field]
        public int permission_id { get; set; }

    }
}
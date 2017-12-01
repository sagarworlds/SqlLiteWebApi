using SqliteORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqlLiteWebAPI.Models
{
    [Table]
    public class auth_user : TableBase<auth_user>
    {
        [PrimaryKey]
        public int id { get; set; }
        [Field]
        public string password { get; set; }
        [Field]
        public bool is_superuser { get; set; }
        [Field]
        public string username { get; set; }
        [Field]
        public string first_name { get; set; }
        [Field]
        public string last_name { get; set; }
        [Field]
        public string email { get; set; }
        [Field]
        public bool is_staff { get; set; }
        [Field]
        public bool is_active { get; set; }
        [Field]
        public DateTime date_joined { get; set; }
        [Field]
        public DateTime last_login { get; set; }
    }
}
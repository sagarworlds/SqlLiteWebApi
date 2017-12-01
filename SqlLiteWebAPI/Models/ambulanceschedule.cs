using SqliteORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqlLiteWebAPI.Models
{
    [Table("rtc_ambulanceschedule")]
    public class ambulanceschedule : TableBase<ambulanceschedule>
    {
        [PrimaryKey]
        public int id { get; set; }
        [Field]
        public string Day { get; set; }
        [Field]
        public string Time { get; set; }
        [Field]
        public bool Availability { get; set; }
        [Field]
        public int Count { get; set; }
        

    }
}
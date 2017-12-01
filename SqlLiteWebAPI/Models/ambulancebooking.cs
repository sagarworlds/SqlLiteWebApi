using SqliteORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqlLiteWebAPI.Models
{
    [Table("rtc_ambulancebooking")]
    public class ambulancebooking : TableBase<ambulancebooking>
    {
        [PrimaryKey]
        public int id { get; set; }
        [Field]
        public string Source { get; set; }
        [Field]
        public string Destination { get; set; }
        [Field]
        public DateTime DateBooked { get; set; }
        [Field]
        public string Purpose { get; set; }
        [Field]
        public string Day { get; set; }
        [Field]
        public string Time { get; set; }

    }
}
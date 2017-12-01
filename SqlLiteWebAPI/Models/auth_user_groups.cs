using SqliteORM;

namespace SqlLiteWebAPI.Models
{
    [Table]
    public class auth_user_groups : TableBase<auth_user_groups>
    {
        [PrimaryKey]
        public int id { get; set; }
        [Field]
        public int user_id { get; set; }
        [Field]
        public int group_id { get; set; }
        
    }
}
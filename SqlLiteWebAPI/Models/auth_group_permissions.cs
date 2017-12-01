using SqliteORM;


namespace SqlLiteWebAPI.Models
{
    [Table]
    public class auth_group_permissions : TableBase<auth_group_permissions>
    {
        [PrimaryKey]
        public int id { get; set; }
        [Field]
        public int group_id { get; set; }
        [Field]
        public int permission_id { get; set; }
    }
}
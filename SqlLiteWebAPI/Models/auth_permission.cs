using SqliteORM;


namespace SqlLiteWebAPI.Models
{
    [Table]
    public class auth_permission : TableBase<auth_permission>
    {
        [PrimaryKey]
        public int id { get; set; }
        [Field]
        public int content_type_id { get; set; }
        [Field]
        public string codename { get; set; }
    }
}
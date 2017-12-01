using SqliteORM;


namespace SqlLiteWebAPI.Models
{
    [Table]
    public class auth_group : TableBase<auth_group>
    {
        [PrimaryKey]
        public int id { get; set; }
        [Field]
        public string name { get; set; }
    }
}
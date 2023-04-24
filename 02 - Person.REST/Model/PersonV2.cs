using System.ComponentModel.DataAnnotations.Schema;

namespace _02___Person.REST.Model
{
    [Table("person")]
    public class PersonV2
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("address")]
        public string Address { get; set; }      
    }
}

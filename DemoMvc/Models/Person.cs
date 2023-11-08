using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DemoMvc.Models{
    [Table("Persons")]  
    public class Person{
        [Key]
        public String PersonID { get; set; }
        public String FullName { get; set; }
        public String Address { get; set; }
        public String PhoneNumber { get; set; }
    }
}
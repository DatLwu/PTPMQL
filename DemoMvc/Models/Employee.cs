using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DemoMvc.Models{
    [Table("Employee")]  
  
    public class Employee : Person{
        [Key]
         public String PersonID { get; set; }
        public String FullName { get; set; }
        public String EmployeeID { get; set; }
        public int  Age  { get; set; }
    }
}
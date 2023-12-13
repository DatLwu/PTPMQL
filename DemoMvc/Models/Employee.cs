using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DemoMvc.Models{ 
  
    public class Employee : Person{
      
         public String PersonID { get; set; }
        public String FullName { get; set; }
        public String EmployeeID { get; set; }
        public int  Age  { get; set; }
    }
}
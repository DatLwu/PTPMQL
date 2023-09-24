using System.Security.Cryptography.X509Certificates;

namespace newApp.models{
    public class Person{
        public string PersonID { get; set; }
        public string FullName { get; set; }
        public void Nhap(){
            System.Console.Write("PersonID: ");
            PersonID = Console.ReadLine();
            System.Console.Write("FullName: ");
            FullName = Console.ReadLine();
            
        }
        public void Xuat(){
            System.Console.Write(PersonID + "-" + FullName);
        }

        
    }
        
    
}

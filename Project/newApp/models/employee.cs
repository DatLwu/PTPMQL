namespace newApp.models{
    public class Employee : Person{
        public string PersonID { get; set; }
        public string FullName { get; set; }
        public string employeeCODE { get; set; }
        
        public void Nhap(){
            base.Nhap();
            System.Console.Write("employeeCODE: ");
            employeeCODE = Console.ReadLine();
        }
        public void Xuat(){
            base.Xuat();
            System.Console.Write("-" + employeeCODE);
            
        }

    }
}
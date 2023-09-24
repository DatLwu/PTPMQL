namespace newApp.models{
    public class Fruit{
        public string LoaiQua { get; set; }
        public string CanNang { get; set; }
        public void NhapTT(){
            System.Console.Write("Loai qua: ");
            LoaiQua = Console.ReadLine();
            System.Console.Write("Can nang: ");
            CanNang = Console.ReadLine();
            
        }
        public void XuatTT(){
            System.Console.Write("Loai qua: " + LoaiQua + " - " + "Can nang: " + CanNang);
        }

        
    }
        
    
}

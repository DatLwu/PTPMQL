namespace newApp.models{
    public class Fruit2 : Fruit{
        public string LoaiQua { get; set; }
        public string CanNang { get; set; }
        public string XuatXu { get; set; }
        
        public void NhapTT(){
            base.NhapTT();
            System.Console.Write("xuat xu: ");
            XuatXu = Console.ReadLine();
        }
        public void XuatTT(){
            base.XuatTT();
            System.Console.Write(" - " + "Xuat xu: " + XuatXu);
            
        }

    }
}
namespace DemoMvc.Models{
    public class HeThongPhanPhoi{
        public String MaHTPP { get; set; }
        public String TenHTPP { get; set; }
        public ICollection<DaiLy>? Daily {get; set;}
    }
}
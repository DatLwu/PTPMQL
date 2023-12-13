using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models{
    public class DaiLy{
        public String MaDaiLy { get; set; }
        public String TenDaiLy { get; set; }
        public String DiaChi { get; set; }
        public String NguoiDaiDien { get; set; }
        public String DienThoai { get; set; }
         public String MaHTPP { get; set; }
         [ForeignKey("MaHTPP")]
         public HeThongPhanPhoi? HeThongPhanPhoi {get; set ;}
    }
}
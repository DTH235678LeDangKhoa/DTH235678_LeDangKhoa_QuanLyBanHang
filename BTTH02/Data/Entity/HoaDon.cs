using Microsoft.EntityFrameworkCore.ChangeTracking;
<<<<<<< HEAD
using QuanLyBanHang.Data;
=======
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> c6ee281d673705ebf1dd91506a80d4f895d8f502

namespace QuanLyBanHang.Data.Entity
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
<<<<<<< HEAD
=======

    [NotMapped]
>>>>>>> c6ee281d673705ebf1dd91506a80d4f895d8f502
    public class DanhSachHoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
<<<<<<< HEAD
        public string HoVaTenNhanVien { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public string? XemChiTiet { get; set; }
        public int? TongTienHoaDon { get; set; }
        public string HoVaTenKhachHang { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayLap { get; set; }
=======
        public string HoVaTenNhanVien { get; set; } // Thêm
        public int KhachHangID { get; set; }
        public string HoVaTenKhachHang { get; set; } // Thêm
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public string? XemChiTiet { get; set; } // Thêm
        public double? TongTienHoaDon { get; set; } // Thêm
>>>>>>> c6ee281d673705ebf1dd91506a80d4f895d8f502
    }

}


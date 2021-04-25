using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string IdNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string ChucVu { get; set; }
        public string TienLuong { get; set; }
        public string TienThuong { get; set; }
    }
}
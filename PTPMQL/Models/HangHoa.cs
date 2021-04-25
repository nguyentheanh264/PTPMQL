using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTPMQL.Models
{
    [Table("HangHoas")]
    public class HangHoa
    {
        [Key]
        public string MaHangHoa { get; set; }
        public string PhanLoai { get; set; }
      [AllowHtml]
        public string Ten { get; set; }
        public string GiaBan { get; set; }
        public string SLBan { get; set; }
        public string SLTon { get; set; }
    }
}
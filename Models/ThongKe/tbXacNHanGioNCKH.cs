using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models.QLKHCanBo;

[Table("tbXacNHanGioNCKH")]
public partial class tbXacNhanGioNCKH
{
    [Key]
    public int IdXacNhanGioNCKH { get; set; }

    public int? IdDonVi { get; set; }

    public string? NamHoc { get; set; }

    public int? IdCanBoXacNhan{ get; set; }

    public string? FileTongHop { get; set; }

    public DateOnly? NgayXacNhan { get; set; }

}

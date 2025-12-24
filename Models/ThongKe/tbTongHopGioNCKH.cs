using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IDC.Frontend.Services.Abstractions;
using QLCongViec.Services;

namespace api.Models.QLKHCanBo;

[ApiEndpoint("api/tonghopgionckh", ApiEndpoints.QLKH)]
[Table("tbTongHopGioNCKH")]

public partial class tbTongHopGioNCKH
{
    [Key]
    public int IdTongHopGioNCKH { get; set; }

    public int? IdCanBo { get; set; }

    public int? IdDonVi { get; set; }

    public string? NamHoc { get; set; }

    public int? IdCanBoTongHop { get; set; }

    public DateOnly? NgayTongHop { get; set; }

    public string? FileTongHop { get; set; }

    public DateOnly? NgayXacNhan { get; set; }

    public int? SoGioNCKH { get; set; }
}

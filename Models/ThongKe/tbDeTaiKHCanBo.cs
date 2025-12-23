using System;
using System.Collections.Generic;

namespace  api.Models.QLKHCanBo;
[ApiEndpoint("api/de-tai-kh-can-bo", ApiEndpoints.QLKH)]

public partial class tbDeTaiKHCanBo
{
    public int IdDeTaiKHCanBo { get; set; }

    public string? MaSo { get; set; }

    public string? TenDeTai { get; set; }

    public int? IdLinhVuc { get; set; }

    public string? DonViChuTri { get; set; }

    public int? IdCapDeTai { get; set; }

    public DateOnly? HanHoanThanh { get; set; }

    public string? NamHoc { get; set; }

    public int? TongKinhPhi { get; set; }

    public string? SQDXetChon { get; set; }

    public DateOnly? NgayXetChon { get; set; }

    public string? SoHopDong { get; set; }

    public DateOnly? NgayKyHopDong { get; set; }

    public string? SQDNghiemThu { get; set; }

    public DateOnly? NgayNghiemThu { get; set; }

    public int? IdTinhTrangDeTaiKHCB { get; set; }

    public string? XepLoai { get; set; }

    public string? LoaiDeTai { get; set; }

    public string? DonViThamGia { get; set; }

    public int? NguonThuTuChuyenGiaoCongNghe { get; set; }
}

﻿using System;
using System.Collections.Generic;

namespace QLThuVien.Models;

public partial class NhanVien
{
    public string MaNhanVien { get; set; } = null!;

    public string? TenNhanVien { get; set; }

    public string? DiaChi { get; set; }

    public string? GioiTinh { get; set; }

    public string? Que { get; set; }

    public string? Sdt { get; set; }

    public string? CaLam { get; set; }

    public string? Username { get; set; }

    public virtual ICollection<HoSoTra> HoSoTras { get; } = new List<HoSoTra>();

    public virtual ICollection<PhieuMuon> PhieuMuons { get; } = new List<PhieuMuon>();

    public virtual User? UsernameNavigation { get; set; }
}

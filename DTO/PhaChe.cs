//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhaChe
    {
        public string MaDoUong { get; set; }
        public string MaNguyenLieu { get; set; }
        public Nullable<int> DinhLuong { get; set; }
        public string DonViTinh { get; set; }
    
        public virtual DoUong DoUong { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}

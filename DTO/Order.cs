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
    
    public partial class Order
    {
        public int ID { get; set; }
        public Nullable<int> SoBan { get; set; }
        public string MaDoUong { get; set; }
        public Nullable<int> SoLuongS { get; set; }
        public Nullable<int> SoLuongM { get; set; }
        public Nullable<int> SoLuongL { get; set; }
    
        public virtual DoUong DoUong { get; set; }
        public virtual TrangThaiBan TrangThaiBan { get; set; }
    }
}

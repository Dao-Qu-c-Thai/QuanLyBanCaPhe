//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCF_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETHOADON
    {
        public int id { get; set; }
        public int MAHD { get; set; }
        public int MA_THUC_UONG { get; set; }
        public Nullable<int> SOLUONG { get; set; }
    
        public virtual HOADON HOADON { get; set; }
        public virtual THUC_UONG THUC_UONG { get; set; }
    }
}

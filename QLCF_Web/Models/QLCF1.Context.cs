﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QUANLYCAPHE1Entities3 : DbContext
    {
        public QUANLYCAPHE1Entities3()
            : base("name=QUANLYCAPHE1Entities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public DbSet<BAN> BANs { get; set; }
        public DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public DbSet<DANGNHAP> DANGNHAPs { get; set; }
        public DbSet<HOADON> HOADONs { get; set; }
        public DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public DbSet<KHUVUC> KHUVUCs { get; set; }
        public DbSet<LOAI_THUC_UONG> LOAI_THUC_UONG { get; set; }
        public DbSet<LOAIKH> LOAIKHs { get; set; }
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<THUC_UONG> THUC_UONG { get; set; }
    }
}

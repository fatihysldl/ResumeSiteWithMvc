﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResumeSiteWithMvc.Models.entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class resumeEntities1 : DbContext
    {
        public resumeEntities1()
            : base("name=resumeEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblDeneyimlerim> tblDeneyimlerim { get; set; }
        public virtual DbSet<tblEğitimleri> tblEğitimleri { get; set; }
        public virtual DbSet<tblHakkimda> tblHakkimda { get; set; }
        public virtual DbSet<tblHobilerim> tblHobilerim { get; set; }
        public virtual DbSet<tblIletisim> tblIletisim { get; set; }
        public virtual DbSet<tblSocialMedia> tblSocialMedia { get; set; }
        public virtual DbSet<tblProjeler> tblProjeler { get; set; }
        public virtual DbSet<tblFramework> tblFramework { get; set; }
        public virtual DbSet<tblIde> tblIde { get; set; }
        public virtual DbSet<tblProgramlamaDilleri> tblProgramlamaDilleri { get; set; }
        public virtual DbSet<tblVeriTabani> tblVeriTabani { get; set; }
        public virtual DbSet<tblAdminGiris> tblAdminGiris { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CvEntityProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBCVENTITYEntities : DbContext
    {
        public DBCVENTITYEntities()
            : base("name=DBCVENTITYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_AboutMe> tbl_AboutMe { get; set; }
        public virtual DbSet<tbl_Address> tbl_Address { get; set; }
        public virtual DbSet<tbl_Contact> tbl_Contact { get; set; }
        public virtual DbSet<tbl_MyWorks> tbl_MyWorks { get; set; }
        public virtual DbSet<tbl_Skills> tbl_Skills { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myStore_BackEnd.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mystoreEntities : DbContext
    {
        public mystoreEntities()
            : base("name=mystoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<kategori> kategoris { get; set; }
        public virtual DbSet<produk> produks { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<view_all_produk> view_all_produk { get; set; }
        public virtual DbSet<perusahaan> perusahaans { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _221_Belyaev_Up2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Belyaev_UP2Entities : DbContext
    {
        private static Belyaev_UP2Entities _context;

        public Belyaev_UP2Entities()
            : base("name=Belyaev_UP2Entities")
        {
        }
        public static Belyaev_UP2Entities GetContext()
        {
            if (_context == null)
            {
                _context = new Belyaev_UP2Entities();
            }
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MaterialType> MaterialType { get; set; }
        public virtual DbSet<PartnerProducts> PartnerProducts { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<PartnersType> PartnersType { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsType> ProductsType { get; set; }
    }
}

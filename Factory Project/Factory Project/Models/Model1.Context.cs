﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Factory_Project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FactoryDBEntities1 : DbContext
    {
        public FactoryDBEntities1()
            : base("name=FactoryDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeShift> EmployeeShifts { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<user_actions> user_actions { get; set; }
        public virtual DbSet<shift1> shift1 { get; set; }
    }
}

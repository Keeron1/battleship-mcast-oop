﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Battleship_DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BattleshipDatabaseEntities : DbContext
    {
        public BattleshipDatabaseEntities()
            : base("name=BattleshipDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attacks> Attacks { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<GameShipConfigurations> GameShipConfigurations { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Ships> Ships { get; set; }
    }
}

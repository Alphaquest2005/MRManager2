﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T4Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AmoebaDBEntities : DbContext
    {
        public AmoebaDBEntities()
            : base("name=AmoebaDBEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ApplicationEntity> ApplicationEntities { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<DataType> DataTypes { get; set; }
        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<EntityProperty> EntityProperties { get; set; }
        public virtual DbSet<EntityRelationship> EntityRelationships { get; set; }
        public virtual DbSet<ModelType> ModelTypes { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Layer> Layers { get; set; }
        public virtual DbSet<DataProperty> DataProperties { get; set; }
        public virtual DbSet<RelationshipType> RelationshipTypes { get; set; }
        public virtual DbSet<PresentationProperty> PresentationProperties { get; set; }
        public virtual DbSet<FunctionSet> FunctionSets { get; set; }
        public virtual DbSet<TestValue> TestValues { get; set; }
        public virtual DbSet<PrimaryKeyOption> PrimaryKeyOptions { get; set; }
        public virtual DbSet<EntityView> EntityViews { get; set; }
        public virtual DbSet<EntityViewPropertyFunction> EntityViewPropertyFunctions { get; set; }
        public virtual DbSet<EntityViewPropertyFunctionParameter> EntityViewPropertyFunctionParameters { get; set; }
        public virtual DbSet<FunctionBody> FunctionBodies { get; set; }
        public virtual DbSet<FunctionParameter> FunctionParameters { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<FunctionSetFunction> FunctionSetFunctions { get; set; }
        public virtual DbSet<Operator> Operators { get; set; }
        public virtual DbSet<Parameter> Parameters { get; set; }
        public virtual DbSet<FunctionReturnType> FunctionReturnTypes { get; set; }
        public virtual DbSet<EntityViewProperty> EntityViewProperties { get; set; }
    }
}

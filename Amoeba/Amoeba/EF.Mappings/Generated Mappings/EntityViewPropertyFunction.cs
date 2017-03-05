﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Mappings
{
	public class EntityViewPropertyFunctionMap
	{
		public static void Map(EntityTypeBuilder<EntityViewPropertyFunction> entityBuilder)
		{
			entityBuilder.ToTable("EntityViewPropertyFunction", "dbo");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").UseSqlServerIdentityColumn();	
			entityBuilder.Property(t => t.EntityViewPropertyId).HasColumnName("EntityViewPropertyId").IsRequired();
			entityBuilder.Property(t => t.FunctionId).HasColumnName("FunctionId").IsRequired();
		//-------------------Navigation Properties -------------------------------//
				entityBuilder.HasOne(p => p.EntityViewPropertyFunctionParameter).WithOne(p => p.EntityViewPropertyFunction).HasForeignKey<EntityViewPropertyFunctionParameter>(c => c.Id).OnDelete(DeleteBehavior.Restrict);
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.EntityViewProperties).WithMany(p => p.EntityViewPropertyFunction).HasForeignKey(c => c.EntityViewPropertyId).OnDelete(DeleteBehavior.Restrict);
				//entityBuilder.HasOne(p => p.Functions).WithMany(p => p.EntityViewPropertyFunction).HasForeignKey(c => c.FunctionId).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}

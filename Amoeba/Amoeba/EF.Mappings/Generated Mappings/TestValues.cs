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
	public class TestValuesMap
	{
		public static void Map(EntityTypeBuilder<TestValues> entityBuilder)
		{
			entityBuilder.ToTable("TestValues", "dbo");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").UseSqlServerIdentityColumn();	
			entityBuilder.Property(t => t.EntityPropertyId).HasColumnName("EntityPropertyId").IsRequired();
			entityBuilder.Property(t => t.RowId).HasColumnName("RowId").IsRequired();
			entityBuilder.Property(t => t.Value).HasColumnName("Value").IsRequired().HasMaxLength(Int32.MaxValue);
		//-------------------Navigation Properties -------------------------------//
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.EntityProperties).WithMany(p => p.TestValues).HasForeignKey(c => c.EntityPropertyId).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}
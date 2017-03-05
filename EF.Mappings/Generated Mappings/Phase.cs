﻿// <autogenerated>
//   This file was generated by T4 code generator MRManger-DataEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Mappings
{
	public class PhaseMap
	{
		public static void Map(EntityTypeBuilder<Phase> entityBuilder)
		{
			entityBuilder.ToTable("Phase", "Interview");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").UseSqlServerIdentityColumn();	
			entityBuilder.Property(t => t.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
			entityBuilder.Property(t => t.Code).HasColumnName("Code").IsRequired().HasMaxLength(10);
		//-------------------Navigation Properties -------------------------------//
				entityBuilder.HasMany(x => x.Interviews).WithOne(p => p.Phase).HasForeignKey(c => c.PhaseId).OnDelete(DeleteBehavior.Restrict);
	
				//----------------Parent Properties
	
		}
	}
}

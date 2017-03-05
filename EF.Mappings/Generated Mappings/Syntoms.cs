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
	public class SyntomsMap
	{
		public static void Map(EntityTypeBuilder<Syntoms> entityBuilder)
		{
			entityBuilder.ToTable("Syntoms", "Interview");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").UseSqlServerIdentityColumn();	
			entityBuilder.Property(t => t.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
		//-------------------Navigation Properties -------------------------------//
				entityBuilder.HasMany(x => x.PatientSyntoms).WithOne(p => p.Syntoms).HasForeignKey(c => c.SyntomId).OnDelete(DeleteBehavior.Restrict);
				entityBuilder.HasMany(x => x.SyntomMedicalSystems).WithOne(p => p.Syntoms).HasForeignKey(c => c.SyntomId).OnDelete(DeleteBehavior.Restrict);
	
				//----------------Parent Properties
	
		}
	}
}

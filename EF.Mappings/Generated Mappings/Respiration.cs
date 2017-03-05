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
	public class RespirationMap
	{
		public static void Map(EntityTypeBuilder<Respiration> entityBuilder)
		{
			entityBuilder.ToTable("Respiration", "Vitals");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").ValueGeneratedNever();	
			entityBuilder.Property(t => t.Id).HasColumnName("Id").IsRequired();
			entityBuilder.Property(t => t.UnitId).HasColumnName("UnitId").IsRequired();
			entityBuilder.Property(t => t.Value).HasColumnName("Value").IsRequired();
		//-------------------Navigation Properties -------------------------------//
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.VitalSigns).WithOne(p => p.Respiration).HasForeignKey<VitalSigns>(c => c.Id).OnDelete(DeleteBehavior.Restrict);
				//entityBuilder.HasOne(p => p.Units).WithMany(p => p.Respiration).HasForeignKey(c => c.UnitId).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}
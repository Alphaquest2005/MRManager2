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
	public class NonResidentCompanyInfoMap
	{
		public static void Map(EntityTypeBuilder<NonResidentCompanyInfo> entityBuilder)
		{
			entityBuilder.ToTable("NonResidentCompanyInfo", "dbo");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").ValueGeneratedNever();	
			entityBuilder.Property(t => t.Id).HasColumnName("Id").IsRequired();
			entityBuilder.Property(t => t.CompanyName).HasColumnName("CompanyName").IsRequired().HasMaxLength(50);
			entityBuilder.Property(t => t.CompanyName).HasColumnName("CompanyName").IsRequired().HasMaxLength(50);
		//-------------------Navigation Properties -------------------------------//
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.Persons_NonResidentPatient).WithOne(p => p.NonResidentCompanyInfo).HasForeignKey<Persons_NonResidentPatient>(c => c.Id).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}

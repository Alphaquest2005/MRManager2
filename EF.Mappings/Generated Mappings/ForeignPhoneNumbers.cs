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
	public class ForeignPhoneNumbersMap
	{
		public static void Map(EntityTypeBuilder<ForeignPhoneNumbers> entityBuilder)
		{
			entityBuilder.ToTable("ForeignPhoneNumbers", "dbo");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").UseSqlServerIdentityColumn();	
			entityBuilder.Property(t => t.PersonId).HasColumnName("PersonId").IsRequired();
			entityBuilder.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber").IsRequired().HasMaxLength(50);
			entityBuilder.Property(t => t.PhoneTypeId).HasColumnName("PhoneTypeId").IsRequired();
		//-------------------Navigation Properties -------------------------------//
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.Persons_NonResidentPatient).WithMany(p => p.ForeignPhoneNumbers).HasForeignKey(c => c.PersonId).OnDelete(DeleteBehavior.Restrict);
				//entityBuilder.HasOne(p => p.PhoneTypes).WithMany(p => p.ForeignPhoneNumbers).HasForeignKey(c => c.PhoneTypeId).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}
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
	public class PrimaryPersonAddressMap
	{
		public static void Map(EntityTypeBuilder<PrimaryPersonAddress> entityBuilder)
		{
			entityBuilder.ToTable("PrimaryPersonAddress", "dbo");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").ValueGeneratedNever();	
			entityBuilder.Property(t => t.PersonAddressesId).HasColumnName("PersonAddressesId").IsRequired();
		//-------------------Navigation Properties -------------------------------//
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.PersonAddresses).WithMany(p => p.PrimaryPersonAddress).HasForeignKey(c => c.PersonAddressesId).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}
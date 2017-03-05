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
	public class ResponseMap
	{
		public static void Map(EntityTypeBuilder<Response> entityBuilder)
		{
			entityBuilder.ToTable("Response", "Interview");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").UseSqlServerIdentityColumn();	
			entityBuilder.Property(t => t.PatientResponseId).HasColumnName("PatientResponseId").IsRequired();
			entityBuilder.Property(t => t.ResponseOptionId).HasColumnName("ResponseOptionId").IsRequired();
			entityBuilder.Property(t => t.Value).HasColumnName("Value").IsRequired().HasMaxLength(50);
		//-------------------Navigation Properties -------------------------------//
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.PatientResponses).WithMany(p => p.Response).HasForeignKey(c => c.PatientResponseId).OnDelete(DeleteBehavior.Restrict);
				//entityBuilder.HasOne(p => p.ResponseOptions).WithMany(p => p.Response).HasForeignKey(c => c.ResponseOptionId).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}
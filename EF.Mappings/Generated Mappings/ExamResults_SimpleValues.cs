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
	public class ExamResults_SimpleValuesMap
	{
		public static void Map(EntityTypeBuilder<ExamResults_SimpleValues> entityBuilder)
		{
			entityBuilder.ToTable("ExamResults_SimpleValues", "Diagnostics");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").UseSqlServerIdentityColumn();	
			entityBuilder.Property(t => t.ExamResultsId).HasColumnName("ExamResultsId").IsRequired();
			entityBuilder.Property(t => t.ResultFieldId).HasColumnName("ResultFieldId").IsRequired();
			entityBuilder.Property(t => t.Value).HasColumnName("Value").IsRequired().HasMaxLength(Int32.MaxValue);
			entityBuilder.Property(t => t.PatientResultsId).HasColumnName("PatientResultsId").IsRequired();
		//-------------------Navigation Properties -------------------------------//
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.ExamResults).WithMany(p => p.ExamResults_SimpleValues).HasForeignKey(c => c.ExamResultsId).OnDelete(DeleteBehavior.Restrict);
				//entityBuilder.HasOne(p => p.ResultFieldNames).WithMany(p => p.ExamResults_SimpleValues).HasForeignKey(c => c.ResultFieldId).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}
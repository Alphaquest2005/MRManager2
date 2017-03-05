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
	public class StudentInfoMap
	{
		public static void Map(EntityTypeBuilder<StudentInfo> entityBuilder)
		{
			entityBuilder.ToTable("StudentInfo", "dbo");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").ValueGeneratedNever();	
			entityBuilder.Property(t => t.School).HasColumnName("School").IsRequired().HasMaxLength(50);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").IsRequired();
			entityBuilder.Property(t => t.Comments).HasColumnName("Comments").IsRequired().HasMaxLength(Int32.MaxValue);
		//-------------------Navigation Properties -------------------------------//
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.Persons_NonResidentPatient).WithOne(p => p.StudentInfo).HasForeignKey<Persons_NonResidentPatient>(c => c.Id).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}

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
	public class MedicalSystemInterviewsMap
	{
		public static void Map(EntityTypeBuilder<MedicalSystemInterviews> entityBuilder)
		{
			entityBuilder.ToTable("MedicalSystemInterviews", "Interview");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").UseSqlServerIdentityColumn();	
			entityBuilder.Property(t => t.InterviewId).HasColumnName("InterviewId").IsRequired();
			entityBuilder.Property(t => t.MedicalSystemId).HasColumnName("MedicalSystemId").IsRequired();
		//-------------------Navigation Properties -------------------------------//
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.Interviews).WithMany(p => p.MedicalSystemInterviews).HasForeignKey(c => c.InterviewId).OnDelete(DeleteBehavior.Restrict);
				//entityBuilder.HasOne(p => p.MedicalSystems).WithMany(p => p.MedicalSystemInterviews).HasForeignKey(c => c.MedicalSystemId).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}
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
	public class ResponseImagesMap
	{
		public static void Map(EntityTypeBuilder<ResponseImages> entityBuilder)
		{
			entityBuilder.ToTable("ResponseImages", "Interview");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").UseSqlServerIdentityColumn();	
			entityBuilder.Property(t => t.MediaId).HasColumnName("MediaId").IsRequired();
			entityBuilder.Property(t => t.PatientResponseId).HasColumnName("PatientResponseId").IsRequired();
		//-------------------Navigation Properties -------------------------------//
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.Media).WithMany(p => p.ResponseImages).HasForeignKey(c => c.MediaId).OnDelete(DeleteBehavior.Restrict);
				//entityBuilder.HasOne(p => p.PatientResponses).WithMany(p => p.ResponseImages).HasForeignKey(c => c.PatientResponseId).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}
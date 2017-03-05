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
	public class ResponseOptionsMap
	{
		public static void Map(EntityTypeBuilder<ResponseOptions> entityBuilder)
		{
			entityBuilder.ToTable("ResponseOptions", "Interview");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").UseSqlServerIdentityColumn();	
			entityBuilder.Property(t => t.QuestionResponseTypeId).HasColumnName("QuestionResponseTypeId").IsRequired();
			entityBuilder.Property(t => t.QuestionId).HasColumnName("QuestionId").IsRequired();
			entityBuilder.Property(t => t.Description).HasColumnName("Description").IsRequired().HasMaxLength(50);
			entityBuilder.Property(t => t.ResponseNumber).HasColumnName("ResponseNumber").IsRequired();
		//-------------------Navigation Properties -------------------------------//
				entityBuilder.HasMany(x => x.Response).WithOne(p => p.ResponseOptions).HasForeignKey(c => c.ResponseOptionId).OnDelete(DeleteBehavior.Restrict);
				entityBuilder.HasOne(p => p.ResponseSuggestions).WithOne(p => p.ResponseOptions).HasForeignKey<ResponseSuggestions>(c => c.Id).OnDelete(DeleteBehavior.Restrict);
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.QuestionResponseTypes).WithMany(p => p.ResponseOptions).HasForeignKey(c => c.QuestionResponseTypeId).OnDelete(DeleteBehavior.Restrict);
				//entityBuilder.HasOne(p => p.Questions).WithMany(p => p.ResponseOptions).HasForeignKey(c => c.QuestionId).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}

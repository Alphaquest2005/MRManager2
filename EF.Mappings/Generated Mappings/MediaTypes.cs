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
	public class MediaTypesMap
	{
		public static void Map(EntityTypeBuilder<MediaTypes> entityBuilder)
		{
			entityBuilder.ToTable("MediaTypes", "dbo");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").UseSqlServerIdentityColumn();	
			entityBuilder.Property(t => t.MediaTypeName).HasColumnName("MediaTypeName").IsRequired().HasMaxLength(50);
			entityBuilder.Property(t => t.MediaTypeName).HasColumnName("MediaTypeName").IsRequired().HasMaxLength(50);
			entityBuilder.Property(t => t.FileExtension).HasColumnName("FileExtension").IsRequired().HasMaxLength(50);
		//-------------------Navigation Properties -------------------------------//
				entityBuilder.HasMany(x => x.Media).WithOne(p => p.MediaTypes).HasForeignKey(c => c.MediaTypeId).OnDelete(DeleteBehavior.Restrict);
	
				//----------------Parent Properties
	
		}
	}
}
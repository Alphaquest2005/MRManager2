﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Mappings
{
	public class ScreenViewsMap
	{
		public static void Map(EntityTypeBuilder<ScreenViews> entityBuilder)
		{
			entityBuilder.ToTable("ScreenViews", "dbo");
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Id).HasColumnName("Id").ValueGeneratedNever();	
			entityBuilder.Property(t => t.ScreenId).HasColumnName("ScreenId").IsRequired();
			entityBuilder.Property(t => t.ViewId).HasColumnName("ViewId").IsRequired();
		//-------------------Navigation Properties -------------------------------//
	
				//----------------Parent Properties
				//entityBuilder.HasOne(p => p.Screens).WithMany(p => p.ScreenViews).HasForeignKey(c => c.ScreenId).OnDelete(DeleteBehavior.Restrict);
				//entityBuilder.HasOne(p => p.Views).WithMany(p => p.ScreenViews).HasForeignKey(c => c.ViewId).OnDelete(DeleteBehavior.Restrict);
	
		}
	}
}

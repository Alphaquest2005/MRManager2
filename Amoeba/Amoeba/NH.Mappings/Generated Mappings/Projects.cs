﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using EF.Entities;
using FluentNHibernate.Mapping;

namespace NH.Mappings
{
	public class ProjectsMap: ClassMap<Projects>
	{
		public ProjectsMap()
		{
			
			Id(t => t.Id, "Id");        
			  Table("Projects");
			  Schema("dbo");
				Map(t => t.Name).Column("Name").Not.LazyLoad();	
		}
	}
}
﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using EF.Entities;
using FluentNHibernate.Mapping;

namespace NH.Mappings
{
	public class EntityViewPropertyFunctionMap: ClassMap<EntityViewPropertyFunction>
	{
		public EntityViewPropertyFunctionMap()
		{
			
			Id(t => t.Id, "Id");        
			  Table("EntityViewPropertyFunction");
			  Schema("dbo");
				Map(t => t.EntityViewPropertyId).Column("EntityViewPropertyId").Not.LazyLoad();	
				Map(t => t.FunctionId).Column("FunctionId").Not.LazyLoad();	
		}
	}
}

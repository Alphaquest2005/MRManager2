﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using EF.Entities;
using FluentNHibernate.Mapping;

namespace NH.Mappings
{
	public class FunctionParametersMap: ClassMap<FunctionParameters>
	{
		public FunctionParametersMap()
		{
			
			Id(t => t.Id, "Id");        
			  Table("FunctionParameters");
			  Schema("dbo");
				Map(t => t.FunctionId).Column("FunctionId").Not.LazyLoad();	
				Map(t => t.ParameterId).Column("ParameterId").Not.LazyLoad();	
		}
	}
}

﻿// <autogenerated>
//   This file was generated by T4 code generator MRManger-DataEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using EF.Entities;
using FluentNHibernate.Mapping;

namespace NH.Mappings
{
	public class ResponseSuggestions_CarePlansMap: ClassMap<ResponseSuggestions_CarePlans>
	{
		public ResponseSuggestions_CarePlansMap()
		{
			
			Id(t => t.Id, "Id");        
			  Table("ResponseSuggestions_CarePlans");
			  Schema("Interview");
				Map(t => t.CarePlanId).Column("CarePlanId").Not.LazyLoad();	
				Map(t => t.Id).Column("Id").Not.LazyLoad();	
		}
	}
}
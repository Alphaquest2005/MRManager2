﻿// <autogenerated>
//   This file was generated by T4 code generator MRManger-DataEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using EF.Entities;
using FluentNHibernate.Mapping;

namespace NH.Mappings
{
	public class ExamResults_AnioticFluidMap: ClassMap<ExamResults_AnioticFluid>
	{
		public ExamResults_AnioticFluidMap()
		{
			
			Id(t => t.Id, "Id");        
			  Table("ExamResults_AnioticFluid");
			  Schema("Diagnostics");
				Map(t => t.Id).Column("Id").Not.LazyLoad();	
				Map(t => t.MVP).Column("MVP").Not.LazyLoad();	
				Map(t => t.AFI).Column("AFI").Not.LazyLoad();	
				Map(t => t.Q1).Column("Q1").Not.LazyLoad();	
				Map(t => t.Q2).Column("Q2").Not.LazyLoad();	
				Map(t => t.Q3).Column("Q3").Not.LazyLoad();	
				Map(t => t.Q4).Column("Q4").Not.LazyLoad();	
		}
	}
}
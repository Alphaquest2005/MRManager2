﻿// <autogenerated>
//   This file was generated by T4 code generator MRManger-DataEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using EF.Entities;
using FluentNHibernate.Mapping;

namespace NH.Mappings
{
	public class ApplicationSettingMap: ClassMap<ApplicationSetting>
	{
		public ApplicationSettingMap()
		{
			
			Id(t => t.Id, "Id");        
			  Table("ApplicationSettings");
			  Schema("dbo");
				Map(t => t.CompanyName).Column("CompanyName").Not.LazyLoad();	
				Map(t => t.Description).Column("Description").Not.LazyLoad();	
				Map(t => t.SoftwareName).Column("SoftwareName").Not.LazyLoad();	
		}
	}
}
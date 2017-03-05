﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using Common.DataEntites;
using EF.Entities;
using Interfaces;

namespace Entity.Expressions
{
	public static partial class EntityPropertiesExpressions
	{
		public static IQueryable<EntityProperties> GetEntityPropertiesById(this IQueryable<EntityProperties> query, int Id) => query.Where(x => x.Id == Id);


// Get Leaf Properties
    
		public static IQueryable<EntityProperties> GetEntityProperties(this IQueryable<EntityProperties> query) => query;

			// Child Properties
				public static IQueryable<DataProperties> DataProperties(this IQueryable<EntityProperties> entityproperties) => entityproperties.SelectMany(x => x.DataProperties);
				public static IQueryable<DataProperties> DataProperties(this IQueryable<EntityProperties> entityproperties, int id) => entityproperties.Where(x => x.Id == id).SelectMany(x => x.DataProperties);
				public static IQueryable<EntityViewEntityProperties> EntityViewEntityProperties(this IQueryable<EntityProperties> entityproperties) => entityproperties.SelectMany(x => x.EntityViewEntityProperties);
				public static IQueryable<EntityViewEntityProperties> EntityViewEntityProperties(this IQueryable<EntityProperties> entityproperties, int id) => entityproperties.Where(x => x.Id == id).SelectMany(x => x.EntityViewEntityProperties);
				public static IQueryable<PresentationProperties> PresentationProperties(this IQueryable<EntityProperties> entityproperties) => entityproperties.SelectMany(x => x.PresentationProperties);
				public static IQueryable<PresentationProperties> PresentationProperties(this IQueryable<EntityProperties> entityproperties, int id) => entityproperties.Where(x => x.Id == id).SelectMany(x => x.PresentationProperties);
				public static IQueryable<TestValues> TestValues(this IQueryable<EntityProperties> entityproperties) => entityproperties.SelectMany(x => x.TestValues);
				public static IQueryable<TestValues> TestValues(this IQueryable<EntityProperties> entityproperties, int id) => entityproperties.Where(x => x.Id == id).SelectMany(x => x.TestValues);
			//Parent Properties
				//public static IQueryable<EntityProperties> EntityProperties(this IQueryable<Entities> entities) => entities.SelectMany(x => x.EntityProperties);
				public static IQueryable<Entities> Entities(this IQueryable<EntityProperties> query) => query.Select(x => x.Entities);
	}
}
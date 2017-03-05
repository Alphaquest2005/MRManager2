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
	public static partial class EntityViewExpressions
	{
		public static IQueryable<EntityView> GetEntityViewById(this IQueryable<EntityView> query, int Id) => query.Where(x => x.Id == Id);


// Get Leaf Properties
    
		public static IQueryable<EntityView> GetEntityView(this IQueryable<EntityView> query) => query;

			// Child Properties
				public static IQueryable<EntityViewProperties> EntityViewProperties(this IQueryable<EntityView> entityview) => entityview.SelectMany(x => x.EntityViewProperties);
				public static IQueryable<EntityViewProperties> EntityViewProperties(this IQueryable<EntityView> entityview, int id) => entityview.Where(x => x.Id == id).SelectMany(x => x.EntityViewProperties);
			//Parent Properties
				//public static IQueryable<EntityView> EntityView(this IQueryable<Entities> entities) => entities.SelectMany(x => x.EntityView);
				public static IQueryable<Entities> Entities(this IQueryable<EntityView> query) => query.Select(x => x.Entities);
	}
}
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
	public static partial class ApplicationEntitiesExpressions
	{
		public static IQueryable<ApplicationEntities> GetApplicationEntitiesById(this IQueryable<ApplicationEntities> query, int Id) => query.Where(x => x.Id == Id);


// Get Leaf Properties
    
		public static IQueryable<Applications> GetApplications(this IQueryable<ApplicationEntities> query) => query.Applications();
    
		public static IQueryable<Entities> GetEntities(this IQueryable<ApplicationEntities> query) => query.Entities();
    
		public static IQueryable<ApplicationEntities> GetApplicationEntities(this IQueryable<ApplicationEntities> query) => query;

			// Child Properties
			//Parent Properties
				//public static IQueryable<ApplicationEntities> ApplicationEntities(this IQueryable<Applications> applications) => applications.SelectMany(x => x.ApplicationEntities);
				public static IQueryable<Applications> Applications(this IQueryable<ApplicationEntities> query) => query.Select(x => x.Applications);
				//public static IQueryable<ApplicationEntities> ApplicationEntities(this IQueryable<Entities> entities) => entities.SelectMany(x => x.ApplicationEntities);
				public static IQueryable<Entities> Entities(this IQueryable<ApplicationEntities> query) => query.Select(x => x.Entities);
	}
}
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
	public static partial class EntityRelationshipsExpressions
	{
		public static IQueryable<EntityRelationships> GetEntityRelationshipsById(this IQueryable<EntityRelationships> query, int Id) => query.Where(x => x.Id == Id);


// Get Leaf Properties
    
		public static IQueryable<EntityRelationships> GetEntityRelationships(this IQueryable<EntityRelationships> query) => query;

			// Child Properties
			//Parent Properties
				//public static IQueryable<EntityRelationships> EntityRelationships(this IQueryable<RelationshipTypes> relationshiptypes) => relationshiptypes.SelectMany(x => x.EntityRelationships);
				public static IQueryable<RelationshipTypes> RelationshipTypes(this IQueryable<EntityRelationships> query) => query.Select(x => x.RelationshipTypes);
	}
}
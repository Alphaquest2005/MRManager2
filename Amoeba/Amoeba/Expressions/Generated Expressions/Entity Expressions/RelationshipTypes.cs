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
	public static partial class RelationshipTypesExpressions
	{
		public static IQueryable<RelationshipTypes> GetRelationshipTypesById(this IQueryable<RelationshipTypes> query, int Id) => query.Where(x => x.Id == Id);


// Get Leaf Properties
    
		public static IQueryable<RelationshipTypes> GetRelationshipTypes(this IQueryable<RelationshipTypes> query) => query;

			// Child Properties
				public static IQueryable<EntityRelationships> EntityRelationships(this IQueryable<RelationshipTypes> relationshiptypes) => relationshiptypes.SelectMany(x => x.EntityRelationships);
				public static IQueryable<EntityRelationships> EntityRelationships(this IQueryable<RelationshipTypes> relationshiptypes, int id) => relationshiptypes.Where(x => x.Id == id).SelectMany(x => x.EntityRelationships);
			//Parent Properties
	}
}
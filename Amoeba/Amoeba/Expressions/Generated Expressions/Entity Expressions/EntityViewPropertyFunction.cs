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
	public static partial class EntityViewPropertyFunctionExpressions
	{
		public static IQueryable<EntityViewPropertyFunction> GetEntityViewPropertyFunctionById(this IQueryable<EntityViewPropertyFunction> query, int Id) => query.Where(x => x.Id == Id);


// Get Leaf Properties
    
		public static IQueryable<EntityViewProperties> GetEntityViewProperties(this IQueryable<EntityViewPropertyFunction> query) => query.EntityViewProperties();
    
		public static IQueryable<Functions> GetFunctions(this IQueryable<EntityViewPropertyFunction> query) => query.Functions();
    
		public static IQueryable<Parameters> GetParameters(this IQueryable<EntityViewPropertyFunction> query) => query.EntityViewPropertyFunctionParameter().FunctionParameters().Parameters();
    
		public static IQueryable<FunctionParameters> GetFunctionParameters(this IQueryable<EntityViewPropertyFunction> query) => query.EntityViewPropertyFunctionParameter().FunctionParameters();
    
		public static IQueryable<EntityViewPropertyFunctionParameter> GetEntityViewPropertyFunctionParameter(this IQueryable<EntityViewPropertyFunction> query) => query.EntityViewPropertyFunctionParameter();
    
		public static IQueryable<EntityViewPropertyFunction> GetEntityViewPropertyFunction(this IQueryable<EntityViewPropertyFunction> query) => query;

			// Child Properties
				public static IQueryable<EntityViewPropertyFunctionParameter> EntityViewPropertyFunctionParameter(this IQueryable<EntityViewPropertyFunction> entityviewpropertyfunction) => entityviewpropertyfunction.Select(x => x.EntityViewPropertyFunctionParameter);
				public static IQueryable<EntityViewPropertyFunctionParameter> EntityViewPropertyFunctionParameter(this IQueryable<EntityViewPropertyFunction> entityviewpropertyfunction, int id) => entityviewpropertyfunction.Where(x => x.Id == id).Select(x => x.EntityViewPropertyFunctionParameter);
			//Parent Properties
				//public static IQueryable<EntityViewPropertyFunction> EntityViewPropertyFunction(this IQueryable<EntityViewProperties> entityviewproperties) => entityviewproperties.SelectMany(x => x.EntityViewPropertyFunction);
				public static IQueryable<EntityViewProperties> EntityViewProperties(this IQueryable<EntityViewPropertyFunction> query) => query.Select(x => x.EntityViewProperties);
				//public static IQueryable<EntityViewPropertyFunction> EntityViewPropertyFunction(this IQueryable<Functions> functions) => functions.SelectMany(x => x.EntityViewPropertyFunction);
				public static IQueryable<Functions> Functions(this IQueryable<EntityViewPropertyFunction> query) => query.Select(x => x.Functions);
	}
}
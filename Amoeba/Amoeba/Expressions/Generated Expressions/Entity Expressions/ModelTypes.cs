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
	public static partial class ModelTypesExpressions
	{
		public static IQueryable<ModelTypes> GetModelTypesById(this IQueryable<ModelTypes> query, int Id) => query.Where(x => x.Id == Id);


// Get Leaf Properties
    
		public static IQueryable<ModelTypes> GetModelTypes(this IQueryable<ModelTypes> query) => query;

			// Child Properties
				public static IQueryable<DataProperties> DataProperties(this IQueryable<ModelTypes> modeltypes) => modeltypes.SelectMany(x => x.DataProperties);
				public static IQueryable<DataProperties> DataProperties(this IQueryable<ModelTypes> modeltypes, int id) => modeltypes.Where(x => x.Id == id).SelectMany(x => x.DataProperties);
			//Parent Properties
	}
}
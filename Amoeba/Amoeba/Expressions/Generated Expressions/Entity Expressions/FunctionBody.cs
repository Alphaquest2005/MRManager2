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
	public static partial class FunctionBodyExpressions
	{
		public static IQueryable<FunctionBody> GetFunctionBodyById(this IQueryable<FunctionBody> query, int Id) => query.Where(x => x.Id == Id);


// Get Leaf Properties
    
		public static IQueryable<FunctionBody> GetFunctionBody(this IQueryable<FunctionBody> query) => query;

			// Child Properties
			//Parent Properties
				//public static IQueryable<FunctionBody> FunctionBody(this IQueryable<Functions> functions) => functions.Select(x => x.FunctionBody);
				public static IQueryable<Functions> Functions(this IQueryable<FunctionBody> query) => query.Select(x => x.Functions);
	}
}
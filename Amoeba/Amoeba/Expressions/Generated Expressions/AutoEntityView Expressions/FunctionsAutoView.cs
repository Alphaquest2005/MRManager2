﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Common.DataEntites;
using EF.Entities;
using Interfaces;

namespace Entity.Expressions
{
	public static partial class FunctionsExpressions
	{

		public static Expression<Func<Functions, FunctionsAutoView>> FunctionsAutoViewExpression { get; } =
		
			x => new FunctionsAutoView 
			{
				Id = x.Id,
 				EntityViewProperties = x.EntityViewPropertyFunction.Select(x0 => x0.EntityViewProperties).Select(z => z.Name).FirstOrDefault(),   
 				EntityViewPropertyFunctionParameter = x.EntityViewPropertyFunction.Select(x0 => x0.EntityViewPropertyFunctionParameter).Select(z => z.Value).FirstOrDefault(),   
 				FunctionParametersEntityViewPropertyFunctionParameter = x.FunctionParameters.SelectMany(x0 => x0.EntityViewPropertyFunctionParameter).Select(z => z.Value).FirstOrDefault(),   
 				Parameters = x.FunctionParameters.Select(x0 => x0.Parameters).Select(z => z.Name).FirstOrDefault(),   
 				DataTypes = x.FunctionReturnType.DataTypes.Name,   
 				Functions = x.Name,   
			};
	}
}

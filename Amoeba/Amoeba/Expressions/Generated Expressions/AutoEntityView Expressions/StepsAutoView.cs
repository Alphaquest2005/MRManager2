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
	public static partial class StepsExpressions
	{

		public static Expression<Func<Steps, StepsAutoView>> StepsAutoViewExpression { get; } =
		
			x => new StepsAutoView 
			{
				Id = x.Id,
 				Process = x.ProcessSteps.Select(x0 => x0.Process).Select(z => z.Name).FirstOrDefault(),   
 				Steps = x.Name,   
			};
	}
}
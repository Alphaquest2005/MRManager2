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
	public static partial class EntityViewEntityPropertiesExpressions
	{

		public static Expression<Func<EntityViewEntityProperties, EntityViewEntityPropertiesAutoView>> EntityViewEntityPropertiesAutoViewExpression { get; } =
		
			x => new EntityViewEntityPropertiesAutoView 
			{
				Id = x.Id,
 				PresentationProperties = x.EntityProperties.PresentationProperties.Select(z => z.DisplayName).FirstOrDefault(),   
 				TestValues = x.EntityProperties.TestValues.Select(z => z.Value).FirstOrDefault(),   
 				Entities = x.EntityProperties.Entities.Name,   
 				EntityProperties = x.EntityProperties.PropertyName,   
			};
	}
}
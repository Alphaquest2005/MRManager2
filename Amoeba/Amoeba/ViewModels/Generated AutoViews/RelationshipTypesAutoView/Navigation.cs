﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Core.Common.UI;
using CommonMessages;
using EventAggregator;
using Entity.Expressions;
using EF.Entities;
using EventMessages;
using Interfaces;
using Utilities;

namespace ViewModels
{
	public partial class RelationshipTypesAutoViewModel_AutoGen 
	{
		MessageSource msgSource => new MessageSource(this.ToString());
		protected virtual void WireEvents()
		{

			EventMessageBus.Current.GetEvent<CurrentEntityChanged<IRelationshipTypes>>(msgSource).Subscribe(x => handleRelationshipTypesChanged(x.EntityId));  
			EventMessageBus.Current.GetEvent<EntityUpdated<IRelationshipTypes>>(msgSource).Subscribe(x => handleRelationshipTypesChanged(x.Entity.Id));     
				
		}

		private void handleRelationshipTypesChanged(int entityId)
		{
					
			if(entityId != EntityStates.NullEntity)
			if(CurrentEntity.Id == EntityStates.NullEntity || CurrentEntity.Id != entityId)
			{
				CurrentEntity = CreateNullEntity();
				EventMessageBus.Current.Publish(new LoadEntityViewWithFilter<IRelationshipTypes>(x => x.Id == entityId, RelationshipTypesExpressions.RelationshipTypesAutoViewExpression,typeof(IRelationshipTypesAutoView), typeof(RelationshipTypesAutoView), msgSource), msgSource);
			}
		}

	}
}
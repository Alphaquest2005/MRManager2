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
	public partial class ModelTypesAutoViewModel_AutoGen 
	{
		MessageSource msgSource => new MessageSource(this.ToString());
		protected virtual void WireEvents()
		{

			EventMessageBus.Current.GetEvent<CurrentEntityChanged<IModelTypes>>(msgSource).Subscribe(x => handleModelTypesChanged(x.EntityId));  
			EventMessageBus.Current.GetEvent<EntityUpdated<IModelTypes>>(msgSource).Subscribe(x => handleModelTypesChanged(x.Entity.Id));     
				
		}

		private void handleModelTypesChanged(int entityId)
		{
					
			if(entityId != EntityStates.NullEntity)
			if(CurrentEntity.Id == EntityStates.NullEntity || CurrentEntity.Id != entityId)
			{
				CurrentEntity = CreateNullEntity();
				EventMessageBus.Current.Publish(new LoadEntityViewWithFilter<IModelTypes>(x => x.Id == entityId, ModelTypesExpressions.ModelTypesAutoViewExpression,typeof(IModelTypesAutoView), typeof(ModelTypesAutoView), msgSource), msgSource);
			}
		}

	}
}

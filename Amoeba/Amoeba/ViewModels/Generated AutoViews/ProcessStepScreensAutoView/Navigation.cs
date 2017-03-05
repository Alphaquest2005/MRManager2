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
	public partial class ProcessStepScreensAutoViewModel_AutoGen 
	{
		MessageSource msgSource => new MessageSource(this.ToString());
		protected virtual void WireEvents()
		{

			EventMessageBus.Current.GetEvent<CurrentEntityChanged<IProcessStepScreens>>(msgSource).Subscribe(x => handleProcessStepScreensChanged(x.EntityId));  
			EventMessageBus.Current.GetEvent<EntityUpdated<IProcessStepScreens>>(msgSource).Subscribe(x => handleProcessStepScreensChanged(x.Entity.Id));     
				
		}

		private void handleProcessStepScreensChanged(int entityId)
		{
					
			if(entityId != EntityStates.NullEntity)
			if(CurrentEntity.Id == EntityStates.NullEntity || CurrentEntity.Id != entityId)
			{
				CurrentEntity = CreateNullEntity();
				EventMessageBus.Current.Publish(new LoadEntityViewWithFilter<IProcessStepScreens>(x => x.Id == entityId, ProcessStepScreensExpressions.ProcessStepScreensAutoViewExpression,typeof(IProcessStepScreensAutoView), typeof(ProcessStepScreensAutoView), msgSource), msgSource);
			}
		}

	}
}
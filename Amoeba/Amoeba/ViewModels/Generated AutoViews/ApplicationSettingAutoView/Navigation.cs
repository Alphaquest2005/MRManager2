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
	public partial class ApplicationSettingAutoViewModel_AutoGen 
	{
		MessageSource msgSource => new MessageSource(this.ToString());
		protected virtual void WireEvents()
		{

			EventMessageBus.Current.GetEvent<CurrentEntityChanged<IApplicationSetting>>(msgSource).Subscribe(x => handleApplicationSettingChanged(x.EntityId));  
			EventMessageBus.Current.GetEvent<EntityUpdated<IApplicationSetting>>(msgSource).Subscribe(x => handleApplicationSettingChanged(x.Entity.Id));     
				
		}

		private void handleApplicationSettingChanged(int entityId)
		{
					
			if(entityId != EntityStates.NullEntity)
			if(CurrentEntity.Id == EntityStates.NullEntity || CurrentEntity.Id != entityId)
			{
				CurrentEntity = CreateNullEntity();
				EventMessageBus.Current.Publish(new LoadEntityViewWithFilter<IApplicationSetting>(x => x.Id == entityId, ApplicationSettingExpressions.ApplicationSettingAutoViewExpression,typeof(IApplicationSettingAutoView), typeof(ApplicationSettingAutoView), msgSource), msgSource);
			}
		}

	}
}

﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Collections.Generic;
using SystemMessages;
using CommonMessages;
using EventAggregator;
using EventMessages;
using Interfaces;
using EF.Entities;
using Entity.Expressions;
using JB.Collections.Reactive;
using ReactiveUI;
using ViewModelInterfaces;

namespace ViewModels
{
	public partial class ApplicationsSummaryListViewModel : ReactiveObject, ISummaryViewModel<IApplicationsAutoView>
	{
		private static readonly ApplicationsSummaryListViewModel _instance;
		 static ApplicationsSummaryListViewModel()
		{
			_instance = new ApplicationsSummaryListViewModel();
		}

		public static ApplicationsSummaryListViewModel Instance
		{
			get { return _instance; }
		}
		MessageSource msgSource => new MessageSource(this.ToString());

		private ApplicationsSummaryListViewModel()
		{
			
			EventMessageBus.Current.GetEvent<EntitySetLoaded<IApplicationsAutoView>>(msgSource).Subscribe(x => handleEntitySetUpdated(x.Entities));
			EventMessageBus.Current.GetEvent<LoadEntityViewDataServiceStarted<IApplications>>(msgSource)
			   .Subscribe(x => EventMessageBus.Current.Publish(new LoadEntityView<IApplications>(ApplicationsExpressions.ApplicationsAutoViewExpression,typeof(IApplicationsAutoView), typeof(ApplicationsAutoView), msgSource), msgSource));
		}

		private void handleEntitySetUpdated(IList<IApplicationsAutoView> entities)
		{
			EntitySet = new ObservableList<IApplicationsAutoView>(entities);
		}

		private ObservableList<IApplicationsAutoView> _EntitySet = new ObservableList<IApplicationsAutoView>();
		public ObservableList<IApplicationsAutoView> EntitySet
		{
			get
			{
				return _EntitySet;
			}
			set
			{
				this.RaiseAndSetIfChanged(ref _EntitySet, value ?? new ObservableList<IApplicationsAutoView>());
			}
		}

		private IApplicationsAutoView _currentEntity;

		public IApplicationsAutoView CurrentEntity
		{
			get { return _currentEntity; }
			set
			{
				if (!Equals(_currentEntity, value))
				{
					this.RaiseAndSetIfChanged(ref _currentEntity, value); //value == null? CreateEntity():value
					if (_currentEntity != null) EventMessageBus.Current.Publish(new CurrentEntityChanged<IApplications>(_currentEntity.Id,msgSource), msgSource);
				}
			}
		}

	}

}
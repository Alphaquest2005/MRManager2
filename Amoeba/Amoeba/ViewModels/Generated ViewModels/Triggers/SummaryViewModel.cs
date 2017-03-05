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
	public partial class TriggersSummaryListViewModel : ReactiveObject, ISummaryViewModel<ITriggersAutoView>
	{
		private static readonly TriggersSummaryListViewModel _instance;
		 static TriggersSummaryListViewModel()
		{
			_instance = new TriggersSummaryListViewModel();
		}

		public static TriggersSummaryListViewModel Instance
		{
			get { return _instance; }
		}
		MessageSource msgSource => new MessageSource(this.ToString());

		private TriggersSummaryListViewModel()
		{
			
			EventMessageBus.Current.GetEvent<EntitySetLoaded<ITriggersAutoView>>(msgSource).Subscribe(x => handleEntitySetUpdated(x.Entities));
			EventMessageBus.Current.GetEvent<LoadEntityViewDataServiceStarted<ITriggers>>(msgSource)
			   .Subscribe(x => EventMessageBus.Current.Publish(new LoadEntityView<ITriggers>(TriggersExpressions.TriggersAutoViewExpression,typeof(ITriggersAutoView), typeof(TriggersAutoView), msgSource), msgSource));
		}

		private void handleEntitySetUpdated(IList<ITriggersAutoView> entities)
		{
			EntitySet = new ObservableList<ITriggersAutoView>(entities);
		}

		private ObservableList<ITriggersAutoView> _EntitySet = new ObservableList<ITriggersAutoView>();
		public ObservableList<ITriggersAutoView> EntitySet
		{
			get
			{
				return _EntitySet;
			}
			set
			{
				this.RaiseAndSetIfChanged(ref _EntitySet, value ?? new ObservableList<ITriggersAutoView>());
			}
		}

		private ITriggersAutoView _currentEntity;

		public ITriggersAutoView CurrentEntity
		{
			get { return _currentEntity; }
			set
			{
				if (!Equals(_currentEntity, value))
				{
					this.RaiseAndSetIfChanged(ref _currentEntity, value); //value == null? CreateEntity():value
					if (_currentEntity != null) EventMessageBus.Current.Publish(new CurrentEntityChanged<ITriggers>(_currentEntity.Id,msgSource), msgSource);
				}
			}
		}

	}

}

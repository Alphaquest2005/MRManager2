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
	public partial class FunctionsSummaryListViewModel : ReactiveObject, ISummaryViewModel<IFunctionsAutoView>
	{
		private static readonly FunctionsSummaryListViewModel _instance;
		 static FunctionsSummaryListViewModel()
		{
			_instance = new FunctionsSummaryListViewModel();
		}

		public static FunctionsSummaryListViewModel Instance
		{
			get { return _instance; }
		}
		MessageSource msgSource => new MessageSource(this.ToString());

		private FunctionsSummaryListViewModel()
		{
			
			EventMessageBus.Current.GetEvent<EntitySetLoaded<IFunctionsAutoView>>(msgSource).Subscribe(x => handleEntitySetUpdated(x.Entities));
			EventMessageBus.Current.GetEvent<LoadEntityViewDataServiceStarted<IFunctions>>(msgSource)
			   .Subscribe(x => EventMessageBus.Current.Publish(new LoadEntityView<IFunctions>(FunctionsExpressions.FunctionsAutoViewExpression,typeof(IFunctionsAutoView), typeof(FunctionsAutoView), msgSource), msgSource));
		}

		private void handleEntitySetUpdated(IList<IFunctionsAutoView> entities)
		{
			EntitySet = new ObservableList<IFunctionsAutoView>(entities);
		}

		private ObservableList<IFunctionsAutoView> _EntitySet = new ObservableList<IFunctionsAutoView>();
		public ObservableList<IFunctionsAutoView> EntitySet
		{
			get
			{
				return _EntitySet;
			}
			set
			{
				this.RaiseAndSetIfChanged(ref _EntitySet, value ?? new ObservableList<IFunctionsAutoView>());
			}
		}

		private IFunctionsAutoView _currentEntity;

		public IFunctionsAutoView CurrentEntity
		{
			get { return _currentEntity; }
			set
			{
				if (!Equals(_currentEntity, value))
				{
					this.RaiseAndSetIfChanged(ref _currentEntity, value); //value == null? CreateEntity():value
					if (_currentEntity != null) EventMessageBus.Current.Publish(new CurrentEntityChanged<IFunctions>(_currentEntity.Id,msgSource), msgSource);
				}
			}
		}

	}

}

﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using CommonMessages;
using DataEntites;
using EF.Entities;
using EventAggregator;
using EventMessages;
using Interfaces;
using ReactiveUI;

namespace ViewModels
{
	public partial class BaseViewModel: ReactiveObject // ViewModelBase<BaseViewModel>
	{
		private static readonly BaseViewModel _instance;
		
		public static BaseViewModel Instance
		{
			get { return _instance; }
		}
		
		
	}
}
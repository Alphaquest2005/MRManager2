﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using Core.Common.UI;
using EF.Entities;
using DataInterfaces;
using Interfaces;
using Utilities;

namespace ViewModels
{
	public partial class EntityViewPropertyFunctionViewModel_AutoGen 
	{
		public int EntityViewPropertyId  { get { return GetValue(); } set { SetValue(value); }
	    }
		public int FunctionId  { get { return GetValue(); } set { SetValue(value); }
	    }
		public int Id  { get { return GetValue(); } set { SetValue(value); }
	    }

		protected override IEntityViewPropertyFunction CreateEntity()
		{
			return new EntityViewPropertyFunction() 
					{
						EntityViewPropertyId = BaseViewModel.CurrentEntityViewProperties.Id, 
						FunctionId = BaseViewModel.CurrentFunctions.Id, 
						RowState = DataInterfaces.RowState.Added
					};
		}
		protected override sealed IEntityViewPropertyFunction CreateNullEntity()
		{
			return new EntityViewPropertyFunction(){ Id = EntityStates.NullEntity };
		}
	
	}
}
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
	public partial class ParametersViewModel_AutoGen 
	{
		public int DataTypeId  { get { return GetValue(); } set { SetValue(value); }
	    }
		public int Id  { get { return GetValue(); } set { SetValue(value); }
	    }
		public string Name  { get { return GetValue(); } set { SetValue(value); }
	    }

		protected override IParameters CreateEntity()
		{
			return new Parameters() 
					{
						DataTypeId = BaseViewModel.CurrentDataTypes.Id, 
						RowState = DataInterfaces.RowState.Added
					};
		}
		protected override sealed IParameters CreateNullEntity()
		{
			return new Parameters(){ Id = EntityStates.NullEntity };
		}
	
	}
}
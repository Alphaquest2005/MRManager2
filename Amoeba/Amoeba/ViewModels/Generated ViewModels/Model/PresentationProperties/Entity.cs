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
	public partial class PresentationPropertiesViewModel_AutoGen 
	{
		public int EntityPropertyId  { get { return GetValue(); } set { SetValue(value); }
	    }
		public string DisplayName  { get { return GetValue(); } set { SetValue(value); }
	    }
		public int Id  { get { return GetValue(); } set { SetValue(value); }
	    }
		public string ToolTip  { get { return GetValue(); } set { SetValue(value); }
	    }

		protected override IPresentationProperties CreateEntity()
		{
			return new PresentationProperties() 
					{
						EntityPropertyId = BaseViewModel.CurrentEntityProperties.Id, 
						RowState = DataInterfaces.RowState.Added
					};
		}
		protected override sealed IPresentationProperties CreateNullEntity()
		{
			return new PresentationProperties(){ Id = EntityStates.NullEntity };
		}
	
	}
}

﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.ComponentModel;
using Core.Common.UI;
using Interfaces;
using DesignTime;
using ValidationSets;

namespace ViewModels
{
	public partial class EntityViewEntityPropertiesViewModel_AutoGen : BaseViewModel<IEntityViewEntityProperties>
	{
		public EntityViewEntityPropertiesViewModel_AutoGen(): base(new IEntityViewEntityPropertiesValidator())
		{
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
			{
				CurrentEntity = DesignDataContext.EntityViewEntityProperties;
				base.EntitySet.Add(DesignDataContext.EntityViewEntityProperties);
			}
			else
			{
				CurrentEntity = CreateNullEntity();
			}
			OnCreated();        
			OnTotals();
		}
			
		partial void OnCreated();
		partial void OnTotals();
	}
}
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
	public partial class PrimaryKeyOptionsViewModel_AutoGen : BaseViewModel<IPrimaryKeyOptions>
	{
		public PrimaryKeyOptionsViewModel_AutoGen(): base(new IPrimaryKeyOptionsValidator())
		{
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
			{
				CurrentEntity = DesignDataContext.PrimaryKeyOptions;
				base.EntitySet.Add(DesignDataContext.PrimaryKeyOptions);
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
﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using FluentValidation;
using Interfaces;

namespace ValidationSets
{
	
	public class IApplicationSettingValidator : AbstractValidator<IApplicationSetting>
	{
		public IApplicationSettingValidator()
		{
			CascadeMode = CascadeMode.Continue;
			RuleFor(x => x.ApplicationId).NotNull();
			RuleFor(x => x.Id).NotNull();
			RuleFor(x => x.SettingNameId).NotNull();
			RuleFor(x => x.Value).NotNull();
		}
	}
}
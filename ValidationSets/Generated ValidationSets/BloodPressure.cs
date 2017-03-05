﻿// <autogenerated>
//   This file was generated by T4 code generator MRManger-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using FluentValidation;
using Interfaces;

namespace ValidationSets
{
	
	public class IBloodPressureValidator : AbstractValidator<IBloodPressure>
	{
		public IBloodPressureValidator()
		{
			CascadeMode = CascadeMode.Continue;
			RuleFor(x => x.Diastolic).NotNull();
			RuleFor(x => x.Id).NotNull();
			RuleFor(x => x.Id).NotNull();
			RuleFor(x => x.Systolic).NotNull();
			RuleFor(x => x.UnitId).NotNull();
		}
	}
}
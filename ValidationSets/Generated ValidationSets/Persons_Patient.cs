﻿// <autogenerated>
//   This file was generated by T4 code generator MRManger-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using FluentValidation;
using Interfaces;

namespace ValidationSets
{
	
	public class IPersons_PatientValidator : AbstractValidator<IPersons_Patient>
	{
		public IPersons_PatientValidator()
		{
			CascadeMode = CascadeMode.Continue;
			RuleFor(x => x.Id).NotNull();
			RuleFor(x => x.Id).NotNull();
			RuleFor(x => x.CountryId).NotNull();
			RuleFor(x => x.DateOfBirth).NotNull();
			RuleFor(x => x.SexId).NotNull();
		}
	}
}
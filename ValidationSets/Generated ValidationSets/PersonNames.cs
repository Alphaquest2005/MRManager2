﻿// <autogenerated>
//   This file was generated by T4 code generator MRManger-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using FluentValidation;
using Interfaces;

namespace ValidationSets
{
	
	public class IPersonNamesValidator : AbstractValidator<IPersonNames>
	{
		public IPersonNamesValidator()
		{
			CascadeMode = CascadeMode.Continue;
			RuleFor(x => x.Id).NotNull();
			RuleFor(x => x.PersonId).NotNull();
			RuleFor(x => x.PersonName).NotNull();
			RuleFor(x => x.PersonName).NotNull();
		}
	}
}
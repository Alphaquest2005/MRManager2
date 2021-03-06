﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using FluentValidation;
using Interfaces;

namespace ValidationSets
{
	
	public class IViewEntityValidator : AbstractValidator<IViewEntity>
	{
		public IViewEntityValidator()
		{
			CascadeMode = CascadeMode.Continue;
			RuleFor(x => x.EntityId).NotNull();
			RuleFor(x => x.Id).NotNull();
			RuleFor(x => x.ViewId).NotNull();
		}
	}
}

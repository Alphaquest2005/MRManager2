﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Common.DataEntites;
using EF.Entities;
using Interfaces;

namespace EF.Entities
{
	public partial class FunctionParameters: BaseEntity, IFunctionParameters
	{
		public virtual int FunctionId { get; set; }
		public virtual int ParameterId { get; set; }

		//-------------------Navigation Properties -------------------------------//
			// ---------Child Relationships
				public virtual ICollection<EntityViewPropertyFunctionParameter> EntityViewPropertyFunctionParameter {get; set;}
		
			// ---------Parent Relationships
				public virtual Functions Functions {get; set;}
				public virtual Parameters Parameters {get; set;}
	

	}
}
﻿// <autogenerated>
//   This file was generated by T4 code generator MRManger-DataEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Common.DataEntites;
using EF.Entities;
using Interfaces;

namespace EF.Entities
{
	public partial class SyntomMedicalSystems: BaseEntity, ISyntomMedicalSystems
	{
		public virtual int MedicalSystemId { get; set; }
		public virtual int SyntomId { get; set; }

		//-------------------Navigation Properties -------------------------------//
			// ---------Child Relationships
		
			// ---------Parent Relationships
				public virtual MedicalSystems MedicalSystems {get; set;}
				public virtual Syntoms Syntoms {get; set;}
	

	}
}
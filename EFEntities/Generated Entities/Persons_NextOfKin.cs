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
	public partial class Persons_NextOfKin: BaseEntity, IPersons_NextOfKin
	{
		public virtual int PatientId { get; set; }
		public virtual string Relationship { get; set; }

		//-------------------Navigation Properties -------------------------------//
			// ---------Child Relationships
		
			// ---------Parent Relationships
				public virtual Persons Persons {get; set;}
				public virtual Persons_Patient Persons_Patient {get; set;}
	

	}
}
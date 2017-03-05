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
	public partial class VitalSigns: BaseEntity, IVitalSigns
	{
		public virtual DateTime DateTimeOfReading { get; set; }
		public virtual int ReaderId { get; set; }

		//-------------------Navigation Properties -------------------------------//
			// ---------Child Relationships
				public virtual BloodPressure BloodPressure {get; set;}
				public virtual Height Height {get; set;}
				public virtual ICollection<PatientVisitVitalSigns> PatientVisitVitalSigns {get; set;}
				public virtual Pulse Pulse {get; set;}
				public virtual Respiration Respiration {get; set;}
				public virtual Temperature Temperature {get; set;}
				public virtual Weight Weight {get; set;}
		
			// ---------Parent Relationships
				public virtual Persons Persons {get; set;}
	

	}
}

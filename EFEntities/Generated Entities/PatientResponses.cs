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
	public partial class PatientResponses: BaseEntity, IPatientResponses
	{
		public virtual int PatientSyntomId { get; set; }
		public virtual int QuestionId { get; set; }
		public virtual int PatientVisitId { get; set; }

		//-------------------Navigation Properties -------------------------------//
			// ---------Child Relationships
				public virtual ICollection<Response> Response {get; set;}
				public virtual ICollection<ResponseImages> ResponseImages {get; set;}
		
			// ---------Parent Relationships
				public virtual PatientSyntoms PatientSyntoms {get; set;}
				public virtual Questions Questions {get; set;}
				public virtual PatientVisit PatientVisit {get; set;}
	

	}
}
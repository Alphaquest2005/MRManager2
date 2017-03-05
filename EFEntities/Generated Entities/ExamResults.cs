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
	public partial class ExamResults: BaseEntity, IExamResults
	{
		public virtual int ExamDetailsId { get; set; }
		public virtual int PatientResultsId { get; set; }

		//-------------------Navigation Properties -------------------------------//
			// ---------Child Relationships
				public virtual ExamResults_AnioticFluid ExamResults_AnioticFluid {get; set;}
				public virtual ICollection<ExamResults_FetalDates> ExamResults_FetalDates {get; set;}
				public virtual ICollection<ExamResults_SimpleValues> ExamResults_SimpleValues {get; set;}
				public virtual ExamResults_UmbilicalArtery ExamResults_UmbilicalArtery {get; set;}
		
			// ---------Parent Relationships
				public virtual ExamDetails ExamDetails {get; set;}
				public virtual PatientResults PatientResults {get; set;}
	

	}
}
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
	public partial class ExamResults_AnioticFluid: BaseEntity, IExamResults_AnioticFluid
	{
		public virtual double MVP { get; set; }
		public virtual double AFI { get; set; }
		public virtual double Q1 { get; set; }
		public virtual double Q2 { get; set; }
		public virtual double Q3 { get; set; }
		public virtual double Q4 { get; set; }

		//-------------------Navigation Properties -------------------------------//
			// ---------Child Relationships
		
			// ---------Parent Relationships
				public virtual ExamResults ExamResults {get; set;}
	

	}
}
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
	public partial class Persons_NonResidentPatient: BaseEntity, IPersons_NonResidentPatient
	{

		//-------------------Navigation Properties -------------------------------//
			// ---------Child Relationships
				public virtual BoatInfo BoatInfo {get; set;}
				public virtual ICollection<ForeignAddresses> ForeignAddresses {get; set;}
				public virtual ICollection<ForeignPhoneNumbers> ForeignPhoneNumbers {get; set;}
				public virtual NonResidentCompanyInfo NonResidentCompanyInfo {get; set;}
				public virtual NonResidentHotelInfo NonResidentHotelInfo {get; set;}
				public virtual Persons_ArrivalDepartureInfo Persons_ArrivalDepartureInfo {get; set;}
				public virtual StudentInfo StudentInfo {get; set;}
		
			// ---------Parent Relationships
				public virtual Persons_Patient Persons_Patient {get; set;}
	

	}
}

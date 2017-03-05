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
	public partial class Organisations: BaseEntity, IOrganisations
	{
		public virtual string Name { get; set; }
		public virtual Byte[] EntryTimeStamp { get; set; }
		public virtual string VATNumber { get; set; }

		//-------------------Navigation Properties -------------------------------//
			// ---------Child Relationships
				public virtual ICollection<OrganisationAddress> OrganisationAddress {get; set;}
				public virtual ICollection<OrganisationPhoneNumbers> OrganisationPhoneNumbers {get; set;}
				public virtual Organisations_Companys Organisations_Companys {get; set;}
				public virtual Organisations_Hotels Organisations_Hotels {get; set;}
				public virtual ICollection<PersonJob> PersonJob {get; set;}
		
			// ---------Parent Relationships
	

	}
}
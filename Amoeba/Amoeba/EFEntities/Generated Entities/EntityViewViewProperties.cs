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
	public partial class EntityViewViewProperties: BaseEntity, IEntityViewViewProperties
	{
		public virtual int EntityViewPropertyId { get; set; }
		public virtual int Id { get; set; }

		//-------------------Navigation Properties -------------------------------//
			// ---------Child Relationships
		
			// ---------Parent Relationships
				public virtual EntityViewProperties EntityViewProperties {get; set;}
				public virtual EntityViewProperties EntityViewProperty {get; set;}
	

	}
}

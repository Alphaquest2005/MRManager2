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
	public partial class Views: BaseEntity, IViews
	{

		//-------------------Navigation Properties -------------------------------//
			// ---------Child Relationships
				public virtual ICollection<ScreenViews> ScreenViews {get; set;}
				public virtual ICollection<ViewEntity> ViewEntity {get; set;}
		
			// ---------Parent Relationships
	

	}
}

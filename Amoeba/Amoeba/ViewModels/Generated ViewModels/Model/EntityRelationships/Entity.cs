﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using Core.Common.UI;
using EF.Entities;
using DataInterfaces;
using Interfaces;
using Utilities;

namespace ViewModels
{
	public partial class EntityRelationshipsViewModel_AutoGen 
	{
		public int ChildEntityPropertyId  { get { return GetValue(); } set { SetValue(value); }
	    }
		public int Id  { get { return GetValue(); } set { SetValue(value); }
	    }
		public int ParentEntityPropertyId  { get { return GetValue(); } set { SetValue(value); }
	    }
		public int RelationshipTypeId  { get { return GetValue(); } set { SetValue(value); }
	    }

		protected override IEntityRelationships CreateEntity()
		{
			return new EntityRelationships() 
					{
						RelationshipTypeId = BaseViewModel.CurrentRelationshipTypes.Id, 
						RowState = DataInterfaces.RowState.Added
					};
		}
		protected override sealed IEntityRelationships CreateNullEntity()
		{
			return new EntityRelationships(){ Id = EntityStates.NullEntity };
		}
	
	}
}
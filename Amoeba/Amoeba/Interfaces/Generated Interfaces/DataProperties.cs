﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Interfaces
{
	[InheritedExport]
	public partial interface IDataProperties:DataInterfaces.IEntity  
	{
		int DataTypeId { get;}
		int EntityPropertyId { get;}
		int MaxLength { get;}
		int ModelTypeId { get;}



	}
}
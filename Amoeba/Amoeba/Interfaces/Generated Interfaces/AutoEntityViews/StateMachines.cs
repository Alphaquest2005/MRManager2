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
	public partial interface IStateMachinesAutoView:DataInterfaces.IEntity  
	{
		string States { get;}
		string Triggers { get;}
		string StateMachines { get;}



	}
}
﻿// <autogenerated>
//   This file was generated by T4 code generator MRManger-Interfaces.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using SystemInterfaces;


namespace Interfaces
{
	
	public partial interface IMedia:IEntity  
	{
		Byte[] Value { get;}
		int MediaTypeId { get;}



	}
}

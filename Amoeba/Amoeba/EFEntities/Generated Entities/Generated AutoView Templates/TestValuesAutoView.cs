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
	public partial class TestValuesAutoView: BaseEntity, ITestValuesAutoView
	{
		public string PresentationProperties { get; set; }
		public string Entities { get; set; }
		public string EntityProperties { get; set; }
		public string TestValues { get; set; }

	}
}

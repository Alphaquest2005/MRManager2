﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using Common.DataEntites;
using EF.Entities;
using Interfaces;

namespace Entity.Expressions
{
	public static partial class ProcessStepsExpressions
	{
		public static IQueryable<ProcessSteps> GetProcessStepsById(this IQueryable<ProcessSteps> query, int Id) => query.Where(x => x.Id == Id);


// Get Leaf Properties
    
		public static IQueryable<Process> GetProcess(this IQueryable<ProcessSteps> query) => query.Process();
    
		public static IQueryable<Steps> GetSteps(this IQueryable<ProcessSteps> query) => query.Steps();
    
		public static IQueryable<Screens> GetScreens(this IQueryable<ProcessSteps> query) => query.ProcessStepScreens().Screens();
    
		public static IQueryable<ProcessStepScreens> GetProcessStepScreens(this IQueryable<ProcessSteps> query) => query.ProcessStepScreens();
    
		public static IQueryable<ProcessSteps> GetProcessSteps(this IQueryable<ProcessSteps> query) => query;

			// Child Properties
				public static IQueryable<ProcessStepScreens> ProcessStepScreens(this IQueryable<ProcessSteps> processsteps) => processsteps.SelectMany(x => x.ProcessStepScreens);
				public static IQueryable<ProcessStepScreens> ProcessStepScreens(this IQueryable<ProcessSteps> processsteps, int id) => processsteps.Where(x => x.Id == id).SelectMany(x => x.ProcessStepScreens);
			//Parent Properties
				//public static IQueryable<ProcessSteps> ProcessSteps(this IQueryable<Process> process) => process.SelectMany(x => x.ProcessSteps);
				public static IQueryable<Process> Process(this IQueryable<ProcessSteps> query) => query.Select(x => x.Process);
				//public static IQueryable<ProcessSteps> ProcessSteps(this IQueryable<Steps> steps) => steps.SelectMany(x => x.ProcessSteps);
				public static IQueryable<Steps> Steps(this IQueryable<ProcessSteps> query) => query.Select(x => x.Steps);
	}
}

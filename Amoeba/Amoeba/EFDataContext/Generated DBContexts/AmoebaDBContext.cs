﻿// <autogenerated>
//   This file was generated by T4 code generator Amoeba-Master.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using EF.Entities;
using EF.Mappings;
using Microsoft.EntityFrameworkCore;

namespace EF.DBContexts
{
	public partial class AmoebaDBContext:DbContext
	{
		public DbSet<ApplicationSetting> ApplicationSettings { get; set; }
		public DbSet<ApplicationEntities> ApplicationEntities { get; set; }
		public DbSet<Applications> Applications { get; set; }
		public DbSet<DataProperties> DataProperties { get; set; }
		public DbSet<DataTypes> DataTypes { get; set; }
		public DbSet<Entities> Entities { get; set; }
		public DbSet<EntityProperties> EntityProperties { get; set; }
		public DbSet<EntityRelationships> EntityRelationships { get; set; }
		public DbSet<EntityView> EntityView { get; set; }
		public DbSet<EntityViewEntityProperties> EntityViewEntityProperties { get; set; }
		public DbSet<EntityViewProperties> EntityViewProperties { get; set; }
		public DbSet<EntityViewPropertyFunction> EntityViewPropertyFunction { get; set; }
		public DbSet<EntityViewPropertyFunctionParameter> EntityViewPropertyFunctionParameter { get; set; }
		public DbSet<EntityViewViewProperties> EntityViewViewProperties { get; set; }
		public DbSet<FunctionBody> FunctionBody { get; set; }
		public DbSet<FunctionParameters> FunctionParameters { get; set; }
		public DbSet<FunctionReturnType> FunctionReturnType { get; set; }
		public DbSet<Functions> Functions { get; set; }
		public DbSet<FunctionSetFunctions> FunctionSetFunctions { get; set; }
		public DbSet<FunctionSets> FunctionSets { get; set; }
		public DbSet<Layers> Layers { get; set; }
		public DbSet<Layout> Layout { get; set; }
		public DbSet<ModelTypes> ModelTypes { get; set; }
		public DbSet<Operators> Operators { get; set; }
		public DbSet<Parameters> Parameters { get; set; }
		public DbSet<Parts> Parts { get; set; }
		public DbSet<PresentationProperties> PresentationProperties { get; set; }
		public DbSet<PrimaryKeyOptions> PrimaryKeyOptions { get; set; }
		public DbSet<Process> Process { get; set; }
		public DbSet<ProcessSteps> ProcessSteps { get; set; }
		public DbSet<ProcessStepScreens> ProcessStepScreens { get; set; }
		public DbSet<Projects> Projects { get; set; }
		public DbSet<RelationshipTypes> RelationshipTypes { get; set; }
		public DbSet<ScreenLayouts> ScreenLayouts { get; set; }
		public DbSet<ScreenParts> ScreenParts { get; set; }
		public DbSet<Screens> Screens { get; set; }
		public DbSet<ScreenViews> ScreenViews { get; set; }
		public DbSet<Settings> Settings { get; set; }
		public DbSet<SettingsNames> SettingsNames { get; set; }
		public DbSet<StateMachines> StateMachines { get; set; }
		public DbSet<StateMachineStates> StateMachineStates { get; set; }
		public DbSet<StateMachineTriggers> StateMachineTriggers { get; set; }
		public DbSet<States> States { get; set; }
		public DbSet<Steps> Steps { get; set; }
		public DbSet<TestValues> TestValues { get; set; }
		public DbSet<Triggers> Triggers { get; set; }
		public DbSet<ViewEntity> ViewEntity { get; set; }
		public DbSet<Views> Views { get; set; }
	
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(DBContext.Properties.Settings.Default.DbConnectionString);
		}
	
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
				ApplicationSettingMap.Map(modelBuilder.Entity<ApplicationSetting>());
				ApplicationEntitiesMap.Map(modelBuilder.Entity<ApplicationEntities>());
				ApplicationsMap.Map(modelBuilder.Entity<Applications>());
				DataPropertiesMap.Map(modelBuilder.Entity<DataProperties>());
				DataTypesMap.Map(modelBuilder.Entity<DataTypes>());
				EntitiesMap.Map(modelBuilder.Entity<Entities>());
				EntityPropertiesMap.Map(modelBuilder.Entity<EntityProperties>());
				EntityRelationshipsMap.Map(modelBuilder.Entity<EntityRelationships>());
				EntityViewMap.Map(modelBuilder.Entity<EntityView>());
				EntityViewEntityPropertiesMap.Map(modelBuilder.Entity<EntityViewEntityProperties>());
				EntityViewPropertiesMap.Map(modelBuilder.Entity<EntityViewProperties>());
				EntityViewPropertyFunctionMap.Map(modelBuilder.Entity<EntityViewPropertyFunction>());
				EntityViewPropertyFunctionParameterMap.Map(modelBuilder.Entity<EntityViewPropertyFunctionParameter>());
				EntityViewViewPropertiesMap.Map(modelBuilder.Entity<EntityViewViewProperties>());
				FunctionBodyMap.Map(modelBuilder.Entity<FunctionBody>());
				FunctionParametersMap.Map(modelBuilder.Entity<FunctionParameters>());
				FunctionReturnTypeMap.Map(modelBuilder.Entity<FunctionReturnType>());
				FunctionsMap.Map(modelBuilder.Entity<Functions>());
				FunctionSetFunctionsMap.Map(modelBuilder.Entity<FunctionSetFunctions>());
				FunctionSetsMap.Map(modelBuilder.Entity<FunctionSets>());
				LayersMap.Map(modelBuilder.Entity<Layers>());
				LayoutMap.Map(modelBuilder.Entity<Layout>());
				ModelTypesMap.Map(modelBuilder.Entity<ModelTypes>());
				OperatorsMap.Map(modelBuilder.Entity<Operators>());
				ParametersMap.Map(modelBuilder.Entity<Parameters>());
				PartsMap.Map(modelBuilder.Entity<Parts>());
				PresentationPropertiesMap.Map(modelBuilder.Entity<PresentationProperties>());
				PrimaryKeyOptionsMap.Map(modelBuilder.Entity<PrimaryKeyOptions>());
				ProcessMap.Map(modelBuilder.Entity<Process>());
				ProcessStepsMap.Map(modelBuilder.Entity<ProcessSteps>());
				ProcessStepScreensMap.Map(modelBuilder.Entity<ProcessStepScreens>());
				ProjectsMap.Map(modelBuilder.Entity<Projects>());
				RelationshipTypesMap.Map(modelBuilder.Entity<RelationshipTypes>());
				ScreenLayoutsMap.Map(modelBuilder.Entity<ScreenLayouts>());
				ScreenPartsMap.Map(modelBuilder.Entity<ScreenParts>());
				ScreensMap.Map(modelBuilder.Entity<Screens>());
				ScreenViewsMap.Map(modelBuilder.Entity<ScreenViews>());
				SettingsMap.Map(modelBuilder.Entity<Settings>());
				SettingsNamesMap.Map(modelBuilder.Entity<SettingsNames>());
				StateMachinesMap.Map(modelBuilder.Entity<StateMachines>());
				StateMachineStatesMap.Map(modelBuilder.Entity<StateMachineStates>());
				StateMachineTriggersMap.Map(modelBuilder.Entity<StateMachineTriggers>());
				StatesMap.Map(modelBuilder.Entity<States>());
				StepsMap.Map(modelBuilder.Entity<Steps>());
				TestValuesMap.Map(modelBuilder.Entity<TestValues>());
				TriggersMap.Map(modelBuilder.Entity<Triggers>());
				ViewEntityMap.Map(modelBuilder.Entity<ViewEntity>());
				ViewsMap.Map(modelBuilder.Entity<Views>());
			}
	}
}

﻿using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using SystemInterfaces;
using Core.Common.UI;
using GenSoft.DBContexts;
using GenSoft.Entities;
using RevolutionLogger;
using Application = System.Windows.Application;
using Process = GenSoft.Entities.Process;

namespace GenSoft
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
            if (File.Exists("GenSoft-Logs.xml")) File.Delete("GenSoft-Logs.xml");
            Logger.Initialize();

            Logger.Log(LoggingLevel.Info, $"The UI Thread is:{Application.Current.Dispatcher.Thread.ManagedThreadId}");

            Task.Run(() =>
		    {
                var genSoftDBContext = new GenSoftDbContext().GetType().Assembly;
		        var genSoftEntities = new ApplicationSetting().GetType().Assembly;// new EFEntity<IEntity>().GetType().Assembly;

                using (var ctx = new GenSoftDbContext())
		        {
		           BootStrapper.BootStrapper.Instance.StartUp(ctx.ApplicationSettings.FirstOrDefault().AutoRun,
                                                              ctx.Machines.Cast<IMachineInfo>().ToList(),
                                                              ctx.Processes.Cast<IProcessInfo>().ToList(),
                                                              ctx.ComplextEventActions.Select(x => RevolutionData.Context.Process.CreateComplexEventAction.Invoke(RevolutionData.Context.Process.CreateComplexEventActionInfo.Invoke(x))).ToList(),
                                                              ViewModel.WorkFlow.ProcessViewModels.ProcessViewModelInfos.Skip(1).ToList(),
                                                              genSoftDBContext,
                                                              genSoftEntities);
                }
                   
		    }).ConfigureAwait(false);


		}
        private void BackBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (IsMouseOver == true)
            {
                AppSlider.Slider.MoveToPreviousCtl();
            }
        }
        private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			DragMove();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();

		}

		private void Grid_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
		{
			DragMove();
		}


		//public IApplicationSetting CurrentApplicationSetting => BaseViewModel.CurrentApplicationSetting;


		private void MinimizeWindow(object sender, MouseButtonEventArgs e)
		{
			WindowState = WindowState.Minimized;
		}

		private void SwitchWindowState(object sender, MouseButtonEventArgs e)
		{
			if (this.WindowState == WindowState.Maximized)
			{
				WindowState = WindowState.Normal;
				return;
			}
			if (WindowState == WindowState.Normal)
			{
				WindowState = WindowState.Maximized;

			}

		}

        private void Screen_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}

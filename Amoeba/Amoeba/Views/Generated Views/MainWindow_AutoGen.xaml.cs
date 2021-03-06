﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Interfaces;
using ViewModels;

namespace Views
{
	public partial class MainWindow_AutoGen 
	{
		public MainWindow_AutoGen()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

		private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			DragMove();
		}

		private void CloseWindow(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();

		}

		private void MoveWindow(object sender, MouseButtonEventArgs e)
		{
			DragMove();
		}


		public IApplicationSetting CurrentApplicationSetting => BaseViewModel.CurrentApplicationSetting;


		private bool collapseHome = false;

		private void Expander_Expanded_1(object sender, RoutedEventArgs e)
		{
			FrameworkElement p = FooterBar;

			for (int i = 0; i < VisualTreeHelper.GetChildrenCount(p); i++)
			{
				var child = VisualTreeHelper.GetChild(p, i);
				if (typeof (Expander).IsInstanceOfType(child) && child != sender)
				{
					if (child == homeexpand && collapseHome == false)
					{
						collapseHome = true;
					}

					(child as Expander).IsExpanded = false;

				}

			}
			if (((Expander) sender).Name == "homeexpand")
			{
				collapseHome = false;
			}
			else
			{
				collapseHome = true;
				if (homeexpand != null) homeexpand.IsExpanded = false;
			}
		}
		private void HomeExpander_Expanded_1(object sender, RoutedEventArgs e)
		{
			Expander_Expanded_1(sender, e);
			//homeexpand.IsExpanded = true;
		}

		private void HomeExpander_Collapsed(object sender, RoutedEventArgs e)
		{
			if (collapseHome == false)
			{
				((Expander) sender).UpdateLayout();
				((Expander) sender).IsExpanded = true;
				// collapseHome = true;
			}

		}

		private void MinimizeWindow(object sender, MouseButtonEventArgs e)
		{
			WindowState = System.Windows.WindowState.Minimized;
		}

		private void SwitchWindowState(object sender, MouseButtonEventArgs e)
		{
			if (this.WindowState == System.Windows.WindowState.Maximized)
			{
				WindowState = System.Windows.WindowState.Normal;
				return;
			}
			if (WindowState == System.Windows.WindowState.Normal)
			{
				WindowState = System.Windows.WindowState.Maximized;

			}

		}
	}
}


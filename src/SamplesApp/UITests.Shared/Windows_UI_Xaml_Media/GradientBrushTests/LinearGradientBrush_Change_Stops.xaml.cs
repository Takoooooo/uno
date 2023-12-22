﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Windows_UI_Xaml_Media.GradientBrushTests
{
	[Sample("Brushes")]
	public sealed partial class LinearGradientBrush_Change_Stops : UserControl
	{
		public LinearGradientBrush_Change_Stops()
		{
			this.InitializeComponent();
		}

		private void ChangeBrushButton_Click(object sender, RoutedEventArgs e)
		{
			UnoGradientBrush.GradientStops.RemoveAt(2);
			UnoGradientBrush.GradientStops.RemoveAt(2);
			StatusTextBlock.Text = "Changed";
		}
	}
}

﻿using System.Collections.Immutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uno.UI.SourceGenerators.ImplementedRoutedEvents;
using Uno.UI.SourceGenerators.Tests.Verifiers;

namespace Uno.UI.SourceGenerators.Tests
{
	using Verify = CSharpSourceGeneratorVerifier<ImplementedRoutedEventsGenerator>;

	[TestClass]
	public class ImplementedRoutedEventsGeneratorTests
	{
		private static readonly ReferenceAssemblies s_defaultWithUno = ReferenceAssemblies.Default.AddPackages(
			ImmutableArray.Create(new PackageIdentity("Uno.UI", "3.9.7"))); // UPDATE with a version that has a Control.GetImplementedRoutedEvents available.

		// TODO: Remove and use s_defaultWithUno when we have a version with Control.GetImplementedRoutedEvents available.
		private const string Stub = @"
namespace Uno.UI.Xaml
{
	[System.Flags]
	public enum RoutedEventFlag : ulong
	{
		None = 0,
		// Pointers
		PointerPressed = 1UL << 0,
		PointerReleased = 1UL << 1,
		PointerEntered = 1UL << 2,
		PointerExited = 1UL << 3,
		PointerMoved = 1UL << 4,
		PointerCanceled = 1UL << 5,
		PointerCaptureLost = 1UL << 6,
		PointerWheelChanged = 1UL << 7,
		// Keyboard
		// PreviewKeyDown = 1UL << 12 => Reserved for future usage
		KeyDown = 1UL << 13,
		// PreviewKeyUp = 1 >> 14, => Reserved for future usage
		KeyUp = 1UL << 15,
		// CharacterReceived = 1UL << 16,
		// ProcessKeyboardAccelerators = 1UL << 17, => Reserved for future use (even if it is not an actual standard RoutedEvent)
		// AccessKeyInvoked = 1UL << 18, => Reserved for future use (even if it is not an actual standard RoutedEvent)
		// AccessKeyDisplayRequested = 1UL << 19, => Reserved for future use (even if it is not an actual standard RoutedEvent)
		// AccessKeyDisplayDismissed = 1UL << 20, => Reserved for future use (even if it is not an actual standard RoutedEvent)
		// Focus
		GettingFocus = 1UL << 24,
		GotFocus = 1UL << 25,
		LosingFocus = 1UL << 26,
		LostFocus = 1UL << 27,
		NoFocusCandidateFound = 1UL << 28,
		// BringIntoViewRequested = 1UL << 29, => Reserved for future usage 
		// Drag and drop
		DragStarting = 1UL << 32, // this is actually not a RoutedEvent
		DragEnter = 1UL << 33,
		DragLeave = 1UL << 34,
		DragOver = 1UL << 35,
		Drop = 1UL << 36,
		DropCompleted = 1UL << 37, // this is actually not a RoutedEvent
		// Manipulations
		ManipulationStarting = 1UL << 40,
		ManipulationStarted = 1UL << 41,
		ManipulationDelta = 1UL << 42,
		ManipulationInertiaStarting = 1UL << 43,
		ManipulationCompleted = 1UL << 44,
		// Gestures
		Tapped = 1UL << 48,
		DoubleTapped = 1UL << 49,
		RightTapped = 1UL << 50,
		Holding = 1UL << 51, 
		// Context menu
		// ContextRequested = 1UL << 61, => Reserved for future usage 
		// ContextCanceled  = 1UL << 62, => Reserved for future use (even if it is not an actual standard RoutedEvent)
	}
}
namespace Windows.UI.Xaml.Controls
{
	public class Control
	{
		protected virtual Uno.UI.Xaml.RoutedEventFlag GetImplementedRoutedEvents()
		{
			throw new System.NotImplementedException();
		}
	}
}
namespace Windows.UI.Xaml
{
	public class RoutedEventArgs
	{
	}
	public sealed class DragEventArgs : RoutedEventArgs
	{
	}
}
namespace Windows.UI.Xaml.Input
{
	public sealed class PointerRoutedEventArgs : RoutedEventArgs
	{
	}
	public sealed class ManipulationStartingRoutedEventArgs : RoutedEventArgs
	{
	}
	public sealed class ManipulationStartedRoutedEventArgs : RoutedEventArgs
	{
	}
	public sealed class ManipulationDeltaRoutedEventArgs : RoutedEventArgs
	{
	}
	public sealed class ManipulationInertiaStartingRoutedEventArgs : RoutedEventArgs
	{
	}
	public sealed class ManipulationCompletedRoutedEventArgs : RoutedEventArgs
	{
	}
	public sealed class TappedRoutedEventArgs : RoutedEventArgs
	{
	}
	public sealed class DoubleTappedRoutedEventArgs : RoutedEventArgs
	{
	}
	public sealed class RightTappedRoutedEventArgs : RoutedEventArgs
	{
	}
	public sealed class HoldingRoutedEventArgs : RoutedEventArgs
	{
	}
	public sealed class KeyRoutedEventArgs : RoutedEventArgs
	{
	}
}";

		private async Task TestGeneratorAsync(string inputSource, string expectedGeneratedCode, string expectedFileName)
		{
			await new Verify.Test
			{

				//ReferenceAssemblies = s_defaultWithUno, // UNCOMMENT when we have a version with Control.GetImplementedRoutedEvents available.
				TestState =
				{
					Sources = { Stub, inputSource },
					GeneratedSources =
					{
						(expectedFileName, SourceText.From(expectedGeneratedCode, Encoding.UTF8)),
					},
				},
			}.RunAsync();
		}

		[TestMethod]
		public async Task Given_NonGeneric_Control_In_Global_Namespace()
		{
			const string inputSource = @"
using Windows.UI.Xaml.Controls;

public partial class MyAwesomeControl : Control
{
}
";
			const string expectedCode = @"// <auto-generated>
partial class MyAwesomeControl
{
	protected override global::Uno.UI.Xaml.RoutedEventFlag GetImplementedRoutedEvents()
	{
		return global::Uno.UI.Xaml.RoutedEventFlag.None;
	}
}
";
			await TestGeneratorAsync(inputSource, expectedCode, @"Uno.UI.SourceGenerators\Uno.UI.SourceGenerators.ImplementedRoutedEvents.ImplementedRoutedEventsGenerator\MyAwesomeControl_ImplementedRoutedEvents.g.cs");
		}

		[TestMethod]
		public async Task Given_Generic_Control_In_Global_Namespace()
		{
			const string inputSource = @"
using Windows.UI.Xaml.Controls;

public partial class MyAwesomeControl<T> : Control
{
}
";
			const string expectedCode = @"// <auto-generated>
partial class MyAwesomeControl<T>
{
	protected override global::Uno.UI.Xaml.RoutedEventFlag GetImplementedRoutedEvents()
	{
		return global::Uno.UI.Xaml.RoutedEventFlag.None;
	}
}
";
			await TestGeneratorAsync(inputSource, expectedCode, @"Uno.UI.SourceGenerators\Uno.UI.SourceGenerators.ImplementedRoutedEvents.ImplementedRoutedEventsGenerator\MyAwesomeControl-1[MyAwesomeControl-1.T]_ImplementedRoutedEvents.g.cs");
		}

		[TestMethod]
		public async Task Given_Generic_Control_In_Non_Global_Namespace()
		{
			const string inputSource = @"
using Windows.UI.Xaml.Controls;

namespace MyControls
{
	public partial class MyAwesomeControl<T> : Control
	{
	}
}
";
			const string expectedCode = @"// <auto-generated>
namespace MyControls
{
	partial class MyAwesomeControl<T>
	{
		protected override global::Uno.UI.Xaml.RoutedEventFlag GetImplementedRoutedEvents()
		{
			return global::Uno.UI.Xaml.RoutedEventFlag.None;
		}
	}
}
";
			await TestGeneratorAsync(inputSource, expectedCode, @"Uno.UI.SourceGenerators\Uno.UI.SourceGenerators.ImplementedRoutedEvents.ImplementedRoutedEventsGenerator\MyControls.MyAwesomeControl-1[MyControls.MyAwesomeControl-1.T]_ImplementedRoutedEvents.g.cs");
		}
	}
}

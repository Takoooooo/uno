#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RadialControllerScreenContactEndedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsButtonPressed
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool RadialControllerScreenContactEndedEventArgs.IsButtonPressed is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20RadialControllerScreenContactEndedEventArgs.IsButtonPressed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Haptics.SimpleHapticsController SimpleHapticsController
		{
			get
			{
				throw new global::System.NotImplementedException("The member SimpleHapticsController RadialControllerScreenContactEndedEventArgs.SimpleHapticsController is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SimpleHapticsController%20RadialControllerScreenContactEndedEventArgs.SimpleHapticsController");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Input.RadialControllerScreenContactEndedEventArgs.IsButtonPressed.get
		// Forced skipping of method Windows.UI.Input.RadialControllerScreenContactEndedEventArgs.SimpleHapticsController.get
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaCaptureFocusChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Devices.MediaCaptureFocusState FocusState
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaCaptureFocusState MediaCaptureFocusChangedEventArgs.FocusState is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MediaCaptureFocusState%20MediaCaptureFocusChangedEventArgs.FocusState");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Capture.MediaCaptureFocusChangedEventArgs.FocusState.get
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebUINavigatedEventArgs : global::Windows.UI.WebUI.IWebUINavigatedEventArgs
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.WebUI.WebUINavigatedOperation NavigatedOperation
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebUINavigatedOperation WebUINavigatedEventArgs.NavigatedOperation is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=WebUINavigatedOperation%20WebUINavigatedEventArgs.NavigatedOperation");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.WebUI.WebUINavigatedEventArgs.NavigatedOperation.get
		// Processing: Windows.UI.WebUI.IWebUINavigatedEventArgs
	}
}

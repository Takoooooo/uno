#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ApplicationSettings
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebAccountInvokedArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.ApplicationSettings.WebAccountAction Action
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebAccountAction WebAccountInvokedArgs.Action is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=WebAccountAction%20WebAccountInvokedArgs.Action");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.ApplicationSettings.WebAccountInvokedArgs.Action.get
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Notifications
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ShownTileNotification 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Arguments
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ShownTileNotification.Arguments is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20ShownTileNotification.Arguments");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Notifications.ShownTileNotification.Arguments.get
	}
}

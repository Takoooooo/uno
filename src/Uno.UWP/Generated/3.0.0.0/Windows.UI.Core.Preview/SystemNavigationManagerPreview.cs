#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Core.Preview
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SystemNavigationManagerPreview 
	{
		// Forced skipping of method Windows.UI.Core.Preview.SystemNavigationManagerPreview.CloseRequested.add
		// Forced skipping of method Windows.UI.Core.Preview.SystemNavigationManagerPreview.CloseRequested.remove
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public static global::Windows.UI.Core.Preview.SystemNavigationManagerPreview GetForCurrentView()
		{
			throw new global::System.NotImplementedException("The member SystemNavigationManagerPreview SystemNavigationManagerPreview.GetForCurrentView() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SystemNavigationManagerPreview%20SystemNavigationManagerPreview.GetForCurrentView%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
		public  event global::System.EventHandler<global::Windows.UI.Core.Preview.SystemNavigationCloseRequestedPreviewEventArgs> CloseRequested
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Core.Preview.SystemNavigationManagerPreview", "event EventHandler<SystemNavigationCloseRequestedPreviewEventArgs> SystemNavigationManagerPreview.CloseRequested");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Core.Preview.SystemNavigationManagerPreview", "event EventHandler<SystemNavigationCloseRequestedPreviewEventArgs> SystemNavigationManagerPreview.CloseRequested");
			}
		}
		#endif
	}
}

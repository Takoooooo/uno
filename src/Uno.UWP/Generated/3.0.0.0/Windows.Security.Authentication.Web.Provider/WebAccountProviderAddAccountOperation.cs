#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Web.Provider
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebAccountProviderAddAccountOperation : global::Windows.Security.Authentication.Web.Provider.IWebAccountProviderOperation
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Authentication.Web.Provider.WebAccountProviderOperationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebAccountProviderOperationKind WebAccountProviderAddAccountOperation.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=WebAccountProviderOperationKind%20WebAccountProviderAddAccountOperation.Kind");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ReportCompleted()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Security.Authentication.Web.Provider.WebAccountProviderAddAccountOperation", "void WebAccountProviderAddAccountOperation.ReportCompleted()");
		}
		#endif
		// Forced skipping of method Windows.Security.Authentication.Web.Provider.WebAccountProviderAddAccountOperation.Kind.get
		// Processing: Windows.Security.Authentication.Web.Provider.IWebAccountProviderOperation
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.OnlineId
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class OnlineIdSystemAuthenticator 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Security.Authentication.OnlineId.OnlineIdSystemAuthenticatorForUser Default
		{
			get
			{
				throw new global::System.NotImplementedException("The member OnlineIdSystemAuthenticatorForUser OnlineIdSystemAuthenticator.Default is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=OnlineIdSystemAuthenticatorForUser%20OnlineIdSystemAuthenticator.Default");
			}
		}
		#endif
		// Forced skipping of method Windows.Security.Authentication.OnlineId.OnlineIdSystemAuthenticator.Default.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Security.Authentication.OnlineId.OnlineIdSystemAuthenticatorForUser GetForUser( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member OnlineIdSystemAuthenticatorForUser OnlineIdSystemAuthenticator.GetForUser(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=OnlineIdSystemAuthenticatorForUser%20OnlineIdSystemAuthenticator.GetForUser%28User%20user%29");
		}
		#endif
	}
}

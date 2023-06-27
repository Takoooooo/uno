#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Calls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PhoneLineConfiguration 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyDictionary<string, object> ExtendedProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, object> PhoneLineConfiguration.ExtendedProperties is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyDictionary%3Cstring%2C%20object%3E%20PhoneLineConfiguration.ExtendedProperties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsVideoCallingEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PhoneLineConfiguration.IsVideoCallingEnabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20PhoneLineConfiguration.IsVideoCallingEnabled");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneLineConfiguration.IsVideoCallingEnabled.get
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneLineConfiguration.ExtendedProperties.get
	}
}

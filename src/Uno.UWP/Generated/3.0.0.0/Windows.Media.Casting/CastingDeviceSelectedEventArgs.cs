#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Casting
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CastingDeviceSelectedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Casting.CastingDevice SelectedCastingDevice
		{
			get
			{
				throw new global::System.NotImplementedException("The member CastingDevice CastingDeviceSelectedEventArgs.SelectedCastingDevice is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CastingDevice%20CastingDeviceSelectedEventArgs.SelectedCastingDevice");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Casting.CastingDeviceSelectedEventArgs.SelectedCastingDevice.get
	}
}

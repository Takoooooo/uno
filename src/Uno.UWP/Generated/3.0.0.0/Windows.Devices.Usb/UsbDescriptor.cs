#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Usb
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class UsbDescriptor 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  byte DescriptorType
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte UsbDescriptor.DescriptorType is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=byte%20UsbDescriptor.DescriptorType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  byte Length
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte UsbDescriptor.Length is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=byte%20UsbDescriptor.Length");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Usb.UsbDescriptor.Length.get
		// Forced skipping of method Windows.Devices.Usb.UsbDescriptor.DescriptorType.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ReadDescriptorBuffer( global::Windows.Storage.Streams.IBuffer buffer)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Usb.UsbDescriptor", "void UsbDescriptor.ReadDescriptorBuffer(IBuffer buffer)");
		}
		#endif
	}
}

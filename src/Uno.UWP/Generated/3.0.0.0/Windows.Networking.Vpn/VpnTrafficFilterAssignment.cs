#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Vpn
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VpnTrafficFilterAssignment 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool AllowOutbound
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool VpnTrafficFilterAssignment.AllowOutbound is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20VpnTrafficFilterAssignment.AllowOutbound");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Vpn.VpnTrafficFilterAssignment", "bool VpnTrafficFilterAssignment.AllowOutbound");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool AllowInbound
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool VpnTrafficFilterAssignment.AllowInbound is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20VpnTrafficFilterAssignment.AllowInbound");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Vpn.VpnTrafficFilterAssignment", "bool VpnTrafficFilterAssignment.AllowInbound");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.Networking.Vpn.VpnTrafficFilter> TrafficFilterList
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<VpnTrafficFilter> VpnTrafficFilterAssignment.TrafficFilterList is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3CVpnTrafficFilter%3E%20VpnTrafficFilterAssignment.TrafficFilterList");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public VpnTrafficFilterAssignment() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Vpn.VpnTrafficFilterAssignment", "VpnTrafficFilterAssignment.VpnTrafficFilterAssignment()");
		}
		#endif
		// Forced skipping of method Windows.Networking.Vpn.VpnTrafficFilterAssignment.VpnTrafficFilterAssignment()
		// Forced skipping of method Windows.Networking.Vpn.VpnTrafficFilterAssignment.TrafficFilterList.get
		// Forced skipping of method Windows.Networking.Vpn.VpnTrafficFilterAssignment.AllowOutbound.get
		// Forced skipping of method Windows.Networking.Vpn.VpnTrafficFilterAssignment.AllowOutbound.set
		// Forced skipping of method Windows.Networking.Vpn.VpnTrafficFilterAssignment.AllowInbound.get
		// Forced skipping of method Windows.Networking.Vpn.VpnTrafficFilterAssignment.AllowInbound.set
	}
}

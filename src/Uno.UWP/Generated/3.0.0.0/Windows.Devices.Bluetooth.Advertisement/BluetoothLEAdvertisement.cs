#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.Advertisement
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class BluetoothLEAdvertisement 
	{
		// Skipping already declared property LocalName
		// Skipping already declared property Flags
		// Skipping already declared property DataSections
		// Skipping already declared property ManufacturerData
		// Skipping already declared property ServiceUuids
		// Skipping already declared method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement.BluetoothLEAdvertisement()
		// Forced skipping of method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement.BluetoothLEAdvertisement()
		// Forced skipping of method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement.Flags.get
		// Forced skipping of method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement.Flags.set
		// Forced skipping of method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement.LocalName.get
		// Forced skipping of method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement.LocalName.set
		// Forced skipping of method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement.ServiceUuids.get
		// Forced skipping of method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement.ManufacturerData.get
		// Forced skipping of method Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement.DataSections.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Bluetooth.Advertisement.BluetoothLEManufacturerData> GetManufacturerDataByCompanyId( ushort companyId)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<BluetoothLEManufacturerData> BluetoothLEAdvertisement.GetManufacturerDataByCompanyId(ushort companyId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CBluetoothLEManufacturerData%3E%20BluetoothLEAdvertisement.GetManufacturerDataByCompanyId%28ushort%20companyId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementDataSection> GetSectionsByType( byte type)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<BluetoothLEAdvertisementDataSection> BluetoothLEAdvertisement.GetSectionsByType(byte type) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CBluetoothLEAdvertisementDataSection%3E%20BluetoothLEAdvertisement.GetSectionsByType%28byte%20type%29");
		}
		#endif
	}
}

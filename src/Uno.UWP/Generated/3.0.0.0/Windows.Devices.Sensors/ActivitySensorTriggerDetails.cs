#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ActivitySensorTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Sensors.ActivitySensorReadingChangeReport> ReadReports()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<ActivitySensorReadingChangeReport> ActivitySensorTriggerDetails.ReadReports() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CActivitySensorReadingChangeReport%3E%20ActivitySensorTriggerDetails.ReadReports%28%29");
		}
		#endif
	}
}

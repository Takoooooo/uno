#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.LockScreen
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LockScreenUnlockingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset Deadline
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset LockScreenUnlockingEventArgs.Deadline is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DateTimeOffset%20LockScreenUnlockingEventArgs.Deadline");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.LockScreen.LockScreenUnlockingDeferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member LockScreenUnlockingDeferral LockScreenUnlockingEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=LockScreenUnlockingDeferral%20LockScreenUnlockingEventArgs.GetDeferral%28%29");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.LockScreen.LockScreenUnlockingEventArgs.Deadline.get
	}
}

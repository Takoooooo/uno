#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Notifications
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ToastCollectionManager 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string AppId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ToastCollectionManager.AppId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20ToastCollectionManager.AppId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User ToastCollectionManager.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=User%20ToastCollectionManager.User");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction SaveToastCollectionAsync( global::Windows.UI.Notifications.ToastCollection collection)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ToastCollectionManager.SaveToastCollectionAsync(ToastCollection collection) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ToastCollectionManager.SaveToastCollectionAsync%28ToastCollection%20collection%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Notifications.ToastCollection>> FindAllToastCollectionsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ToastCollection>> ToastCollectionManager.FindAllToastCollectionsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CToastCollection%3E%3E%20ToastCollectionManager.FindAllToastCollectionsAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.UI.Notifications.ToastCollection> GetToastCollectionAsync( string collectionId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ToastCollection> ToastCollectionManager.GetToastCollectionAsync(string collectionId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CToastCollection%3E%20ToastCollectionManager.GetToastCollectionAsync%28string%20collectionId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction RemoveToastCollectionAsync( string collectionId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ToastCollectionManager.RemoveToastCollectionAsync(string collectionId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ToastCollectionManager.RemoveToastCollectionAsync%28string%20collectionId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction RemoveAllToastCollectionsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ToastCollectionManager.RemoveAllToastCollectionsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ToastCollectionManager.RemoveAllToastCollectionsAsync%28%29");
		}
		#endif
		// Forced skipping of method Windows.UI.Notifications.ToastCollectionManager.User.get
		// Forced skipping of method Windows.UI.Notifications.ToastCollectionManager.AppId.get
	}
}

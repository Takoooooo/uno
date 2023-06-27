#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.AccessCache
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class StorageItemAccessList : global::Windows.Storage.AccessCache.IStorageItemAccessList
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.AccessCache.AccessListEntryView Entries
		{
			get
			{
				throw new global::System.NotImplementedException("The member AccessListEntryView StorageItemAccessList.Entries is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AccessListEntryView%20StorageItemAccessList.Entries");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MaximumItemsAllowed
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint StorageItemAccessList.MaximumItemsAllowed is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20StorageItemAccessList.MaximumItemsAllowed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Add( global::Windows.Storage.IStorageItem file)
		{
			throw new global::System.NotImplementedException("The member string StorageItemAccessList.Add(IStorageItem file) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20StorageItemAccessList.Add%28IStorageItem%20file%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Add( global::Windows.Storage.IStorageItem file,  string metadata)
		{
			throw new global::System.NotImplementedException("The member string StorageItemAccessList.Add(IStorageItem file, string metadata) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20StorageItemAccessList.Add%28IStorageItem%20file%2C%20string%20metadata%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void AddOrReplace( string token,  global::Windows.Storage.IStorageItem file)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.AccessCache.StorageItemAccessList", "void StorageItemAccessList.AddOrReplace(string token, IStorageItem file)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void AddOrReplace( string token,  global::Windows.Storage.IStorageItem file,  string metadata)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.AccessCache.StorageItemAccessList", "void StorageItemAccessList.AddOrReplace(string token, IStorageItem file, string metadata)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.IStorageItem> GetItemAsync( string token)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IStorageItem> StorageItemAccessList.GetItemAsync(string token) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIStorageItem%3E%20StorageItemAccessList.GetItemAsync%28string%20token%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.StorageFile> GetFileAsync( string token)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageFile> StorageItemAccessList.GetFileAsync(string token) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageFile%3E%20StorageItemAccessList.GetFileAsync%28string%20token%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.StorageFolder> GetFolderAsync( string token)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageFolder> StorageItemAccessList.GetFolderAsync(string token) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageFolder%3E%20StorageItemAccessList.GetFolderAsync%28string%20token%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.IStorageItem> GetItemAsync( string token,  global::Windows.Storage.AccessCache.AccessCacheOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IStorageItem> StorageItemAccessList.GetItemAsync(string token, AccessCacheOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIStorageItem%3E%20StorageItemAccessList.GetItemAsync%28string%20token%2C%20AccessCacheOptions%20options%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.StorageFile> GetFileAsync( string token,  global::Windows.Storage.AccessCache.AccessCacheOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageFile> StorageItemAccessList.GetFileAsync(string token, AccessCacheOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageFile%3E%20StorageItemAccessList.GetFileAsync%28string%20token%2C%20AccessCacheOptions%20options%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.StorageFolder> GetFolderAsync( string token,  global::Windows.Storage.AccessCache.AccessCacheOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageFolder> StorageItemAccessList.GetFolderAsync(string token, AccessCacheOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageFolder%3E%20StorageItemAccessList.GetFolderAsync%28string%20token%2C%20AccessCacheOptions%20options%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Remove( string token)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.AccessCache.StorageItemAccessList", "void StorageItemAccessList.Remove(string token)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool ContainsItem( string token)
		{
			throw new global::System.NotImplementedException("The member bool StorageItemAccessList.ContainsItem(string token) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20StorageItemAccessList.ContainsItem%28string%20token%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Clear()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.AccessCache.StorageItemAccessList", "void StorageItemAccessList.Clear()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CheckAccess( global::Windows.Storage.IStorageItem file)
		{
			throw new global::System.NotImplementedException("The member bool StorageItemAccessList.CheckAccess(IStorageItem file) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20StorageItemAccessList.CheckAccess%28IStorageItem%20file%29");
		}
		#endif
		// Forced skipping of method Windows.Storage.AccessCache.StorageItemAccessList.Entries.get
		// Forced skipping of method Windows.Storage.AccessCache.StorageItemAccessList.MaximumItemsAllowed.get
		// Processing: Windows.Storage.AccessCache.IStorageItemAccessList
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.BulkAccess
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FileInformation : global::Windows.Storage.BulkAccess.IStorageItemInformation,global::Windows.Storage.IStorageFile,global::Windows.Storage.Streams.IInputStreamReference,global::Windows.Storage.Streams.IRandomAccessStreamReference,global::Windows.Storage.IStorageItem,global::Windows.Storage.IStorageItemProperties,global::Windows.Storage.IStorageItem2,global::Windows.Storage.IStorageItemPropertiesWithProvider,global::Windows.Storage.IStorageFilePropertiesWithAvailability,global::Windows.Storage.IStorageFile2
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.FileProperties.BasicProperties BasicProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member BasicProperties FileInformation.BasicProperties is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BasicProperties%20FileInformation.BasicProperties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.FileProperties.DocumentProperties DocumentProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member DocumentProperties FileInformation.DocumentProperties is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DocumentProperties%20FileInformation.DocumentProperties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.FileProperties.ImageProperties ImageProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member ImageProperties FileInformation.ImageProperties is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ImageProperties%20FileInformation.ImageProperties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.FileProperties.MusicProperties MusicProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member MusicProperties FileInformation.MusicProperties is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MusicProperties%20FileInformation.MusicProperties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.FileProperties.StorageItemThumbnail Thumbnail
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageItemThumbnail FileInformation.Thumbnail is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=StorageItemThumbnail%20FileInformation.Thumbnail");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.FileProperties.VideoProperties VideoProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member VideoProperties FileInformation.VideoProperties is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=VideoProperties%20FileInformation.VideoProperties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ContentType
		{
			get
			{
				throw new global::System.NotImplementedException("The member string FileInformation.ContentType is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20FileInformation.ContentType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string FileType
		{
			get
			{
				throw new global::System.NotImplementedException("The member string FileInformation.FileType is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20FileInformation.FileType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsAvailable
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool FileInformation.IsAvailable is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20FileInformation.IsAvailable");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.FileAttributes Attributes
		{
			get
			{
				throw new global::System.NotImplementedException("The member FileAttributes FileInformation.Attributes is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=FileAttributes%20FileInformation.Attributes");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset DateCreated
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset FileInformation.DateCreated is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DateTimeOffset%20FileInformation.DateCreated");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string FileInformation.Name is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20FileInformation.Name");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Path
		{
			get
			{
				throw new global::System.NotImplementedException("The member string FileInformation.Path is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20FileInformation.Path");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DisplayName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string FileInformation.DisplayName is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20FileInformation.DisplayName");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DisplayType
		{
			get
			{
				throw new global::System.NotImplementedException("The member string FileInformation.DisplayType is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20FileInformation.DisplayType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string FolderRelativeId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string FileInformation.FolderRelativeId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20FileInformation.FolderRelativeId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.FileProperties.StorageItemContentProperties Properties
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageItemContentProperties FileInformation.Properties is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=StorageItemContentProperties%20FileInformation.Properties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.StorageProvider Provider
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageProvider FileInformation.Provider is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=StorageProvider%20FileInformation.Provider");
			}
		}
		#endif
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.MusicProperties.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.VideoProperties.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.ImageProperties.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.DocumentProperties.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.BasicProperties.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.Thumbnail.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.ThumbnailUpdated.add
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.ThumbnailUpdated.remove
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.PropertiesUpdated.add
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.PropertiesUpdated.remove
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.FileType.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.ContentType.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.IRandomAccessStream> OpenAsync( global::Windows.Storage.FileAccessMode accessMode)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IRandomAccessStream> FileInformation.OpenAsync(FileAccessMode accessMode) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIRandomAccessStream%3E%20FileInformation.OpenAsync%28FileAccessMode%20accessMode%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.StorageStreamTransaction> OpenTransactedWriteAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageStreamTransaction> FileInformation.OpenTransactedWriteAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageStreamTransaction%3E%20FileInformation.OpenTransactedWriteAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.StorageFile> CopyAsync( global::Windows.Storage.IStorageFolder destinationFolder)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageFile> FileInformation.CopyAsync(IStorageFolder destinationFolder) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageFile%3E%20FileInformation.CopyAsync%28IStorageFolder%20destinationFolder%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.StorageFile> CopyAsync( global::Windows.Storage.IStorageFolder destinationFolder,  string desiredNewName)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageFile> FileInformation.CopyAsync(IStorageFolder destinationFolder, string desiredNewName) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageFile%3E%20FileInformation.CopyAsync%28IStorageFolder%20destinationFolder%2C%20string%20desiredNewName%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.StorageFile> CopyAsync( global::Windows.Storage.IStorageFolder destinationFolder,  string desiredNewName,  global::Windows.Storage.NameCollisionOption option)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageFile> FileInformation.CopyAsync(IStorageFolder destinationFolder, string desiredNewName, NameCollisionOption option) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageFile%3E%20FileInformation.CopyAsync%28IStorageFolder%20destinationFolder%2C%20string%20desiredNewName%2C%20NameCollisionOption%20option%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction CopyAndReplaceAsync( global::Windows.Storage.IStorageFile fileToReplace)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction FileInformation.CopyAndReplaceAsync(IStorageFile fileToReplace) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20FileInformation.CopyAndReplaceAsync%28IStorageFile%20fileToReplace%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction MoveAsync( global::Windows.Storage.IStorageFolder destinationFolder)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction FileInformation.MoveAsync(IStorageFolder destinationFolder) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20FileInformation.MoveAsync%28IStorageFolder%20destinationFolder%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction MoveAsync( global::Windows.Storage.IStorageFolder destinationFolder,  string desiredNewName)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction FileInformation.MoveAsync(IStorageFolder destinationFolder, string desiredNewName) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20FileInformation.MoveAsync%28IStorageFolder%20destinationFolder%2C%20string%20desiredNewName%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction MoveAsync( global::Windows.Storage.IStorageFolder destinationFolder,  string desiredNewName,  global::Windows.Storage.NameCollisionOption option)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction FileInformation.MoveAsync(IStorageFolder destinationFolder, string desiredNewName, NameCollisionOption option) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20FileInformation.MoveAsync%28IStorageFolder%20destinationFolder%2C%20string%20desiredNewName%2C%20NameCollisionOption%20option%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction MoveAndReplaceAsync( global::Windows.Storage.IStorageFile fileToReplace)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction FileInformation.MoveAndReplaceAsync(IStorageFile fileToReplace) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20FileInformation.MoveAndReplaceAsync%28IStorageFile%20fileToReplace%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction RenameAsync( string desiredName)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction FileInformation.RenameAsync(string desiredName) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20FileInformation.RenameAsync%28string%20desiredName%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction RenameAsync( string desiredName,  global::Windows.Storage.NameCollisionOption option)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction FileInformation.RenameAsync(string desiredName, NameCollisionOption option) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20FileInformation.RenameAsync%28string%20desiredName%2C%20NameCollisionOption%20option%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction DeleteAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction FileInformation.DeleteAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20FileInformation.DeleteAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction DeleteAsync( global::Windows.Storage.StorageDeleteOption option)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction FileInformation.DeleteAsync(StorageDeleteOption option) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20FileInformation.DeleteAsync%28StorageDeleteOption%20option%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.FileProperties.BasicProperties> GetBasicPropertiesAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<BasicProperties> FileInformation.GetBasicPropertiesAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CBasicProperties%3E%20FileInformation.GetBasicPropertiesAsync%28%29");
		}
		#endif
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.Name.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.Path.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.Attributes.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.DateCreated.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsOfType( global::Windows.Storage.StorageItemTypes type)
		{
			throw new global::System.NotImplementedException("The member bool FileInformation.IsOfType(StorageItemTypes type) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20FileInformation.IsOfType%28StorageItemTypes%20type%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.IRandomAccessStreamWithContentType> OpenReadAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IRandomAccessStreamWithContentType> FileInformation.OpenReadAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIRandomAccessStreamWithContentType%3E%20FileInformation.OpenReadAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.IInputStream> OpenSequentialReadAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IInputStream> FileInformation.OpenSequentialReadAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIInputStream%3E%20FileInformation.OpenSequentialReadAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.FileProperties.StorageItemThumbnail> GetThumbnailAsync( global::Windows.Storage.FileProperties.ThumbnailMode mode)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageItemThumbnail> FileInformation.GetThumbnailAsync(ThumbnailMode mode) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageItemThumbnail%3E%20FileInformation.GetThumbnailAsync%28ThumbnailMode%20mode%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.FileProperties.StorageItemThumbnail> GetThumbnailAsync( global::Windows.Storage.FileProperties.ThumbnailMode mode,  uint requestedSize)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageItemThumbnail> FileInformation.GetThumbnailAsync(ThumbnailMode mode, uint requestedSize) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageItemThumbnail%3E%20FileInformation.GetThumbnailAsync%28ThumbnailMode%20mode%2C%20uint%20requestedSize%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.FileProperties.StorageItemThumbnail> GetThumbnailAsync( global::Windows.Storage.FileProperties.ThumbnailMode mode,  uint requestedSize,  global::Windows.Storage.FileProperties.ThumbnailOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageItemThumbnail> FileInformation.GetThumbnailAsync(ThumbnailMode mode, uint requestedSize, ThumbnailOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageItemThumbnail%3E%20FileInformation.GetThumbnailAsync%28ThumbnailMode%20mode%2C%20uint%20requestedSize%2C%20ThumbnailOptions%20options%29");
		}
		#endif
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.DisplayName.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.DisplayType.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.FolderRelativeId.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.Properties.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.StorageFolder> GetParentAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageFolder> FileInformation.GetParentAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageFolder%3E%20FileInformation.GetParentAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsEqual( global::Windows.Storage.IStorageItem item)
		{
			throw new global::System.NotImplementedException("The member bool FileInformation.IsEqual(IStorageItem item) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20FileInformation.IsEqual%28IStorageItem%20item%29");
		}
		#endif
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.Provider.get
		// Forced skipping of method Windows.Storage.BulkAccess.FileInformation.IsAvailable.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.IRandomAccessStream> OpenAsync( global::Windows.Storage.FileAccessMode accessMode,  global::Windows.Storage.StorageOpenOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IRandomAccessStream> FileInformation.OpenAsync(FileAccessMode accessMode, StorageOpenOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIRandomAccessStream%3E%20FileInformation.OpenAsync%28FileAccessMode%20accessMode%2C%20StorageOpenOptions%20options%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.StorageStreamTransaction> OpenTransactedWriteAsync( global::Windows.Storage.StorageOpenOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageStreamTransaction> FileInformation.OpenTransactedWriteAsync(StorageOpenOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStorageStreamTransaction%3E%20FileInformation.OpenTransactedWriteAsync%28StorageOpenOptions%20options%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Storage.BulkAccess.IStorageItemInformation, object> PropertiesUpdated
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.BulkAccess.FileInformation", "event TypedEventHandler<IStorageItemInformation, object> FileInformation.PropertiesUpdated");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.BulkAccess.FileInformation", "event TypedEventHandler<IStorageItemInformation, object> FileInformation.PropertiesUpdated");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Storage.BulkAccess.IStorageItemInformation, object> ThumbnailUpdated
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.BulkAccess.FileInformation", "event TypedEventHandler<IStorageItemInformation, object> FileInformation.ThumbnailUpdated");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.BulkAccess.FileInformation", "event TypedEventHandler<IStorageItemInformation, object> FileInformation.ThumbnailUpdated");
			}
		}
		#endif
		// Processing: Windows.Storage.BulkAccess.IStorageItemInformation
		// Processing: Windows.Storage.IStorageFile
		// Processing: Windows.Storage.IStorageItem
		// Processing: Windows.Storage.Streams.IRandomAccessStreamReference
		// Processing: Windows.Storage.Streams.IInputStreamReference
		// Processing: Windows.Storage.IStorageItemProperties
		// Processing: Windows.Storage.IStorageItem2
		// Processing: Windows.Storage.IStorageItemPropertiesWithProvider
		// Processing: Windows.Storage.IStorageFilePropertiesWithAvailability
		// Processing: Windows.Storage.IStorageFile2
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CapturedFrame : global::Windows.Storage.Streams.IRandomAccessStreamWithContentType,global::Windows.Storage.Streams.IContentTypeProvider,global::Windows.Storage.Streams.IRandomAccessStream,global::Windows.Storage.Streams.IOutputStream,global::System.IDisposable,global::Windows.Storage.Streams.IInputStream
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint Height
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint CapturedFrame.Height is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20CapturedFrame.Height");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint Width
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint CapturedFrame.Width is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20CapturedFrame.Width");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Imaging.BitmapPropertySet BitmapProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member BitmapPropertySet CapturedFrame.BitmapProperties is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BitmapPropertySet%20CapturedFrame.BitmapProperties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Capture.CapturedFrameControlValues ControlValues
		{
			get
			{
				throw new global::System.NotImplementedException("The member CapturedFrameControlValues CapturedFrame.ControlValues is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CapturedFrameControlValues%20CapturedFrame.ControlValues");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Imaging.SoftwareBitmap SoftwareBitmap
		{
			get
			{
				throw new global::System.NotImplementedException("The member SoftwareBitmap CapturedFrame.SoftwareBitmap is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SoftwareBitmap%20CapturedFrame.SoftwareBitmap");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ContentType
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CapturedFrame.ContentType is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20CapturedFrame.ContentType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ulong Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong CapturedFrame.Size is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ulong%20CapturedFrame.Size");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Capture.CapturedFrame", "ulong CapturedFrame.Size");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CanRead
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CapturedFrame.CanRead is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20CapturedFrame.CanRead");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CanWrite
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CapturedFrame.CanWrite is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20CapturedFrame.CanWrite");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ulong Position
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong CapturedFrame.Position is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ulong%20CapturedFrame.Position");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Capture.CapturedFrame.Width.get
		// Forced skipping of method Windows.Media.Capture.CapturedFrame.Height.get
		// Forced skipping of method Windows.Media.Capture.CapturedFrame.Size.get
		// Forced skipping of method Windows.Media.Capture.CapturedFrame.Size.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IInputStream GetInputStreamAt( ulong position)
		{
			throw new global::System.NotImplementedException("The member IInputStream CapturedFrame.GetInputStreamAt(ulong position) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IInputStream%20CapturedFrame.GetInputStreamAt%28ulong%20position%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IOutputStream GetOutputStreamAt( ulong position)
		{
			throw new global::System.NotImplementedException("The member IOutputStream CapturedFrame.GetOutputStreamAt(ulong position) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IOutputStream%20CapturedFrame.GetOutputStreamAt%28ulong%20position%29");
		}
		#endif
		// Forced skipping of method Windows.Media.Capture.CapturedFrame.Position.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Seek( ulong position)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Capture.CapturedFrame", "void CapturedFrame.Seek(ulong position)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IRandomAccessStream CloneStream()
		{
			throw new global::System.NotImplementedException("The member IRandomAccessStream CapturedFrame.CloneStream() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IRandomAccessStream%20CapturedFrame.CloneStream%28%29");
		}
		#endif
		// Forced skipping of method Windows.Media.Capture.CapturedFrame.CanRead.get
		// Forced skipping of method Windows.Media.Capture.CapturedFrame.CanWrite.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Capture.CapturedFrame", "void CapturedFrame.Dispose()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Storage.Streams.IBuffer, uint> ReadAsync( global::Windows.Storage.Streams.IBuffer buffer,  uint count,  global::Windows.Storage.Streams.InputStreamOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<IBuffer, uint> CapturedFrame.ReadAsync(IBuffer buffer, uint count, InputStreamOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperationWithProgress%3CIBuffer%2C%20uint%3E%20CapturedFrame.ReadAsync%28IBuffer%20buffer%2C%20uint%20count%2C%20InputStreamOptions%20options%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperationWithProgress<uint, uint> WriteAsync( global::Windows.Storage.Streams.IBuffer buffer)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<uint, uint> CapturedFrame.WriteAsync(IBuffer buffer) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperationWithProgress%3Cuint%2C%20uint%3E%20CapturedFrame.WriteAsync%28IBuffer%20buffer%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<bool> FlushAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> CapturedFrame.FlushAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20CapturedFrame.FlushAsync%28%29");
		}
		#endif
		// Forced skipping of method Windows.Media.Capture.CapturedFrame.ContentType.get
		// Forced skipping of method Windows.Media.Capture.CapturedFrame.SoftwareBitmap.get
		// Forced skipping of method Windows.Media.Capture.CapturedFrame.ControlValues.get
		// Forced skipping of method Windows.Media.Capture.CapturedFrame.BitmapProperties.get
		// Processing: Windows.Storage.Streams.IRandomAccessStreamWithContentType
		// Processing: Windows.Storage.Streams.IRandomAccessStream
		// Processing: System.IDisposable
		// Processing: Windows.Storage.Streams.IInputStream
		// Processing: Windows.Storage.Streams.IOutputStream
		// Processing: Windows.Storage.Streams.IContentTypeProvider
	}
}

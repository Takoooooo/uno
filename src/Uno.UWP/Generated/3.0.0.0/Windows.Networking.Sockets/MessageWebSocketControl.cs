#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MessageWebSocketControl : global::Windows.Networking.Sockets.IWebSocketControl,global::Windows.Networking.Sockets.IWebSocketControl2
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Sockets.SocketMessageType MessageType
		{
			get
			{
				throw new global::System.NotImplementedException("The member SocketMessageType MessageWebSocketControl.MessageType is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SocketMessageType%20MessageWebSocketControl.MessageType");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.MessageWebSocketControl", "SocketMessageType MessageWebSocketControl.MessageType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MaxMessageSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint MessageWebSocketControl.MaxMessageSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20MessageWebSocketControl.MaxMessageSize");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.MessageWebSocketControl", "uint MessageWebSocketControl.MaxMessageSize");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Sockets.MessageWebSocketReceiveMode ReceiveMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member MessageWebSocketReceiveMode MessageWebSocketControl.ReceiveMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MessageWebSocketReceiveMode%20MessageWebSocketControl.ReceiveMode");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.MessageWebSocketControl", "MessageWebSocketReceiveMode MessageWebSocketControl.ReceiveMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan DesiredUnsolicitedPongInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan MessageWebSocketControl.DesiredUnsolicitedPongInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20MessageWebSocketControl.DesiredUnsolicitedPongInterval");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.MessageWebSocketControl", "TimeSpan MessageWebSocketControl.DesiredUnsolicitedPongInterval");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Cryptography.Certificates.Certificate ClientCertificate
		{
			get
			{
				throw new global::System.NotImplementedException("The member Certificate MessageWebSocketControl.ClientCertificate is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Certificate%20MessageWebSocketControl.ClientCertificate");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.MessageWebSocketControl", "Certificate MessageWebSocketControl.ClientCertificate");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan ActualUnsolicitedPongInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan MessageWebSocketControl.ActualUnsolicitedPongInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20MessageWebSocketControl.ActualUnsolicitedPongInterval");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Credentials.PasswordCredential ServerCredential
		{
			get
			{
				throw new global::System.NotImplementedException("The member PasswordCredential MessageWebSocketControl.ServerCredential is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=PasswordCredential%20MessageWebSocketControl.ServerCredential");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.MessageWebSocketControl", "PasswordCredential MessageWebSocketControl.ServerCredential");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Credentials.PasswordCredential ProxyCredential
		{
			get
			{
				throw new global::System.NotImplementedException("The member PasswordCredential MessageWebSocketControl.ProxyCredential is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=PasswordCredential%20MessageWebSocketControl.ProxyCredential");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.MessageWebSocketControl", "PasswordCredential MessageWebSocketControl.ProxyCredential");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint OutboundBufferSizeInBytes
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint MessageWebSocketControl.OutboundBufferSizeInBytes is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20MessageWebSocketControl.OutboundBufferSizeInBytes");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Sockets.MessageWebSocketControl", "uint MessageWebSocketControl.OutboundBufferSizeInBytes");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<string> SupportedProtocols
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<string> MessageWebSocketControl.SupportedProtocols is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3Cstring%3E%20MessageWebSocketControl.SupportedProtocols");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.Security.Cryptography.Certificates.ChainValidationResult> IgnorableServerCertificateErrors
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<ChainValidationResult> MessageWebSocketControl.IgnorableServerCertificateErrors is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3CChainValidationResult%3E%20MessageWebSocketControl.IgnorableServerCertificateErrors");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.MaxMessageSize.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.MaxMessageSize.set
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.MessageType.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.MessageType.set
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.OutboundBufferSizeInBytes.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.OutboundBufferSizeInBytes.set
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.ServerCredential.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.ServerCredential.set
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.ProxyCredential.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.ProxyCredential.set
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.SupportedProtocols.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.IgnorableServerCertificateErrors.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.DesiredUnsolicitedPongInterval.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.DesiredUnsolicitedPongInterval.set
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.ActualUnsolicitedPongInterval.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.ReceiveMode.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.ReceiveMode.set
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.ClientCertificate.get
		// Forced skipping of method Windows.Networking.Sockets.MessageWebSocketControl.ClientCertificate.set
		// Processing: Windows.Networking.Sockets.IWebSocketControl
		// Processing: Windows.Networking.Sockets.IWebSocketControl2
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Spatial
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SpatialManipulationDelta 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector3 Translation
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 SpatialManipulationDelta.Translation is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Vector3%20SpatialManipulationDelta.Translation");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Input.Spatial.SpatialManipulationDelta.Translation.get
	}
}

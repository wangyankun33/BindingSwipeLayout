using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.daimajia.swipe", Managed="Com.Daimajia.Swipe")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.daimajia.swipe.adapters", Managed="Com.Daimajia.Swipe.Adapters")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.daimajia.swipe.implments", Managed="Com.Daimajia.Swipe.Implments")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.daimajia.swipe.interfaces", Managed="Com.Daimajia.Swipe.Interfaces")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.daimajia.swipe.util", Managed="Com.Daimajia.Swipe.Util")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPFFZ_V (IntPtr jnienv, IntPtr klass, float p0, float p1, bool p2);
delegate int _JniMarshal_PPI_I (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate bool _JniMarshal_PPI_Z (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPIIII_V (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3);
delegate void _JniMarshal_PPIIZ_V (IntPtr jnienv, IntPtr klass, int p0, int p1, bool p2);
delegate IntPtr _JniMarshal_PPIL_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLFF_V (IntPtr jnienv, IntPtr klass, IntPtr p0, float p1, float p2);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLFI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, float p2, int p3);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate bool _JniMarshal_PPLLLIIII_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, int p3, int p4, int p5, int p6);
delegate void _JniMarshal_PPLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZL_V (IntPtr jnienv, IntPtr klass, bool p0, IntPtr p1);
delegate void _JniMarshal_PPZZ_V (IntPtr jnienv, IntPtr klass, bool p0, bool p1);
delegate void _JniMarshal_PPZZL_V (IntPtr jnienv, IntPtr klass, bool p0, bool p1, IntPtr p2);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif


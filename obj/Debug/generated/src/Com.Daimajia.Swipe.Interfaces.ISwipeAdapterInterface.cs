using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Daimajia.Swipe.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeAdapterInterface']"
	[Register ("com/daimajia/swipe/interfaces/SwipeAdapterInterface", "", "Com.Daimajia.Swipe.Interfaces.ISwipeAdapterInterfaceInvoker")]
	public partial interface ISwipeAdapterInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeAdapterInterface']/method[@name='getSwipeLayoutResourceId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSwipeLayoutResourceId", "(I)I", "GetGetSwipeLayoutResourceId_IHandler:Com.Daimajia.Swipe.Interfaces.ISwipeAdapterInterfaceInvoker, BindingSwipeLayout")]
		int GetSwipeLayoutResourceId (int p0);

	}

	[global::Android.Runtime.Register ("com/daimajia/swipe/interfaces/SwipeAdapterInterface", DoNotGenerateAcw=true)]
	internal partial class ISwipeAdapterInterfaceInvoker : global::Java.Lang.Object, ISwipeAdapterInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/daimajia/swipe/interfaces/SwipeAdapterInterface", typeof (ISwipeAdapterInterfaceInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ISwipeAdapterInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISwipeAdapterInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.daimajia.swipe.interfaces.SwipeAdapterInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISwipeAdapterInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSwipeLayoutResourceId_I;
#pragma warning disable 0169
		static Delegate GetGetSwipeLayoutResourceId_IHandler ()
		{
			if (cb_getSwipeLayoutResourceId_I == null)
				cb_getSwipeLayoutResourceId_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_GetSwipeLayoutResourceId_I));
			return cb_getSwipeLayoutResourceId_I;
		}

		static int n_GetSwipeLayoutResourceId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Interfaces.ISwipeAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSwipeLayoutResourceId (p0);
		}
#pragma warning restore 0169

		IntPtr id_getSwipeLayoutResourceId_I;
		public unsafe int GetSwipeLayoutResourceId (int p0)
		{
			if (id_getSwipeLayoutResourceId_I == IntPtr.Zero)
				id_getSwipeLayoutResourceId_I = JNIEnv.GetMethodID (class_ref, "getSwipeLayoutResourceId", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSwipeLayoutResourceId_I, __args);
		}

	}
}

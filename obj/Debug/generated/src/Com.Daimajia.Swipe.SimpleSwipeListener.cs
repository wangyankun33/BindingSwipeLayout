//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Daimajia.Swipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']"
	[global::Android.Runtime.Register ("com/daimajia/swipe/SimpleSwipeListener", DoNotGenerateAcw=true)]
	public partial class SimpleSwipeListener : global::Java.Lang.Object, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/daimajia/swipe/SimpleSwipeListener", typeof (SimpleSwipeListener));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SimpleSwipeListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/constructor[@name='SimpleSwipeListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleSwipeListener () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onClose_Lcom_daimajia_swipe_SwipeLayout_;
#pragma warning disable 0169
		static Delegate GetOnClose_Lcom_daimajia_swipe_SwipeLayout_Handler ()
		{
			if (cb_onClose_Lcom_daimajia_swipe_SwipeLayout_ == null)
				cb_onClose_Lcom_daimajia_swipe_SwipeLayout_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnClose_Lcom_daimajia_swipe_SwipeLayout_));
			return cb_onClose_Lcom_daimajia_swipe_SwipeLayout_;
		}

		static void n_OnClose_Lcom_daimajia_swipe_SwipeLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SimpleSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var layout = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_layout, JniHandleOwnership.DoNotTransfer);
			__this.OnClose (layout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/method[@name='onClose' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
		[Register ("onClose", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnClose_Lcom_daimajia_swipe_SwipeLayout_Handler")]
		public virtual unsafe void OnClose (global::Com.Daimajia.Swipe.SwipeLayout layout)
		{
			const string __id = "onClose.(Lcom/daimajia/swipe/SwipeLayout;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((layout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (layout);
			}
		}

		static Delegate cb_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF;
#pragma warning disable 0169
		static Delegate GetOnHandRelease_Lcom_daimajia_swipe_SwipeLayout_FFHandler ()
		{
			if (cb_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF == null)
				cb_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLFF_V (n_OnHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF));
			return cb_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF;
		}

		static void n_OnHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_layout, float xvel, float yvel)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SimpleSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var layout = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_layout, JniHandleOwnership.DoNotTransfer);
			__this.OnHandRelease (layout, xvel, yvel);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/method[@name='onHandRelease' and count(parameter)=3 and parameter[1][@type='com.daimajia.swipe.SwipeLayout'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("onHandRelease", "(Lcom/daimajia/swipe/SwipeLayout;FF)V", "GetOnHandRelease_Lcom_daimajia_swipe_SwipeLayout_FFHandler")]
		public virtual unsafe void OnHandRelease (global::Com.Daimajia.Swipe.SwipeLayout layout, float xvel, float yvel)
		{
			const string __id = "onHandRelease.(Lcom/daimajia/swipe/SwipeLayout;FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((layout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layout).Handle);
				__args [1] = new JniArgumentValue (xvel);
				__args [2] = new JniArgumentValue (yvel);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (layout);
			}
		}

		static Delegate cb_onOpen_Lcom_daimajia_swipe_SwipeLayout_;
#pragma warning disable 0169
		static Delegate GetOnOpen_Lcom_daimajia_swipe_SwipeLayout_Handler ()
		{
			if (cb_onOpen_Lcom_daimajia_swipe_SwipeLayout_ == null)
				cb_onOpen_Lcom_daimajia_swipe_SwipeLayout_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnOpen_Lcom_daimajia_swipe_SwipeLayout_));
			return cb_onOpen_Lcom_daimajia_swipe_SwipeLayout_;
		}

		static void n_OnOpen_Lcom_daimajia_swipe_SwipeLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SimpleSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var layout = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_layout, JniHandleOwnership.DoNotTransfer);
			__this.OnOpen (layout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/method[@name='onOpen' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
		[Register ("onOpen", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnOpen_Lcom_daimajia_swipe_SwipeLayout_Handler")]
		public virtual unsafe void OnOpen (global::Com.Daimajia.Swipe.SwipeLayout layout)
		{
			const string __id = "onOpen.(Lcom/daimajia/swipe/SwipeLayout;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((layout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (layout);
			}
		}

		static Delegate cb_onStartClose_Lcom_daimajia_swipe_SwipeLayout_;
#pragma warning disable 0169
		static Delegate GetOnStartClose_Lcom_daimajia_swipe_SwipeLayout_Handler ()
		{
			if (cb_onStartClose_Lcom_daimajia_swipe_SwipeLayout_ == null)
				cb_onStartClose_Lcom_daimajia_swipe_SwipeLayout_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnStartClose_Lcom_daimajia_swipe_SwipeLayout_));
			return cb_onStartClose_Lcom_daimajia_swipe_SwipeLayout_;
		}

		static void n_OnStartClose_Lcom_daimajia_swipe_SwipeLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SimpleSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var layout = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_layout, JniHandleOwnership.DoNotTransfer);
			__this.OnStartClose (layout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/method[@name='onStartClose' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
		[Register ("onStartClose", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnStartClose_Lcom_daimajia_swipe_SwipeLayout_Handler")]
		public virtual unsafe void OnStartClose (global::Com.Daimajia.Swipe.SwipeLayout layout)
		{
			const string __id = "onStartClose.(Lcom/daimajia/swipe/SwipeLayout;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((layout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (layout);
			}
		}

		static Delegate cb_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_;
#pragma warning disable 0169
		static Delegate GetOnStartOpen_Lcom_daimajia_swipe_SwipeLayout_Handler ()
		{
			if (cb_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_ == null)
				cb_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnStartOpen_Lcom_daimajia_swipe_SwipeLayout_));
			return cb_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_;
		}

		static void n_OnStartOpen_Lcom_daimajia_swipe_SwipeLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SimpleSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var layout = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_layout, JniHandleOwnership.DoNotTransfer);
			__this.OnStartOpen (layout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/method[@name='onStartOpen' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
		[Register ("onStartOpen", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnStartOpen_Lcom_daimajia_swipe_SwipeLayout_Handler")]
		public virtual unsafe void OnStartOpen (global::Com.Daimajia.Swipe.SwipeLayout layout)
		{
			const string __id = "onStartOpen.(Lcom/daimajia/swipe/SwipeLayout;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((layout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (layout);
			}
		}

		static Delegate cb_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II;
#pragma warning disable 0169
		static Delegate GetOnUpdate_Lcom_daimajia_swipe_SwipeLayout_IIHandler ()
		{
			if (cb_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II == null)
				cb_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_V (n_OnUpdate_Lcom_daimajia_swipe_SwipeLayout_II));
			return cb_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II;
		}

		static void n_OnUpdate_Lcom_daimajia_swipe_SwipeLayout_II (IntPtr jnienv, IntPtr native__this, IntPtr native_layout, int leftOffset, int topOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SimpleSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var layout = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_layout, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdate (layout, leftOffset, topOffset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/method[@name='onUpdate' and count(parameter)=3 and parameter[1][@type='com.daimajia.swipe.SwipeLayout'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onUpdate", "(Lcom/daimajia/swipe/SwipeLayout;II)V", "GetOnUpdate_Lcom_daimajia_swipe_SwipeLayout_IIHandler")]
		public virtual unsafe void OnUpdate (global::Com.Daimajia.Swipe.SwipeLayout layout, int leftOffset, int topOffset)
		{
			const string __id = "onUpdate.(Lcom/daimajia/swipe/SwipeLayout;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((layout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layout).Handle);
				__args [1] = new JniArgumentValue (leftOffset);
				__args [2] = new JniArgumentValue (topOffset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (layout);
			}
		}

	}
}

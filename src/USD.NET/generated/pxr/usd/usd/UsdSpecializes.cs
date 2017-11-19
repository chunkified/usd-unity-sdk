//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class UsdSpecializes : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdSpecializes(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdSpecializes obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdSpecializes() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdSpecializes(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public bool AddSpecialize(SdfPath primPath, SWIGTYPE_p_UsdListPosition position) {
    bool ret = UsdCsPINVOKE.UsdSpecializes_AddSpecialize__SWIG_0(swigCPtr, SdfPath.getCPtr(primPath), SWIGTYPE_p_UsdListPosition.getCPtr(position));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AddSpecialize(SdfPath primPath) {
    bool ret = UsdCsPINVOKE.UsdSpecializes_AddSpecialize__SWIG_1(swigCPtr, SdfPath.getCPtr(primPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool RemoveSpecialize(SdfPath primPath) {
    bool ret = UsdCsPINVOKE.UsdSpecializes_RemoveSpecialize(swigCPtr, SdfPath.getCPtr(primPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ClearSpecializes() {
    bool ret = UsdCsPINVOKE.UsdSpecializes_ClearSpecializes(swigCPtr);
    return ret;
  }

  public bool SetSpecializes(SdfPathVector items) {
    bool ret = UsdCsPINVOKE.UsdSpecializes_SetSpecializes(swigCPtr, SdfPathVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdPrim GetPrim() {
    UsdPrim ret = new UsdPrim(UsdCsPINVOKE.UsdSpecializes_GetPrim__SWIG_0(swigCPtr), false);
    return ret;
  }

}

}
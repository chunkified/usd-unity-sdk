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

public class VtTokenArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VtTokenArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtTokenArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VtTokenArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_VtTokenArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

	  public TfToken this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public VtTokenArray() : this(UsdCsPINVOKE.new_VtTokenArray__SWIG_0(), true) {
  }

  public VtTokenArray(uint n) : this(UsdCsPINVOKE.new_VtTokenArray__SWIG_1(n), true) {
  }

  public void push_back(TfToken elem) {
    UsdCsPINVOKE.VtTokenArray_push_back(swigCPtr, TfToken.getCPtr(elem));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back() {
    UsdCsPINVOKE.VtTokenArray_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = UsdCsPINVOKE.VtTokenArray_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = UsdCsPINVOKE.VtTokenArray_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    UsdCsPINVOKE.VtTokenArray_reserve(swigCPtr, num);
  }

  public void resize(uint num) {
    UsdCsPINVOKE.VtTokenArray_resize(swigCPtr, num);
  }

  public void clear() {
    UsdCsPINVOKE.VtTokenArray_clear(swigCPtr);
  }

  public void assign(uint n, TfToken fill) {
    UsdCsPINVOKE.VtTokenArray_assign(swigCPtr, n, TfToken.getCPtr(fill));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(VtTokenArray other) {
    UsdCsPINVOKE.VtTokenArray_swap(swigCPtr, VtTokenArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(VtTokenArray other) {
    bool ret = UsdCsPINVOKE.VtTokenArray_IsIdentical(swigCPtr, VtTokenArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(VtTokenArray lhs, VtTokenArray rhs) {
    bool ret = UsdCsPINVOKE.VtTokenArray_Equals(VtTokenArray.getCPtr(lhs), VtTokenArray.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = UsdCsPINVOKE.VtTokenArray_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(TfToken[] dest) {
    UsdCsPINVOKE.VtTokenArray_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(TfToken[] src) {
    UsdCsPINVOKE.VtTokenArray_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    UsdCsPINVOKE.VtTokenArray_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    UsdCsPINVOKE.VtTokenArray_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected TfToken GetValue(int index) {
    TfToken ret = new TfToken(UsdCsPINVOKE.VtTokenArray_GetValue(swigCPtr, index), false);
    return ret;
  }

  protected void SetValue(int index, TfToken value) {
    UsdCsPINVOKE.VtTokenArray_SetValue(swigCPtr, index, TfToken.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace eogmaneo {

public class Std2DVecf : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<StdVecf>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Std2DVecf(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Std2DVecf obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Std2DVecf() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          eogmaneoPINVOKE.delete_Std2DVecf(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Std2DVecf(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (StdVecf element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public StdVecf this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(StdVecf[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(StdVecf[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, StdVecf[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<StdVecf> global::System.Collections.Generic.IEnumerable<StdVecf>.GetEnumerator() {
    return new Std2DVecfEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new Std2DVecfEnumerator(this);
  }

  public Std2DVecfEnumerator GetEnumerator() {
    return new Std2DVecfEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class Std2DVecfEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<StdVecf>
  {
    private Std2DVecf collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public Std2DVecfEnumerator(Std2DVecf collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public StdVecf Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (StdVecf)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    eogmaneoPINVOKE.Std2DVecf_Clear(swigCPtr);
  }

  public void Add(StdVecf x) {
    eogmaneoPINVOKE.Std2DVecf_Add(swigCPtr, StdVecf.getCPtr(x));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = eogmaneoPINVOKE.Std2DVecf_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = eogmaneoPINVOKE.Std2DVecf_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    eogmaneoPINVOKE.Std2DVecf_reserve(swigCPtr, n);
  }

  public Std2DVecf() : this(eogmaneoPINVOKE.new_Std2DVecf__SWIG_0(), true) {
  }

  public Std2DVecf(Std2DVecf other) : this(eogmaneoPINVOKE.new_Std2DVecf__SWIG_1(Std2DVecf.getCPtr(other)), true) {
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public Std2DVecf(int capacity) : this(eogmaneoPINVOKE.new_Std2DVecf__SWIG_2(capacity), true) {
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  private StdVecf getitemcopy(int index) {
    StdVecf ret = new StdVecf(eogmaneoPINVOKE.Std2DVecf_getitemcopy(swigCPtr, index), true);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private StdVecf getitem(int index) {
    StdVecf ret = new StdVecf(eogmaneoPINVOKE.Std2DVecf_getitem(swigCPtr, index), false);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, StdVecf val) {
    eogmaneoPINVOKE.Std2DVecf_setitem(swigCPtr, index, StdVecf.getCPtr(val));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(Std2DVecf values) {
    eogmaneoPINVOKE.Std2DVecf_AddRange(swigCPtr, Std2DVecf.getCPtr(values));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public Std2DVecf GetRange(int index, int count) {
    global::System.IntPtr cPtr = eogmaneoPINVOKE.Std2DVecf_GetRange(swigCPtr, index, count);
    Std2DVecf ret = (cPtr == global::System.IntPtr.Zero) ? null : new Std2DVecf(cPtr, true);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, StdVecf x) {
    eogmaneoPINVOKE.Std2DVecf_Insert(swigCPtr, index, StdVecf.getCPtr(x));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, Std2DVecf values) {
    eogmaneoPINVOKE.Std2DVecf_InsertRange(swigCPtr, index, Std2DVecf.getCPtr(values));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    eogmaneoPINVOKE.Std2DVecf_RemoveAt(swigCPtr, index);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    eogmaneoPINVOKE.Std2DVecf_RemoveRange(swigCPtr, index, count);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Std2DVecf Repeat(StdVecf value, int count) {
    global::System.IntPtr cPtr = eogmaneoPINVOKE.Std2DVecf_Repeat(StdVecf.getCPtr(value), count);
    Std2DVecf ret = (cPtr == global::System.IntPtr.Zero) ? null : new Std2DVecf(cPtr, true);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    eogmaneoPINVOKE.Std2DVecf_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    eogmaneoPINVOKE.Std2DVecf_Reverse__SWIG_1(swigCPtr, index, count);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, Std2DVecf values) {
    eogmaneoPINVOKE.Std2DVecf_SetRange(swigCPtr, index, Std2DVecf.getCPtr(values));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

}

}

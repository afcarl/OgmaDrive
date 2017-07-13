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

public class StdVecPairi : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<StdPairi>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal StdVecPairi(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StdVecPairi obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StdVecPairi() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          eogmaneoPINVOKE.delete_StdVecPairi(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public StdVecPairi(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (StdPairi element in c) {
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

  public StdPairi this[int index]  {
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

  public void CopyTo(StdPairi[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(StdPairi[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, StdPairi[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<StdPairi> global::System.Collections.Generic.IEnumerable<StdPairi>.GetEnumerator() {
    return new StdVecPairiEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new StdVecPairiEnumerator(this);
  }

  public StdVecPairiEnumerator GetEnumerator() {
    return new StdVecPairiEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class StdVecPairiEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<StdPairi>
  {
    private StdVecPairi collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public StdVecPairiEnumerator(StdVecPairi collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public StdPairi Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (StdPairi)currentObject;
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
    eogmaneoPINVOKE.StdVecPairi_Clear(swigCPtr);
  }

  public void Add(StdPairi x) {
    eogmaneoPINVOKE.StdVecPairi_Add(swigCPtr, StdPairi.getCPtr(x));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = eogmaneoPINVOKE.StdVecPairi_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = eogmaneoPINVOKE.StdVecPairi_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    eogmaneoPINVOKE.StdVecPairi_reserve(swigCPtr, n);
  }

  public StdVecPairi() : this(eogmaneoPINVOKE.new_StdVecPairi__SWIG_0(), true) {
  }

  public StdVecPairi(StdVecPairi other) : this(eogmaneoPINVOKE.new_StdVecPairi__SWIG_1(StdVecPairi.getCPtr(other)), true) {
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public StdVecPairi(int capacity) : this(eogmaneoPINVOKE.new_StdVecPairi__SWIG_2(capacity), true) {
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  private StdPairi getitemcopy(int index) {
    StdPairi ret = new StdPairi(eogmaneoPINVOKE.StdVecPairi_getitemcopy(swigCPtr, index), true);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private StdPairi getitem(int index) {
    StdPairi ret = new StdPairi(eogmaneoPINVOKE.StdVecPairi_getitem(swigCPtr, index), false);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, StdPairi val) {
    eogmaneoPINVOKE.StdVecPairi_setitem(swigCPtr, index, StdPairi.getCPtr(val));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(StdVecPairi values) {
    eogmaneoPINVOKE.StdVecPairi_AddRange(swigCPtr, StdVecPairi.getCPtr(values));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public StdVecPairi GetRange(int index, int count) {
    global::System.IntPtr cPtr = eogmaneoPINVOKE.StdVecPairi_GetRange(swigCPtr, index, count);
    StdVecPairi ret = (cPtr == global::System.IntPtr.Zero) ? null : new StdVecPairi(cPtr, true);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, StdPairi x) {
    eogmaneoPINVOKE.StdVecPairi_Insert(swigCPtr, index, StdPairi.getCPtr(x));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, StdVecPairi values) {
    eogmaneoPINVOKE.StdVecPairi_InsertRange(swigCPtr, index, StdVecPairi.getCPtr(values));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    eogmaneoPINVOKE.StdVecPairi_RemoveAt(swigCPtr, index);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    eogmaneoPINVOKE.StdVecPairi_RemoveRange(swigCPtr, index, count);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static StdVecPairi Repeat(StdPairi value, int count) {
    global::System.IntPtr cPtr = eogmaneoPINVOKE.StdVecPairi_Repeat(StdPairi.getCPtr(value), count);
    StdVecPairi ret = (cPtr == global::System.IntPtr.Zero) ? null : new StdVecPairi(cPtr, true);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    eogmaneoPINVOKE.StdVecPairi_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    eogmaneoPINVOKE.StdVecPairi_Reverse__SWIG_1(swigCPtr, index, count);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, StdVecPairi values) {
    eogmaneoPINVOKE.StdVecPairi_SetRange(swigCPtr, index, StdVecPairi.getCPtr(values));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

}

}

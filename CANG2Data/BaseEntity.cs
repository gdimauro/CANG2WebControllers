using CANG2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CANG2Data.Samples.Model
{
  [DataContract(IsReference = true)]
  public abstract class BaseEntity
#if CHANGETRACKING
    : IObjectWithChangeTracker, INotifyPropertyChanged
#endif
  {
    [Key, DataMember]
    public Guid Id { get; set; }

    public event PropertyChangedEventHandler PropertyChanged { add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
    private event PropertyChangedEventHandler _propertyChanged;
#if CHANGETRACKING
    private ObjectChangeTracker _changeTracker;
#endif

    public BaseEntity()
    {
    }

    protected virtual void OnPropertyChanged(String propertyName)
    {
#if CHANGETRACKING
      if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
      {
        ChangeTracker.State = ObjectState.Modified;
      }
#endif
      if (_propertyChanged != null)
      {
        _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    public string Serialize()
    {
      using (var stream = new MemoryStream())
      {
        new DataContractSerializer(this.GetType()).WriteObject(stream, this);
        stream.Flush();
        return System.Text.UTF8Encoding.UTF8.GetString(stream.ToArray());
      }
    }

    public static T Deserialize<T>(string data)
      where T : BaseEntity
    {
      using (var stream = new MemoryStream(System.Text.UTF8Encoding.UTF8.GetBytes(data)))
      {
        return new DataContractSerializer(typeof(T)).ReadObject(stream) as T;
      }
    }

    //public byte[] ToByteArray(CompressionLevel compressionLevel = CompressionLevel.Fastest)
    //{
    //  return this.Compress(compressionLevel);
    //}

    //public static T FromByteArray<T>(byte[] data)
    //  where T : BaseEntity
    //{
    //  return CompressionUtils.Decompress<T>(data);
    //}

#if CHANGETRACKING

    protected virtual void OnNavigationPropertyChanged(String propertyName)
    {
      if (_propertyChanged != null)
      {
        _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }


    [DataMember]
    [NotMapped]
    public ObjectChangeTracker ChangeTracker
    {
      get
      {
        if (_changeTracker == null)
        {
          _changeTracker = new ObjectChangeTracker();
          _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
        }
        return _changeTracker;
      }
      set
      {
        if (_changeTracker != null)
        {
          _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
        }
        _changeTracker = value;
        if (_changeTracker != null)
        {
          _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
        }
      }
    }

    private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
    {
      if (e.NewState == ObjectState.Deleted)
      {
        ClearNavigationProperties();
      }
    }

    protected bool IsDeserializing { get; private set; }

    [OnDeserializing]
    public void OnDeserializingMethod(StreamingContext context)
    {
      IsDeserializing = true;
    }

    [OnDeserialized]
    public void OnDeserializedMethod(StreamingContext context)
    {
      IsDeserializing = false;
      ChangeTracker.ChangeTrackingEnabled = true;
    }

    protected virtual void ClearNavigationProperties()
    {
    }

#endif

    protected bool SetProperty<T>(string name, ref T oldValue, T newValue) where T : System.IComparable<T>
    {
      if (oldValue == null || oldValue.CompareTo(newValue) != 0)
      {
        oldValue = newValue;
        this.OnPropertyChanged(name);
        return true;
      }
      return false;
    }

    // For nullable types
    protected bool SetProperty<T>(string name, ref Nullable<T> oldValue, Nullable<T> newValue) where T : struct, System.IComparable<T>
    {
      if (oldValue.HasValue != newValue.HasValue || (newValue.HasValue && oldValue.Value.CompareTo(newValue.Value) != 0))
      {
        oldValue = newValue;
        this.OnPropertyChanged(name);
        return true;
      }
      return false;
    }

    public List<Property> Properties = new List<Property>();
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CANG2.Model
{
  public static class PropertyExtensions
  {
    public static List<Property> AddOrSet(this List<Property> properties, Property property)
    {
      var existentProperty = properties.Where(p => p.Namespace == property.Namespace && p.Name == property.Name).FirstOrDefault();
      if (existentProperty != null)
      {
        //var piDst = existentProperty.GetType().GetProperty("Value");
        //var piSrc = property.GetType().GetProperty("Value");
        //piDst.SetValue(existentProperty, piSrc.GetValue(property));
      }
      else
      {
        properties.Add(property);
      }
      return properties;
    }
  }

  [DataContract(IsReference = true)]
  public abstract class Property
  {
    public Property()
    {
      this.Properties = new List<Property>();
    }
    public string Namespace { get; set; }
    public string Name { get; set; }
    public List<Property> Properties { get; private set; }
  }

  [DataContract(IsReference = true)]
  public class PropertyString : Property
  {
    public string Value { get; set; }
  }

  [DataContract(IsReference = true)]
  public class PropertyBinary : Property
  {
    public byte[] Value { get; set; }
  }

  [DataContract(IsReference = true)]
  public class PropertyNumber : Property
  {
    public double Value { get; set; }
  }

  [DataContract(IsReference = true)]
  public class PropertyInt : Property
  {
    public int Value { get; set; }
  }
}

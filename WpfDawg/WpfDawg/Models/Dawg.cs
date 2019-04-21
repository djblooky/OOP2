using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WpfDawg.Models
{
    [Serializable]
    public class Dawg : ISerializable
    {
        public string Name { get; protected set; }
        public double Cost { get; protected set; }
        public bool IsVegan { get; protected set; }

        public Dawg()
        {
            Name = "Devil Dawg";
            Cost = 5.99;
            IsVegan = true;
        }

        public Dawg(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Cost = info.GetDouble("Cost");
            IsVegan = info.GetBoolean("IsVegan");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Cost", Cost);
            info.AddValue("IsVegan", IsVegan);
        }

        public override bool Equals(object other)
        {
            var toCompareWith = other as Dawg;
            if (toCompareWith == null)
                return false;
            return Name == toCompareWith.Name && Cost == toCompareWith.Cost && IsVegan == toCompareWith.IsVegan;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

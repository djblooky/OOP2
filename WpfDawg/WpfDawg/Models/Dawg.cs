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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}

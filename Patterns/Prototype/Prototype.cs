using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Patterns.Prototype
{
    static class Prototype
    {      
        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var bf = new BinaryFormatter();
                bf.Serialize(ms, obj);
                ms.Position = 0;

                return (T)bf.Deserialize(ms);
            }
        }
    }
}

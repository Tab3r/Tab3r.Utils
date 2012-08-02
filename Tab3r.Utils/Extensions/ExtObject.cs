using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

// For serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Tab3r.Utils.Extensions
{
    public static class ExtObject
    {
        /// <summary>
        /// Deep clone like Java
        /// </summary>
        /// <remarks>Very useful for DataSet, for example</remarks>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <returns></returns>
        public static T DeepClone<T>(this T a) where T : ISerializable
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, a);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}

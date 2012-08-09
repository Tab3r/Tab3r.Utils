using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Java.To.Net
{
    /// <summary>
    /// Interface for simulation the Map/HashMap from Java. With HashMap Implementation from Lucene.NET, can
    /// help us to migrate the code from Java to C#
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public interface Map<TKey, TValue> : IDictionary<TKey, TValue>
    {
        void put(TKey key, TValue value);
        void putAll(Map<TKey, TValue> map);
    }
}

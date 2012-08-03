using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// For Serialization
using System.Runtime.Serialization;

namespace Tab3r.Utils.Extensions
{
    /// <summary>
    /// All extensions for IList
    /// </summary>
    public static class ExtIList
    {
        /// <summary>
        /// Clone a IClonable objects list
        /// </summary>
        /// <typeparam name="T">Objects type</typeparam>
        /// <param name="listToClone">List</param>
        /// <returns>Cloned list</returns>
        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            if (listToClone == null)
                return null;
            else
                return listToClone.Select(item => (T)item.Clone()).ToList();
        }

        /// <summary>
        /// Clone a ISerializable objects list
        /// </summary>
        /// <typeparam name="T">Objects type</typeparam>
        /// <param name="listToDeepClone">List</param>
        /// <returns>Cloned list</returns>
        public static IList<T> CloneDeep<T>(this IList<T> listToDeepClone) where T : ISerializable
        {
            if (listToDeepClone == null)
                return null;
            else
                return listToDeepClone.Select(item => (T)item.DeepClone()).ToList();
        }

        /// <summary>
        /// Clone a generic list
        /// </summary>
        /// <typeparam name="T">Objects type</typeparam>
        /// <param name="listToClone">List</param>
        /// <returns>Cloned list</returns>
        public static IList<T> CloneNoIClonable<T>(this IList<T> listToClone)
        {
            if (listToClone == null)
                return null;
            else
                return new List<T>(listToClone);
        }

        /// <summary>
        /// Create a string from objects list
        /// </summary>
        /// <typeparam name="T">Objects type</typeparam>
        /// <param name="obj">List</param>
        /// <param name="delimiter">Delimiters to add each object together</param>
        /// <returns>String</returns>
        public static string AsDelimited<T>(this List<T> obj, string delimiter)
        {
            List<string> items = new List<string>();
            foreach (T data in obj)
            {
                items.Add(data.ToString());
            }
            return String.Join(delimiter, items.ToArray());
        }
    }
}

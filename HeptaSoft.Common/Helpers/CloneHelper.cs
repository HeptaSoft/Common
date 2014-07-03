using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace HeptaSoft.Common.Helpers
{
    /// <summary>
    /// Clone Helper.
    /// </summary>
    public static class CloneHelper
    {
        /// <summary> 
        /// Determines whether the type represents a direct value. 
        /// </summary> 
        /// <param name="valueType">Type of the value.</param> 
        /// <returns><c>True</c> is the specified type is a direct value.</returns> 
        private static bool IsDirectValue(Type valueType)
        {
            return (valueType == typeof(string))
                || (valueType == typeof(DateTime))
                || (valueType == typeof(DateTime?))
                || (valueType == typeof(Guid))
                || (valueType == typeof(Guid?))
                || (valueType == typeof(Decimal))
                || (valueType == typeof(Decimal?))
                || (valueType.IsPrimitive)
                || (valueType.IsEnum);
        }

        /// <summary>
        /// Clones a list.
        /// </summary>
        /// <param name="originalList">The original list.</param>
        /// <param name="destinationList">The destination list.</param>
        /// <returns>
        /// A cloned list.
        /// </returns>
        private static IList DoCloneList(IList originalList, IList destinationList)
        {
            foreach (var originalElement in originalList)
            {
                destinationList.Add(DoClone(originalElement));
            }
            return destinationList;
        }

        /// <summary>
        /// Creates a clone.
        /// </summary>
        /// <param name="originalInstance">The original instance.</param>
        /// <returns>The clone.</returns>
        private static object DoClone(object originalInstance)
        {
            // new instance of the runtime "real" type of the originalInstance object.
            var clone = originalInstance.GetType().GetConstructors().First().Invoke(null);
            // gets all the fields on the instance
            foreach (var field in originalInstance.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                var originalValue = field.GetValue(originalInstance);
                if (originalValue != null)
                {
                    Type originalValueType = originalValue.GetType();

                    if (IsDirectValue(originalValueType))
                    {
                        // Is a direct value
                        field.SetValue(clone, originalValue);
                    }
                    else if (originalValueType.IsArray)
                    {
                        // Is an array
                        var oldArray = (Array)originalValue;
                        var newArray = (Array)originalValueType.GetConstructors().First().Invoke(new object[] { oldArray.Length });
                        Array.Copy(oldArray, newArray, oldArray.Length);
                        field.SetValue(clone, newArray);
                    }
                    else if (typeof(IList).IsAssignableFrom(originalValueType))
                    {
                        // It descends from IList
                        var list = originalValueType.GetConstructors().First().Invoke(null);
                        field.SetValue(clone, DoCloneList(originalValue as IList, list as IList));
                    }
                    else
                    {
                        // Is Other object
                        field.SetValue(clone, DoClone(originalValue));
                    }
                }
            }
            return clone;
        }

        /// <summary>
        /// Clones the specified original instance.
        /// </summary>
        /// <typeparam name="T">Type of the instance.</typeparam>
        /// <param name="originalInstance">The original instance.</param>
        /// <returns>The cloned instance.</returns>
        public static T Clone<T>(T originalInstance)
        {
            return (T)DoClone(originalInstance);
        }
    }
}

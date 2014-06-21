using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HeptaSoft.Common.Helpers
{
    /// <summary>
    /// Enum Helper class.
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Gets a collection with all the enum names present on the enumtype.
        /// </summary>
        /// <typeparam name="T">The enum type to consider.</typeparam>
        /// <returns>A collection of all the names present on that enum type or a Null if T is not an enum.</returns>
        public static ICollection<string> GetEnumNames<T>()
        {
            if (!typeof(T).IsEnum)
                return null;

            var array = Enum.GetNames(typeof(T));
            return new Collection<string>(array);
        }

        /// <summary>
        /// Gets a collection with all the enums ids present on the enumtype.
        /// </summary>
        /// <typeparam name="T">The enum type to consider.</typeparam>
        /// <returns>A list of all the enums present on that enum type or a Null if T is not an enum.</returns>
        public static ICollection<T> GetEnumIds<T>()
        {
            if (!typeof(T).IsEnum)
                return null;

            var array = (T[])Enum.GetValues(typeof(T));
            return new Collection<T>(array);
        }
    }
}

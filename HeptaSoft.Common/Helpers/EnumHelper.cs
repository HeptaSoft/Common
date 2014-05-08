using System;
using System.Collections.Generic;

namespace HeptaSoft.Common.Helpers
{
    /// <summary>
    /// Enum Helper class.
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Gets a list with all the enum names present on the enumtype.
        /// </summary>
        /// <typeparam name="T">The enum type to consider.</typeparam>
        /// <returns>A collection of all the names present on that enum type.</returns>
        public static ICollection<string> GetEnumNamesList<T>()
        {
            if (!typeof(T).IsEnum)
                return null;

            var array = Enum.GetNames(typeof(T));
            var list = new Collection<string>(array);
            return list;
        }

        /// <summary>
        /// Gets a list with all the enums present on the enumtype.
        /// </summary>
        /// <typeparam name="T">The enum type to consider.</typeparam>
        /// <returns>A list of all the enums present on that enum type.</returns>
        public static ICollection<T> GetEnumsList<T>()
        {
            if (!typeof(T).IsEnum)
                return null;

            var array = (T[])Enum.GetValues(typeof(T));
            var list = new Collection<T>(array);
            return list;
        }
    }
}

﻿using System;
using System.Collections.Generic;

namespace HeptaSoft.Common.Providers
{
    internal interface IFinderProvider
    {
        /// <summary>
        /// Gets the identification predicates associated with the specified type.
        /// </summary>
        /// <param name="entityType">Type of the entity.</param>
        /// <returns>All instances of <see cref="IFinder"/> defined for the specified type.</returns>
        IEnumerable<IFinder> GetFinders(Type entityType);
    }
}
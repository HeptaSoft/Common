﻿using System;

namespace HeptaSoft.Common.Providers
{
    internal interface IContextFactoryProvider
    {
        /// <summary>
        /// Gets the context factory associated with the specified entity type.
        /// </summary>
        /// <param name="entityType">Type of the entity.</param>
        /// <returns>The data context factory.</returns>
        Func<IDataContext> GetContextFactory(Type entityType);
    }
}
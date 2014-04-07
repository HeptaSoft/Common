using HeptaSoft.Common.DataAccess;
using HeptaSoft.Common.Modularity;

namespace HeptaSoft.Common
{
    internal static class ControlModule
    {
        /// <summary>
        /// The _underlying container.
        /// </summary>
        private static DependencyContainer underlyingContainer;

        /// <summary>
        /// Gets the owned resolver.
        /// </summary>
        /// <value>
        /// The owned resolver.
        /// </value>
        public static IFunctionalityResolver OwnedResolver
        {
            get
            {
                if (underlyingContainer == null)
                {
                    underlyingContainer = new DependencyContainer();
                    RegisterImplementations(underlyingContainer);
                }

                return underlyingContainer;
            }
        }

        /// <summary>
        /// Registers all internal the implementations using the registrant.
        /// </summary>
        /// <param name="containerRegistrant">The container registrant.</param>
        private static void RegisterImplementations(IFunctionalityRegistrator containerRegistrant)
        {
            // DataAccess
            containerRegistrant.RegisterAsSigleton(typeof(IEntityRepositoryFactory<>), typeof(EntityRepositoryFactory<>));
            
            // Modularity
            containerRegistrant.RegisterAsSigleton<IFunctionalityRegistrator, DependencyContainer>();
            containerRegistrant.RegisterAsSigleton<IFunctionalityResolver, DependencyContainer>();
        }
    }
}

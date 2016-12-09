/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Microsoft.Extensions.DependencyInjection;

namespace Cratis.Types
{
    /// <summary>
    /// Extends the <see cref="IServiceCollection"/> for settings up dependencies and their relations
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Configure services for Cratis.Types
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/> to configure for</param>
        public static void AddCratisTypes(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IContractToImplementorsMap), typeof(ContractToImplementorsMap));
            services.AddSingleton(typeof(ITypeFinder), typeof(TypeFinder));
            services.AddSingleton(typeof(IInstancesOf<>), typeof(InstancesOf<>));
            services.AddSingleton(typeof(IImplementationsOf<>), typeof(ImplementationsOf<>));
        }
    }
}
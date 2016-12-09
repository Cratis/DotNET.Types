/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Cratis.Types
{
    /// <summary>
    /// Represents an implementation of <see cref="IInstancesOf{T}"/>
    /// </summary>
    /// <typeparam name="T">Base type to discover for - must be an abstract class or an interface</typeparam>
    public class InstancesOf<T> : IInstancesOf<T>
        where T : class
    {
        IEnumerable<Type> _types;
        IServiceProvider _serviceProvider;

        /// <summary>
        /// Initalizes an instance of <see cref="IInstanceOf{T}"/>
        /// </summary>
        /// <param name="typeFinder"><see cref="ITypeDiscoverer"/> used for discovering types</param>
        /// <param name="serviceProvider"><see cref="IServiceProvider"/> used for managing instances of the types when needed</param>
        public InstancesOf(ITypeFinder typeFinder, IServiceProvider serviceProvider)
        {
            _types = typeFinder.FindMultiple<T>();
            _serviceProvider = serviceProvider;
        }

#pragma warning disable 1591 // Xml Comments
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var type in _types) yield return _serviceProvider.GetService(type) as T;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var type in _types) yield return _serviceProvider.GetService(type);
        }
#pragma warning restore 1591 // Xml Comments
    }
}

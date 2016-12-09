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
    /// Represents an implementation of <see cref="IImplementationsOf{T}"/>
    /// </summary>
    /// <typeparam name="T">Base type to discover for - must be an abstract class or an interface</typeparam>
    public class ImplementationsOf<T> : IImplementationsOf<T>
        where T : class
    {
        IEnumerable<Type> _types;

        /// <summary>
        /// Initializes a new instance of <see cref="ImplementationsOf{T}"/>
        /// </summary>
        /// <param name="typeFinder"><see cref="ITypeDiscoverer"/> to use for discovering types</param>
        public ImplementationsOf(ITypeFinder typeFinder)
        {
            _types = typeFinder.FindMultiple<T>();
        }

#pragma warning disable 1591 // Xml Comments
        public IEnumerator<Type> GetEnumerator()
        {
            return _types.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _types.GetEnumerator();
        }
#pragma warning restore 1591 // Xml Comments
    }
}
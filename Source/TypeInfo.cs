/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Reflection;

namespace Cratis.Types
{
    /// <summary>
    /// Represents an implementation of <see cref="ITypeInfo"/>
    /// </summary>
    /// <typeparam name="T">Type it holds info for</typeparam>
    public class TypeInfo<T> : ITypeInfo
    {
        /// <summary>
        /// Gets a singleton instance of the TypeInfo
        /// </summary>
        public static readonly TypeInfo<T> Instance = new TypeInfo<T>();

        TypeInfo()
        {
            var type = typeof(T); 
            HasDefaultConstructor = 
                type.GetTypeInfo().IsValueType ||
                type.HasDefaultConstructor();
        }

#pragma warning disable 1591 // Xml Comments
        public bool HasDefaultConstructor { get; private set; }
#pragma warning restore 1591 // Xml Comments

    }
}

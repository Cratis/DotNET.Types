/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace Cratis.Types
{
    /// <summary>
    /// Defines information for types
    /// </summary>
    public interface ITypeInfo
    {
        /// <summary>
        /// Gets a boolean indicating wether or not the type has a default constructor that takes no arguments
        /// </summary>
        bool HasDefaultConstructor { get; }
    }
}

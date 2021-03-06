﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;

namespace Cratis.Types
{
    /// <summary>
    /// Defines something that can discover implementations of types and give instance of these types
    /// when enumerated over
    /// </summary>
    /// <typeparam name="T">Base type to discover for - must be an abstract class or an interface</typeparam>
    public interface IInstancesOf<T> : IEnumerable<T>
        where T : class
    {
    }
}

﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;

namespace Cratis.Types
{
    /// <summary>
    /// Exception that is thrown when a type is not possible to be resolved by its name
    /// </summary>
    public class UnableToResolveTypeByName : ArgumentException
    {
        /// <summary>
        /// Initializes an instance of <see cref="UnableToResolveTypeByName"/>
        /// </summary>
        /// <param name="typeName"></param>
        public UnableToResolveTypeByName(string typeName) : base(string.Format("Unable to resolve '{0}'.", typeName))
        {

        }
    }
}

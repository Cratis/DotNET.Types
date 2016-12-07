/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Linq;
using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;

namespace Cratis.Types.Specs.for_ImplementationsOf
{
    public class when_having_multiple_implementations
    {
        static Mock<ITypeDiscoverer>   type_discoverer_mock;
        static Type[] instances;

        Establish context = () => 
        {
            type_discoverer_mock = new Mock<ITypeDiscoverer>();
            type_discoverer_mock.Setup(t => t.FindMultiple<IAmAnInterface>()).Returns(new Type[] {
                typeof(OneImplementation),
                typeof(SecondImplementation)
            });
        };

        Because of = () => instances = new ImplementationsOf<IAmAnInterface>(type_discoverer_mock.Object).ToArray();

        It should_get_the_implementations = () => instances.ShouldContainOnly(new[] { typeof(OneImplementation), typeof(SecondImplementation)});
    }
}

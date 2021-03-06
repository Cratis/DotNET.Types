﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Linq;
using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;

namespace Cratis.Types.Specs.for_InstancesOf
{
    public class when_having_multiple_implementations
    {
        static Mock<ITypeFinder>   type_finder_mock;
        static Mock<IServiceProvider> container_mock;
        static IAmAnInterface[] instances;

        static OneImplementation one_implementation_instance;
        static SecondImplementation second_implemenation_instance;

        Establish context = () => 
        {
            type_finder_mock = new Mock<ITypeFinder>();
            type_finder_mock.Setup(t => t.FindMultiple<IAmAnInterface>()).Returns(new Type[] {
                typeof(OneImplementation),
                typeof(SecondImplementation)
            });
            container_mock = new Mock<IServiceProvider>();
            one_implementation_instance = new OneImplementation();
            container_mock.Setup(c => c.GetService(typeof(OneImplementation))).Returns(one_implementation_instance);
            second_implemenation_instance = new SecondImplementation();
            container_mock.Setup(c => c.GetService(typeof(SecondImplementation))).Returns(second_implemenation_instance);
        };

        Because of = () => instances = new InstancesOf<IAmAnInterface>(type_finder_mock.Object, container_mock.Object).ToArray();

        It should_get_the_implementations = () => instances.ShouldContainOnly(one_implementation_instance, second_implemenation_instance);
             
    }
}

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using Machine.Specifications;

namespace Cratis.Types.Specs.for_TypeDiscoverer
{
    [Subject(typeof(TypeDiscoverer))]
    public class when_finding_type_by_name_that_does_not_exist : given.a_type_discoverer
    {
        static Type type_found;

        Establish context = () => type_finder_mock.Setup(t => t.FindTypeByFullName(contract_to_implementors_map_mock.Object, Moq.It.IsAny<string>())).Returns((Type)null);

        Because of = () => type_found = type_discoverer.FindTypeByFullName(typeof(Single).FullName + "Blah");

        It should_be_null = () => type_found.ShouldBeNull();
    }
}
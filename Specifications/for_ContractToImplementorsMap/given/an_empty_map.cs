using Cratis.Types;
using Machine.Specifications;

namespace Cratis.Types.Specs.for_ContractToImplementorsMap.given
{
    public class an_empty_map
    {
        protected static ContractToImplementorsMap map;

        Establish context = () => map = new ContractToImplementorsMap();
    }
}

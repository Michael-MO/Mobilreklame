using ExtensionsModel.Implementation;
using InMemoryStorage.Implementation;
using Mobilreklame.DataTransformations.Domain.Montering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.Model.Domain.Montering
{
    public class MonteringCatalog : InMemoryCatalog<Montering>
    {
        private static MonteringCatalog _Instance = new MonteringCatalog();
        public static MonteringCatalog Instance => _Instance;
        private MonteringCatalog()
        {

        }

        public override Montering CreateDomainObjectFromDTO(Montering dtoObj)
        {
            return dtoObj;
        }

        public override Montering CreateDTO(Montering obj)
        {
            return obj;
        }

        public override Montering CreateDomainObjectFromVMO(Montering vmObj)
        {
            return vmObj;
        }
        public override Montering CreateVMO(Montering obj)
        {
            return obj;
        }
    }
}

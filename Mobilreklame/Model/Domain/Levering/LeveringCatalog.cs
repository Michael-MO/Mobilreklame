using ExtensionsModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Levering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.Model.Domain.Levering
{
    public class LeveringCatalog : InMemoryCatalog<Levering>
    {
        private static LeveringCatalog _Instance = new LeveringCatalog();
        public static LeveringCatalog Instance => _Instance;
        private LeveringCatalog()
        {

        }

        public override Levering CreateDomainObjectFromDTO(Levering dtoObj)
        {
            return dtoObj;
        }

        public override Levering CreateDomainObjectFromVMO(Levering vmObj)
        {
            return vmObj;
        }

        public override Levering CreateDTO(Levering obj)
        {
            return obj;
        }

        public override Levering CreateVMO(Levering obj)
        {
            return obj;
        }
    }
}

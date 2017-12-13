using ExtensionsModel.Implementation;
using InMemoryStorage.Implementation;
using Mobilreklame.DataTransformations.Domain.Kunde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.Model.Domain.Kunde 
{
    public class KundeCatalog : InMemoryCatalog<Kunde>
    {
        private static KundeCatalog _Instance = new KundeCatalog();
        public static KundeCatalog Instance => _Instance;
        private KundeCatalog()
        {

        }

        public override Kunde CreateDomainObjectFromDTO(Kunde dtoObj)
        {
            return dtoObj;
        }

        public override Kunde CreateDomainObjectFromVMO(Kunde vmObj)
        {
            return vmObj;
        }

        public override Kunde CreateDTO(Kunde obj)
        {
            return obj;
        }

        public override Kunde CreateVMO(Kunde obj)
        {
            return obj;
        }
    }
}

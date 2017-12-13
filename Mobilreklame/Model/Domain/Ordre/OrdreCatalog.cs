using InMemoryStorage.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilreklame.DataTransformations.Domain.Ordre;
using System.Collections.ObjectModel;
using ExtensionsModel.Implementation;

namespace Mobilreklame.Model.Domain.Ordre
{
    public class OrdreCatalog : InMemoryCatalog<Ordre>
    {
        private static OrdreCatalog _Instance = new OrdreCatalog();
        public static OrdreCatalog Instance => _Instance;
        private OrdreCatalog()
        {

        }
        public override Ordre CreateDomainObjectFromDTO(Ordre dtoObj)
        {
            return dtoObj;
        }
        public override Ordre CreateDTO(Ordre obj)
        {
            return obj;
        }
        public override Ordre CreateDomainObjectFromVMO(Ordre vmObj)
        {
            return vmObj;
        }

        

        public override Ordre CreateVMO(Ordre obj)
        {
            return obj;
        }
    }
}

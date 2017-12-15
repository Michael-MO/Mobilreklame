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
    public class MonteringCatalog : FilePersistableCatalog<Montering, MonteringViewModel, Montering>
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

        public override Montering CreateDomainObjectFromVMO(MonteringViewModel obj)
        {
            Montering KVM = new Montering();
            KVM.Key = obj.Key;
            KVM.LeveringID = obj.LeveringID;
            return KVM;
        }
        public override MonteringViewModel CreateVMO(Montering obj)
        {
            MonteringViewModel KVM = new MonteringViewModel();
            KVM.Key = obj.Key;
            KVM.LeveringID = obj.LeveringID;
            return KVM;
        }
    }
}

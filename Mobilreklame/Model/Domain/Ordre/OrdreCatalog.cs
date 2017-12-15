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
    public class OrdreCatalog : FilePersistableCatalog<Ordre, OrdreViewModel, Ordre>
    {
        private static OrdreCatalog _Instance = new OrdreCatalog();
        public static OrdreCatalog Instance => _Instance;
        private OrdreCatalog()
        {
        }
        public override Ordre CreateDomainObjectFromDTO(Ordre obj)
        {
            return obj;
        }
        public override Ordre CreateDTO(Ordre obj)
        {
            return obj;
        }

        public override OrdreViewModel CreateVMO(Ordre obj)
        {
            OrdreViewModel KVM = new OrdreViewModel();
            KVM.CustomerRefID = obj.CustomerRefID;
            KVM.Date = obj.Date;
            KVM.Delivery = obj.Delivery;
            KVM.Description = obj.Description;
            KVM.ExtraProduction = obj.ExtraProduction;
            KVM.Key = obj.Key;
            return KVM;
        }
        public override Ordre CreateDomainObjectFromVMO(OrdreViewModel obj)
        {
            Ordre OVM = new Ordre();
            OVM.CustomerRefID = obj.CustomerRefID;
            OVM.Date = obj.Date;
            OVM.Delivery = obj.Delivery;
            OVM.Description = obj.Description;
            OVM.ExtraProduction = obj.ExtraProduction;
            OVM.Key = obj.Key;
            return OVM;
        }
    }
}

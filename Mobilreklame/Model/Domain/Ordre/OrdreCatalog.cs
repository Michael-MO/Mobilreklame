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
        public override Ordre CreateDomainObjectFromDTO(Ordre dtoObj)
        {
            return dtoObj;
        }
        public override Ordre CreateDTO(Ordre obj)
        {
            return obj;
        }
        public override Ordre CreateDomainObjectFromVMO(OrdreViewModel vmObj)
        {
            Ordre EnOrdre = new Ordre();
            EnOrdre.Key = vmObj.Key;
            EnOrdre.CustomerRefID = vmObj.CustomerRefID;
            EnOrdre.Date = vmObj.Date;
            EnOrdre.Delivery = vmObj.Delivery;
            EnOrdre.Description = vmObj.Description;
            EnOrdre.ExtraProduction = vmObj.ExtraProduction;
            return EnOrdre;
        }

        

        public override OrdreViewModel CreateVMO(Ordre obj)
        {
            OrdreViewModel vmoObj = new OrdreViewModel();
            vmoObj.Key = obj.Key;
            vmoObj.CustomerRefID = obj.CustomerRefID;
            vmoObj.Date = obj.Date;
            vmoObj.Delivery = obj.Delivery;
            vmoObj.Description = obj.Description;
            vmoObj.ExtraProduction = obj.ExtraProduction;
            return vmoObj;
        }
    }
}

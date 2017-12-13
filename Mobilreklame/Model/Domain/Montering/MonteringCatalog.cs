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

        public override Montering CreateDomainObjectFromVMO(MonteringViewModel vmObj)
        {
            Montering EnMontering = new Montering();
            EnMontering.Key = vmObj.Key;
            EnMontering.CustomerID = vmObj.CustomerID;
            EnMontering.MonteringID = vmObj.MonteringID;
            return EnMontering;
        }
        public override MonteringViewModel CreateVMO(Montering obj)
        {
            MonteringViewModel vmoObj = new MonteringViewModel();
            vmoObj.CustomerID = obj.CustomerID;
            vmoObj.Key = obj.Key;
            vmoObj.MonteringID = obj.MonteringID;
            return vmoObj;
        }
    }
}

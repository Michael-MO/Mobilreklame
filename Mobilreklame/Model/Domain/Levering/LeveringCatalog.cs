using ExtensionsModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Levering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.Model.Domain.Levering
{
    public class LeveringCatalog : FilePersistableCatalog<Levering, LeveringViewModel, Levering>
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

        public override Levering CreateDomainObjectFromVMO(LeveringViewModel vmObj)
        {
            Levering EnLevering = new Levering();
            EnLevering.Adresse = vmObj.Adresse;
            EnLevering.By = vmObj.By;
            EnLevering.CustomerRefID = vmObj.CustomerRefID;
            EnLevering.Dato = vmObj.Dato;
            EnLevering.Key = vmObj.Key;
            EnLevering.Montering = vmObj.Montering;
            EnLevering.OrderID = vmObj.OrderID;
            EnLevering.Tidspunkt = vmObj.Tidspunkt;
            EnLevering.Zip = vmObj.Zip;
            return EnLevering;
        }

        public override Levering CreateDTO(Levering obj)
        {
            return obj;
        }

        public override LeveringViewModel CreateVMO(Levering obj)
        {
            LeveringViewModel vmoObj = new LeveringViewModel();
            vmoObj.Adresse = obj.Adresse;
            vmoObj.By = obj.By;
            vmoObj.CustomerRefID = obj.CustomerRefID;
            vmoObj.Dato = obj.Dato;
            vmoObj.Key = obj.Key;
            vmoObj.Montering = obj.Montering;
            vmoObj.OrderID = obj.OrderID;
            vmoObj.Tidspunkt = obj.Tidspunkt;
            vmoObj.Zip = obj.Zip;
            return vmoObj;
        }
    }
}

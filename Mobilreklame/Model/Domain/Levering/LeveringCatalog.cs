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
            Load();
            CatalogChanged += i => Save();
        }


        public override Levering CreateDomainObjectFromDTO(Levering dtoObj)
        {
            return dtoObj;
        }

        public override Levering CreateDomainObjectFromVMO(LeveringViewModel obj)
        {
            Levering KVM = new Levering();
            KVM.Adresse = obj.Adresse;
            KVM.By = obj.By;
            KVM.CustomerRefID = obj.CustomerRefID;
            KVM.Dato = obj.Dato;
            KVM.Key = obj.Key;
            KVM.Montering = obj.Montering;
            KVM.OrderID = obj.OrderID;
            KVM.Tidspunkt = obj.Tidspunkt;
            KVM.Zip = obj.Zip;
            return KVM;
        }

        public override Levering CreateDTO(Levering obj)
        {
            return obj;
        }

        public override LeveringViewModel CreateVMO(Levering obj)
        {
            LeveringViewModel KVM = new LeveringViewModel();
            KVM.Adresse = obj.Adresse;
            KVM.By = obj.By;
            KVM.CustomerRefID = obj.CustomerRefID;
            KVM.Dato = obj.Dato;
            KVM.Key = obj.Key;
            KVM.Montering = obj.Montering;
            KVM.OrderID = obj.OrderID;
            KVM.Tidspunkt = obj.Tidspunkt;
            KVM.Zip = obj.Zip;
            return KVM;
        }
    }
}

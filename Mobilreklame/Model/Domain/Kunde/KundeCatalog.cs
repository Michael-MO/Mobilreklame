using System;
using ExtensionsModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Kunde;

namespace Mobilreklame.Model.Domain.Kunde
{
    public class KundeCatalog : FilePersistableCatalog<Kunde, KundeViewModel, Kunde>
    {
        private static KundeCatalog _Instance = new KundeCatalog();
        public static KundeCatalog Instance => _Instance;
        private KundeCatalog()
        {
            Load();
            CatalogChanged += i => Save();
        }

        public override Kunde CreateDomainObjectFromDTO(Kunde dtoObj)
        {
            return dtoObj;
        }

        public override Kunde CreateDomainObjectFromVMO(KundeViewModel obj)
        {
            Kunde k = new Kunde();
            k.City = obj.City;
            k.Company = obj.Company;
            k.CvrNr = obj.CvrNr;
            k.Email = obj.Email;
            k.Key = obj.Key;
            k.Name = obj.Name;
            k.PhoneNumber = obj.PhoneNumber;
            k.Street = obj.Street;
            k.ZipCode = obj.ZipCode;
            return k;
        }

        public override Kunde CreateDTO(Kunde obj)
        {
            return obj;
        }

        public override KundeViewModel CreateVMO(Kunde obj)
        {
            KundeViewModel KVM = new KundeViewModel();
            KVM.City = obj.City;
            KVM.Company = obj.Company;
            KVM.CvrNr = obj.CvrNr;
            KVM.Email = obj.Email;
            KVM.Key = obj.Key;
            KVM.Name = obj.Name;
            KVM.PhoneNumber = obj.PhoneNumber;
            KVM.Street = obj.Street;
            KVM.ZipCode = obj.ZipCode;
            return KVM;
        }
    }
}
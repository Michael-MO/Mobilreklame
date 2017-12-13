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
    public class KundeCatalog : FilePersistableCatalog<Kunde, KundeViewModel, Kunde>
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

        public override Kunde CreateDomainObjectFromVMO(KundeViewModel vmObj)
        {
            Kunde EnKunde = new Kunde();
            EnKunde.City = vmObj.City;
            EnKunde.Company = vmObj.Company;
            EnKunde.CvrNr = vmObj.CvrNr;
            EnKunde.Email = vmObj.Email;
            EnKunde.Key = vmObj.Key;
            EnKunde.Name = vmObj.Name;
            EnKunde.PhoneNumber = vmObj.PhoneNumber;
            EnKunde.Street = vmObj.Street;
            EnKunde.ZipCode = vmObj.ZipCode;
            return EnKunde;
        }

        public override Kunde CreateDTO(Kunde obj)
        {
            return obj;
        }

        public override KundeViewModel CreateVMO(Kunde obj)
        {
            KundeViewModel vmoObj = new KundeViewModel();
            vmoObj.City = obj.City;
            vmoObj.Company = obj.Company;
            vmoObj.CvrNr = obj.CvrNr;
            vmoObj.Email = obj.Email;
            vmoObj.Key = obj.Key;
            vmoObj.Name = obj.Name;
            vmoObj.PhoneNumber = obj.PhoneNumber;
            vmoObj.Street = obj.Street;
            vmoObj.ZipCode = obj.ZipCode;
            return vmoObj;
        }
    }
}

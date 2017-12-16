using System;
using DataTransformation.Implementation;

namespace Mobilreklame.DataTransformations.Domain.Kunde
{
    public class KundeViewModel : CopyableWithDefaultValuesBase
    {
        //int key;
        //string name;
        //string phoneNumber;
        //string email;
        //string cvrNr;
        //string street;
        //int zipCode;
        //string city;
        //string company;
        public KundeViewModel()
        {

        }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CvrNr { get; set; }
        public string Street { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public override void SetDefaultValues()
        {
            Key = NullKey;
            Name = "";
            PhoneNumber = "";
            Email = "";
            CvrNr = "";
            Street = "";
            ZipCode = 0;
            City = "";
            Company = "";
        }
    }
}
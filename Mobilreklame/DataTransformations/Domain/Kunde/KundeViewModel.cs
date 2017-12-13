using DataTransformation.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.DataTransformations.Domain.Kunde
{
    public class KundeViewModel : CopyableWithDefaultValuesBase
    {
        int key;
        string name;
        string phoneNumber;
        string email;
        string cvrNr;
        string street;
        int zipCode;
        string city;
        string company;
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
        }
    }
}

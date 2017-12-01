using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace Mobilreklame.Model.Domain.Kunde
{
    public class Kunde : TransformedBase<Kunde>
    {
        public Kunde(
            string name,
            string phoneNumber,
            string email,
            string cvrNr,
            string address,
            int zipCode,
            string company) : base(NullKey)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            CvrNr = cvrNr;
            Address = address;
            ZipCode = zipCode;
            Company = company;
        }

        public Kunde() : base(NullKey)
        {

        }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CvrNr { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string Company { get; set; }

        public override void SetValuesFromObject(Kunde obj)
        {
            Key = obj.Key;
            Name = obj.Name;
            PhoneNumber = obj.PhoneNumber;
            Email = obj.Email;
            CvrNr = obj.CvrNr;
            Address = obj.Address;
            ZipCode = obj.ZipCode;
            Company = obj.Company;
        }
    }
}

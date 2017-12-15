using InMemoryStorage.Implementation;

namespace Mobilreklame.Model.Domain.Kunde
{
    public class Kunde : CopyableBase
    {
        public Kunde(int key, string name, string phoneNumber, string email, string cvrNr, string street, int zipCode, string city, string company)
            : base(key)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            CvrNr = cvrNr;
            Street = street;
            ZipCode = zipCode;
            City = city;
            Company = company;
        }

        public Kunde() : base(NullKey)
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
    }
}

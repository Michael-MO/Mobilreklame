using System;
using DataTransformation.Implementation;

namespace Mobilreklame.DataTransformations.Domain.Kunde
{
    public class KundeViewModel : Model.Domain.Kunde.Kunde
    {
        public KundeViewModel()
        {
        }

        public KundeViewModel(int key, string name, string phoneNumber, string email, string cvrNr, string street, int zipCode, string city, string company)
            : base(key, name, phoneNumber, email, cvrNr, street, zipCode, city, company)
        {

        }
    }
}
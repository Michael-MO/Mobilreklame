using System;
using ExtensionsModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Kunde;

namespace Mobilreklame.Model.Domain.Kunde
{
    public class KundeCatalog : InMemoryCatalog<KundeViewModel>
    {
        #region Model Singleton implementation
        private static KundeCatalog _instance;

        public static KundeCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new KundeCatalog();
                return _instance;
            }
        }

        private KundeCatalog()
        {
            Create(new KundeViewModel(1, "Michael Olson", "11 22 33 44", "Michael@mail.dk", "DK11223344", "Danmarksgade 11", 1234, "Danby", "Danfirma A/S"));
            Create(new KundeViewModel(2, "Daniel Stenalt", "11 22 33 44", "Daniel@mail.dk", "DK11223344", "Danmarksgade 11", 1234, "Danby", "Danfirma A/S"));
            Create(new KundeViewModel(3, "Benjamin Jessen", "11 22 33 44", "Benjamin@mail.dk", "DK11223344", "Danmarksgade 11", 1234, "Danby", "Danfirma A/S"));
            Create(new KundeViewModel(4, "Tristan Kamp", "11 22 33 44", "Tristan@mail.dk", "DK11223344", "Danmarksgade 11", 1234, "Danby", "Danfirma A/S"));
        }
        #endregion

        #region Transformation methods

        #endregion
    }
}
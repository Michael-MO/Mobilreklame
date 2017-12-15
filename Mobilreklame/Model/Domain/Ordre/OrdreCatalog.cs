using System;
using ExtensionsModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Ordre;

namespace Mobilreklame.Model.Domain.Ordre
{
    public class OrdreCatalog : InMemoryCatalog<OrdreViewModel>
    {
        #region Model Singleton implementation
        private static OrdreCatalog _instance;

        public static OrdreCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new OrdreCatalog();
                return _instance;
            }
        }

        private OrdreCatalog()
        {
            Create(new OrdreViewModel(1, 1, DateTimeOffset.Now, "Beskrivelse", false, false));
            Create(new OrdreViewModel(2, 1, DateTimeOffset.Now, "Beskrivelse", false, false));
            Create(new OrdreViewModel(3, 1, DateTimeOffset.Now, "Beskrivelse", false, false));
            Create(new OrdreViewModel(4, 1, DateTimeOffset.Now, "Beskrivelse", false, false));
            Create(new OrdreViewModel(5, 1, DateTimeOffset.Now, "Beskrivelse", false, false));
            Create(new OrdreViewModel(6, 1, DateTimeOffset.Now, "Beskrivelse", false, false));
        }
        #endregion

        #region Transformation methods

        #endregion
    }
}
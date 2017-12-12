using ExtensionsModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Ordre;

namespace Mobilreklame.Model.Domain.Ordre
{
    public class OrdreCatalog : FilePersistableCatalog<Ordre, OrdreViewModel, Ordre>
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
        }
        #endregion

        #region Transformation methods
        public override Ordre CreateDomainObjectFromDTO(Ordre obj)
        {
            return obj;
        }

        public override Ordre CreateDTO(Ordre obj)
        {
            return obj;
        }

        public override Ordre CreateDomainObjectFromVMO(OrdreViewModel vmObj)
        {
            return new Ordre(
                vmObj.Key,
                vmObj.CustomerRefID,
                vmObj.Date,
                vmObj.Description,
                vmObj.Delivery,
                vmObj.ExtraProduction);
        }

        public override OrdreViewModel CreateVMO(Ordre obj)
        {
            OrdreViewModel vmObj = new OrdreViewModel();

            vmObj.Key = obj.Key;
            vmObj.CustomerRefID = obj.CustomerRefID;
            vmObj.Date = obj.Date;
            vmObj.Description = obj.Description;
            vmObj.Delivery = obj.Delivery;
            vmObj.ExtraProduction = obj.ExtraProduction;

            return vmObj;
        }
        #endregion
    }
}
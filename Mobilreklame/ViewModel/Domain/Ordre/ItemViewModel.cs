using Mobilreklame.DataTransformations.Domain.Ordre;
using Mobilreklame.Model.App;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Ordre
{
    public class ItemViewModel : ItemViewModelBase<OrdreViewModel>
    {
        public override string Description
        {
            get { return "Ordre nr." + DataObject.Key + " for kunde med ID: " + DataObject.CustomerRefID; }
        }

        public int Key
        {
            get { return DataObject.Key; }
        }

        private OrdreViewModel GetOrdre()
        {
            return ObjectProvider.OrdreCatalog.Read(DataObject.Key) as OrdreViewModel;
        }

        public ItemViewModel(OrdreViewModel obj) : base(obj)
        {
        }
    }
}
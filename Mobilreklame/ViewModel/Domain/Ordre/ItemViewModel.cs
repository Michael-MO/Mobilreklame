using Mobilreklame.DataTransformations.Domain.Ordre;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Ordre
{
    public class ItemViewModel : ItemViewModelBase<OrdreViewModel>
    {
        public override string Description
        {
            get { return DataObject.Description; }
        }

        public int Key
        {
            get { return DataObject.Key; }
        }

        public ItemViewModel(OrdreViewModel obj) : base(obj)
        {
        }
    }
}
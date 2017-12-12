using DataTransformation.Interfaces;
using Mobilreklame.DataTransformations.Domain.Ordre;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Ordre
{
    public class ViewModelFactory : ViewModelFactoryBase<OrdreViewModel>
    {
        public override IDataWrapper<OrdreViewModel> CreateDetailsViewModel(OrdreViewModel obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<OrdreViewModel> CreateItemViewModel(OrdreViewModel obj)
        {
            return new ItemViewModel(obj);
        }
    }
}
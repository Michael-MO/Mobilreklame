using DataTransformation.Interfaces;
using Mobilreklame.DataTransformations.Domain.Kunde;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Kunde
{
    public class ViewModelFactory : ViewModelFactoryBase<KundeViewModel>
    {
        public override IDataWrapper<KundeViewModel> CreateDetailsViewModel(KundeViewModel obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<KundeViewModel> CreateItemViewModel(KundeViewModel obj)
        {
            return new ItemViewModel(obj);
        }
    }
}
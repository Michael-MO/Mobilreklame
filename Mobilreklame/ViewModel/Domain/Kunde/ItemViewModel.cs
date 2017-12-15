using Mobilreklame.DataTransformations.Domain.Kunde;
using Mobilreklame.Model.App;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Kunde
{
    public class ItemViewModel : ItemViewModelBase<KundeViewModel>
    {
        public string Name
        {
            get { return DataObject.Name; }
        }

        public override string Description
        {
            get { return $"{DataObject.Name}, from {DataObject.Company}."; }
        }

        public int Key
        {
            get { return DataObject.Key; }
        }

        public string Company
        {
            get { return DataObject.Company; }
        }

        private KundeViewModel GetKunde()
        {
            return ObjectProvider.KundeCatalog.Read(DataObject.Key) as KundeViewModel;
        }

        public ItemViewModel(KundeViewModel obj) : base(obj)
        {
        }
    }
}
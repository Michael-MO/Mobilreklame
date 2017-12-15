using Mobilreklame.DataTransformations.Domain.Ordre;
using Mobilreklame.Model.App;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Ordre
{
    class DetailsViewModel : DetailsViewModelBase<OrdreViewModel>
    {
        private ObservableCollection<Kunde.ItemViewModel> _kundeCollection = new ObservableCollection<Kunde.ItemViewModel>();
        public DetailsViewModel(OrdreViewModel obj) : base(obj)
        {
            _kundeCollection = new ObservableCollection<Kunde.ItemViewModel>();
            Kunde.ViewModelFactory Factory = new Kunde.ViewModelFactory();
            foreach (var kundeData in ObjectProvider.KundeCatalog.All)
            {
                
                _kundeCollection.Add(new Kunde.ItemViewModel(Factory.KundeToViewModel(kundeData)));
            }
        }
        public ObservableCollection<Kunde.ItemViewModel> KundeCollection
        {
            get { return _kundeCollection; }
        }
        private Kunde.ItemViewModel GetKunde()
        {
            foreach (var kundeItemViewModel in _kundeCollection)
            {
                if (kundeItemViewModel.DataObject.Key == DataObject.CustomerRefID)
                {
                    return kundeItemViewModel;
                }
            }
            return null;
        }
    }
}

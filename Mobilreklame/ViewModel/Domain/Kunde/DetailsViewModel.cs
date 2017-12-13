using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionsViewModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Ordre;
using Mobilreklame.DataTransformations.Domain.Kunde;
using Mobilreklame.ViewModel.Domain.Kunde;
using Mobilreklame.Model.App;
using ViewModel.Implementation;
using System.Collections.ObjectModel;

namespace Mobilreklame.ViewModel.Domain.Kunde
{
    class DetailsViewModel : DetailsViewModelBase<KundeViewModel>
    {
        private ObservableCollection<Ordre.ItemViewModel> _observableCollectionOrdre;

        public DetailsViewModel(KundeViewModel obj) : base(obj)
        {
        }

        public ObservableCollection<Ordre.ItemViewModel> ObservableCollectionOrdre
        {
            get
            {
                ObservableCollection<Ordre.ItemViewModel> filteredOrders = new ObservableCollection<Ordre.ItemViewModel>();
                foreach (var ordreItemViewModel in _observableCollectionOrdre)
                {
                    if (ordreItemViewModel.DataObject.CustomerRefID == DataObject.Key)
                    {
                        filteredOrders.Add(ordreItemViewModel);
                    }
                }
                return filteredOrders;
            }
        }
    }
}

using Mobilreklame.DataTransformations.Domain.Levering;
using Mobilreklame.DataTransformations.Domain.Ordre;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Levering
{

    class DetailsViewModel : DetailsViewModelBase<LeveringViewModel>
    {
        private ObservableCollection<Ordre.ItemViewModel> _ordreCollection = new ObservableCollection<Ordre.ItemViewModel>();
        public DetailsViewModel(LeveringViewModel obj) : base(obj)
        {
        }
        public ObservableCollection<Ordre.ItemViewModel> OrdreCollection
        {
            get { return _ordreCollection; }
        }
        public Ordre.ItemViewModel ObservableCollectionOrdre
        {
            get
            {
                foreach (var ordreItemViewModel in _ordreCollection)
                {
                    if (ordreItemViewModel.DataObject.Key == DataObject.OrderID)
                    {
                        return ordreItemViewModel;
                    }
                }
                return null;
            }
        }
    }
}

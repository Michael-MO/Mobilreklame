using Mobilreklame.DataTransformations.Domain.Kunde;
using Mobilreklame.DataTransformations.Domain.Montering;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Montering
{
    class DetailsViewModel : DetailsViewModelBase<MonteringViewModel>
    {
        private ObservableCollection<Levering.ItemViewModel> _leveringCollection = new ObservableCollection<Levering.ItemViewModel>();
        public DetailsViewModel(MonteringViewModel obj) : base(obj)
        {
        }
        public ObservableCollection<Levering.ItemViewModel> LeveringCollection
        {
            get { return _leveringCollection; }
        }
        public Levering.ItemViewModel LeveringReference
        {
            get
            {
                
                foreach (var leveringItemViewModel in _leveringCollection)
                {
                    if (leveringItemViewModel.DataObject.Key == DataObject.LeveringID)
                    {
                        return leveringItemViewModel;
                    }
                }
                return null;
            }
        }
    }
}

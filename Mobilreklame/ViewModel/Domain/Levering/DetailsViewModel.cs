using Mobilreklame.DataTransformations.Domain.Levering;
using Mobilreklame.Model.App;
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
        private ObservableCollection<Levering.ItemViewModel> _leveringCollection = new ObservableCollection<Levering.ItemViewModel>();
        public int OrderID
        {
            get { return DataObject.OrderID; }
            set
            {
                OrderID = value;
                OnPropertyChanged();
            }
        }
        public int CustomerRefID
        {
            get { return DataObject.CustomerRefID; }
            set
            {
                CustomerRefID = value;
                OnPropertyChanged();
            }
        }
        public DateTime Dato
        {
            get { return DataObject.Dato; }
            set { DataObject.Dato = value;
                OnPropertyChanged();
            }
        }
        public TimeSpan Tidspunkt
        {
            get { return DataObject.Tidspunkt; }
            set { DataObject.Tidspunkt = value;
                OnPropertyChanged();
            }
        }
        public string Adresse
        {
            get { return DataObject.Adresse; }
            set { DataObject.Adresse = value;
                OnPropertyChanged();
            }
        }
        public string By
        {
            get { return DataObject.By; }
            set { DataObject.By = value;
                OnPropertyChanged();
            }
        }
        public int Zip
        {
            get { return DataObject.Zip; }
            set { DataObject.Zip = value;
                OnPropertyChanged();
            }
        }
        public bool Montering
        {
            get { return DataObject.Montering; }
            set { DataObject.Montering = value;
                OnPropertyChanged();
            }
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
        public ObservableCollection<Levering.ItemViewModel> CollectionLevering
        {
            get { return _leveringCollection; }
        }

        public DetailsViewModel(LeveringViewModel obj) : base(obj)
        {
            _leveringCollection = new ObservableCollection<Levering.ItemViewModel>();

            foreach (var leveringData in ObjectProvider.LeveringCatalog.All)
            {
                _leveringCollection.Add(new Levering.ItemViewModel(leveringData));
            }
        }
    }
}

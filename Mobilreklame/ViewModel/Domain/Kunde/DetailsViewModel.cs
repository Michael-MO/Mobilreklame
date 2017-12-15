using System;
using System.Collections.ObjectModel;
using Mobilreklame.DataTransformations.Domain.Kunde;
using Mobilreklame.Model.App;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Kunde
{
    public class DetailsViewModel : DetailsViewModelBase<KundeViewModel>
    {
        private ObservableCollection<Kunde.ItemViewModel> _observableCollectionKunde;

        public string Name
        {
            get { return DataObject.Name; }
            set
            {
                DataObject.Name = value;
                OnPropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get { return "+45 " + DataObject.PhoneNumber; }
            set
            {
                DataObject.PhoneNumber = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return DataObject.Email; }
            set
            {
                DataObject.Email = value;
                OnPropertyChanged();
            }
        }

        public string CvrNr
        {
            get { return DataObject.CvrNr; }
            set
            {
                DataObject.CvrNr = value;
                OnPropertyChanged();
            }
        }

        public string Street
        {
            get { return DataObject.Street; }
            set
            {
                DataObject.Street = value;
                OnPropertyChanged();
            }
        }

        public int ZipCode
        {
            get { return DataObject.ZipCode; }
            set
            {
                DataObject.ZipCode = value;
                OnPropertyChanged();
            }
        }

        public string City
        {
            get { return DataObject.City; }
            set
            {
                DataObject.City = value;
                OnPropertyChanged();
            }
        }

        public string Company
        {
            get { return DataObject.Company; }
            set
            {
                DataObject.Company = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Kunde.ItemViewModel> CollectionKunde
        {
            get { return _observableCollectionKunde; }
        }

        public DetailsViewModel(KundeViewModel obj) : base(obj)
        {
            _observableCollectionKunde = new ObservableCollection<Kunde.ItemViewModel>();

            foreach (var kundeData in ObjectProvider.KundeCatalog.All)
            {
                _observableCollectionKunde.Add(new Kunde.ItemViewModel(kundeData));
            }
        }
    }
}
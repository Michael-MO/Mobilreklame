using System;
using System.Collections.ObjectModel;
using Mobilreklame.DataTransformations.Domain.Ordre;
using Mobilreklame.Model.App;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Ordre
{
    public class DetailsViewModel : DetailsViewModelBase<OrdreViewModel>
    {
        public int CustomerRefID
        {
            get { return DataObject.CustomerRefID; }
            set
            {
                DataObject.CustomerRefID = value;
                OnPropertyChanged();
            }
        }

        public DateTimeOffset Date
        {
            get { return DataObject.Date; }
            set
            {
                DataObject.Date = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return DataObject.Description; }
            set
            {
                DataObject.Description = value;
                OnPropertyChanged();
            }
        }

        public bool Delivery
        {
            get { return DataObject.Delivery; }
            set
            {
                DataObject.Delivery = value;
                OnPropertyChanged();
            }
        }

        public bool ExtraProduction
        {
            get { return DataObject.ExtraProduction; }
            set
            {
                DataObject.ExtraProduction = value;
                OnPropertyChanged();
            }
        }

        public DetailsViewModel(OrdreViewModel obj) : base(obj)
        {
        }
    }
}
using Mobilreklame.DataTransformations.Domain.Kunde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;
using DataTransformation.Interfaces;

namespace Mobilreklame.ViewModel.Domain.Kunde
{
    class ViewModelFactory : ViewModelFactoryBase<KundeViewModel>
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

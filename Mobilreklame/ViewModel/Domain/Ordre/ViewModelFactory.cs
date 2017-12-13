using DataTransformation.Interfaces;
using Mobilreklame.DataTransformations.Domain.Ordre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Ordre
{
    class ViewModelFactory : ViewModelFactoryBase<OrdreViewModel>
    {
        public override IDataWrapper<OrdreViewModel> CreateDetailsViewModel(OrdreViewModel obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<OrdreViewModel> CreateItemViewModel(OrdreViewModel obj)
        {
            return new ItemViewModel(obj);
        }
    }
}

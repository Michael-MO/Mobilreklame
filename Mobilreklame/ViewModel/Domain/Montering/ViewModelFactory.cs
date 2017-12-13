using DataTransformation.Interfaces;
using Mobilreklame.DataTransformations.Domain.Montering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Montering
{
    class ViewModelFactory : ViewModelFactoryBase<MonteringViewModel>
    {
        public override IDataWrapper<MonteringViewModel> CreateDetailsViewModel(MonteringViewModel obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<MonteringViewModel> CreateItemViewModel(MonteringViewModel obj)
        {
            return new ItemViewModel(obj);
        }
    }
}
